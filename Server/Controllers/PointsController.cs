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
    public class PointsController : ControllerBase
    {
        private readonly CugemderDatabaseContext _context;

        public PointsController(CugemderDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Points
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Points>>> GetPoints()
        {
            return await _context.Points.ToListAsync();
        }

        // GET: api/Points/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Points>> GetPoints(int id)
        {
            var points = await _context.Points.FindAsync(id);

            if (points == null)
            {
                return NotFound();
            }

            return points;
        }

        // PUT: api/Points/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPoints(int id, Points points)
        {
            if (id != points.Id)
            {
                return BadRequest();
            }

            _context.Entry(points).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PointsExists(id))
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

        // POST: api/Points
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Points>> PostPoints(Points points)
        {
            _context.Points.Add(points);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPoints", new { id = points.Id }, points);
        }

        // DELETE: api/Points/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Points>> DeletePoints(string id)
        {
            var user = _context.AspNetUsers.FirstOrDefault(c => c.Id == id);
            user.Points = null;
            var points = await _context.Points.Where(c => c.UserId == id).ToListAsync();
            if (points == null)
            {
                return NotFound();
            }

            foreach (var item in points)
            {
                _context.Points.Remove(item);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PointsExists(int id)
        {
            return _context.Points.Any(e => e.Id == id);
        }
    }
}
