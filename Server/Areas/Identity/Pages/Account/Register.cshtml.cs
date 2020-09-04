using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using CugemderPortal.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Security.Cryptography;
using CugemderPortal.Shared.Models;

namespace CugemderPortal.Server.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IHostingEnvironment _environment;
        private readonly CugemderDatabaseContext _context;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IHostingEnvironment environment,
            CugemderDatabaseContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _environment = environment;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required]
            [Display(Name = "Ad")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Soyad")]
            public string Surname { get; set; }

            [Required]
            [Phone]
            [Display(Name = "Telefon")]
            public string Phone { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [BindProperty]
            public IFormFileCollection Upload { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {

            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {

                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, firstName = Input.Name, surName = Input.Surname, phoneNo = Input.Phone, createdAt = DateTime.UtcNow };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    long size = Input.Upload.Sum(s => s.Length);

                    foreach (var item in Input.Upload)
                    {
                        if(item.Length > 0)
                        {
                            FileInfo fi = new FileInfo(item.FileName);
                            string encodedStr = string.Format(@"{0}", Guid.NewGuid());

                            //using (SHA1Managed sha1 = new SHA1Managed())
                            //{
                            //    var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(item.FileName));
                            //    var sb = new StringBuilder(hash.Length * 2);

                            //    foreach (byte b in hash)
                            //    {
                            //        // can be "x2" if you want lowercase
                            //        sb.Append(b.ToString("X2"));
                            //    }

                            //    encodedStr = sb.ToString();
                            //}

                            var file = Path.Combine(_environment.ContentRootPath, "UploadedContent", $"{encodedStr}{fi.Extension}");
                            Uploads uploads = new Uploads();
                            uploads.UserId = user.Id;
                            uploads.FileName = $"{encodedStr}{fi.Extension}";
                            _context.Uploads.Add(uploads);
                            await _context.SaveChangesAsync();

                            using (var fileStream = new FileStream(file, FileMode.Create))
                            {
                                await item.CopyToAsync(fileStream);
                            }
                        }

                    }

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
