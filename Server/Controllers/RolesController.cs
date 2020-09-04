using CugemderPortal.Server.Data;
using CugemderPortal.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CugemderPortal.Server.Controllers
{
    public class RolesController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public RolesController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext applicationDbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = applicationDbContext;
        }

        [HttpGet("/roles")]
        public async Task<ActionResult<IEnumerable<string>>> GetRoles()
        {
            return await _context.Roles.Select(x => x.Name).ToListAsync();
        }

        [HttpPost("User/AddRole")]
        public async Task<IActionResult> AddRoleToUSer([FromBody] NewRoleForm newRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(id);
            if (!await _roleManager.RoleExistsAsync(newRole.NewRole))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = newRole.NewRole });
            }

            await _userManager.AddToRoleAsync(user, newRole.NewRole);

            return Ok();

        }

        public class NewRoleForm
        {
            public string NewRole { get; set; }
        }
    }
}
