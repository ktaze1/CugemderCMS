using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CugemderPortal.Shared.Models;
using Microsoft.AspNetCore.Identity;
using CugemderPortal.Server.Models;
using CugemderPortal.Server.Data;

namespace CugemderPortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspNetUsersController : ControllerBase
    {
        private readonly CugemderDatabaseContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _appContext;

        public AspNetUsersController(CugemderDatabaseContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {

            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        // GET: api/AspNetUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AspNetUsers>>> GetAspNetUsers()
        {
            return await _context.AspNetUsers
                .Include(c => c.GroupNavigation)
                .ToListAsync();
        }

        [HttpGet]
        [Route("noGroup")]
        public async Task<ActionResult<IEnumerable<AspNetUsers>>> GetAspNetUsersWithoutGroups()
        {
            return await _context.AspNetUsers.Where(c => c.Group == null).Include(c => c.GroupNavigation)
                .ToListAsync();
        }

        [HttpGet]
        [Route("Group")]
        public async Task<ActionResult<IEnumerable<AspNetUsers>>> GetAspNetUsersWithGroups()
        {
           return await _context.AspNetUsers.Include(c => c.GroupNavigation).Where( x => x.AspNetUserRoles.Count() == 0).ToListAsync();
        }

        // GET: api/AspNetUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AspNetUsers>> GetAspNetUsers(string id)
        {
            var aspNetUsers = await _context.AspNetUsers.FindAsync(id);

            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return aspNetUsers;
        }

        [HttpGet]
        [Route("username/{email}")]
        public async Task<ActionResult<AspNetUsers>> GetUsername(string email)
        {
            var aspNetUsers = await _context.AspNetUsers.Where(c => c.Email == email).FirstOrDefaultAsync();

            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return aspNetUsers;
        }


        [HttpGet]
        [Route("group/{id}")]
        public async Task<ActionResult<IEnumerable<AspNetUsers>>> GetUsersInGroup(int id)
        {
            var aspNetUsers = await _context.AspNetUsers.Where(c => c.Group == id).ToListAsync();
            var test2 = new List<AspNetUsers>();

            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return aspNetUsers;
        }

        // PUT: api/AspNetUsers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAspNetUsers(string id, AspNetUsers aspNetUsers)
        {
            if (id != aspNetUsers.Id)
            {
                return BadRequest();
            }

            _context.Entry(aspNetUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspNetUsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // PUT: api/AspNetUsers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("newGroup/{id}")]
        public async Task<IActionResult> PutAspNetUsersWithRole(string id, AspNetUsers aspNetUsers)
        {
            if (id != aspNetUsers.Id)
            {
                return BadRequest();
            }

            _context.Entry(aspNetUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspNetUsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


            return NoContent();
        }



        // POST: api/AspNetUsers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AspNetUsers>> PostAspNetUsers(AspNetUsers aspNetUsers)
        {
            _context.AspNetUsers.Add(aspNetUsers);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AspNetUsersExists(aspNetUsers.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAspNetUsers", new { id = aspNetUsers.Id }, aspNetUsers);
        }

        // DELETE: api/AspNetUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AspNetUsers>> DeleteAspNetUsers(string id)
        {
            var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            _context.AspNetUsers.Remove(aspNetUsers);
            await _context.SaveChangesAsync();

            return aspNetUsers;
        }

        private bool AspNetUsersExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }
    }
}
