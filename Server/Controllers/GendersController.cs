using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CugemderPortal.Shared.Models;

namespace CugemderPortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly CugemderDatabaseContext _context;

        public GendersController(CugemderDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Genders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genders>>> GetGenders()
        {
            return await _context.Genders.ToListAsync();
        }

        // GET: api/Genders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genders>> GetGenders(int id)
        {
            var genders = await _context.Genders.FindAsync(id);

            if (genders == null)
            {
                return NotFound();
            }

            return genders;
        }

        // PUT: api/Genders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenders(int id, Genders genders)
        {
            if (id != genders.Id)
            {
                return BadRequest();
            }

            _context.Entry(genders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GendersExists(id))
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

        // POST: api/Genders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Genders>> PostGenders(Genders genders)
        {
            _context.Genders.Add(genders);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GendersExists(genders.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGenders", new { id = genders.Id }, genders);
        }

        // DELETE: api/Genders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Genders>> DeleteGenders(int id)
        {
            var genders = await _context.Genders.FindAsync(id);
            if (genders == null)
            {
                return NotFound();
            }

            _context.Genders.Remove(genders);
            await _context.SaveChangesAsync();

            return genders;
        }

        private bool GendersExists(int id)
        {
            return _context.Genders.Any(e => e.Id == id);
        }
    }
}
