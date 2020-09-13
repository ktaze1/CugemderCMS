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
    public class MeetingsController : ControllerBase
    {
        private readonly CugemderDatabaseContext _context;

        public MeetingsController(CugemderDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Meetings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meetings>>> GetMeetings()
        {
            return await _context.Meetings.ToListAsync();
        }

        [HttpGet]
        [Route("user/points/{id}")]
        public async Task<ActionResult<IEnumerable<Meetings>>> GetMeetingsNeedPoint(string id)
        {
            return await _context.Meetings
                .Where(c => c.ReceiverId == id)
                .Where(c => c.IsApproved == true)
                .Where(c => c.IsResulted == false)
                .Where(c => c.Date.AddHours(2) < DateTime.Now)
                .Include(c => c.Sender)
                .ToListAsync();
        }

        // GET: api/Meetings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meetings>> GetMeetings(int id)
        {
            var meetings = await _context.Meetings.FindAsync(id);

            if (meetings == null)
            {
                return NotFound();
            }

            return meetings;
        }

        [HttpGet]
        [Route("user/{id}")]
        public async Task<ActionResult<IEnumerable<Meetings>>> GetMeetingsOfUser(string id)
        {
            var meetings = await _context.Meetings.Include(c => c.Sender).Where(c => c.ReceiverId == id).ToListAsync();

            if (meetings == null)
            {
                return NotFound();
            }

            return meetings;
        }

        // PUT: api/Meetings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeetings(int id, Meetings meetings)
        {
            if (id != meetings.Id)
            {
                return BadRequest();
            }

            _context.Entry(meetings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingsExists(id))
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

        // POST: api/Meetings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Meetings>> PostMeetings(Meetings meetings)
        {
            _context.Meetings.Add(meetings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeetings", new { id = meetings.Id }, meetings);
        }

        // DELETE: api/Meetings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Meetings>> DeleteMeetings(int id)
        {
            var meetings = await _context.Meetings.FindAsync(id);
            if (meetings == null)
            {
                return NotFound();
            }

            _context.Meetings.Remove(meetings);
            await _context.SaveChangesAsync();

            return meetings;
        }

        private bool MeetingsExists(int id)
        {
            return _context.Meetings.Any(e => e.Id == id);
        }
    }
}
