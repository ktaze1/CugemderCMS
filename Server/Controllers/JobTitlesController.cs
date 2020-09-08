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
    public class JobTitlesController : ControllerBase
    {
        private readonly CugemderDatabaseContext _context;

        public JobTitlesController(CugemderDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/JobTitles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTitles>>> GetJobTitles()
        {
            return await _context.JobTitles.ToListAsync();
        }

        // GET: api/JobTitles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobTitles>> GetJobTitles(int id)
        {
            var jobTitles = await _context.JobTitles.FindAsync(id);

            if (jobTitles == null)
            {
                return NotFound();
            }

            return jobTitles;
        }

        // PUT: api/JobTitles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobTitles(int id, JobTitles jobTitles)
        {
            if (id != jobTitles.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobTitles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobTitlesExists(id))
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

        // POST: api/JobTitles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<JobTitles>> PostJobTitles(JobTitles jobTitles)
        {
            _context.JobTitles.Add(jobTitles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobTitles", new { id = jobTitles.Id }, jobTitles);
        }

        // DELETE: api/JobTitles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JobTitles>> DeleteJobTitles(int id)
        {
            var jobTitles = await _context.JobTitles.FindAsync(id);
            if (jobTitles == null)
            {
                return NotFound();
            }

            _context.JobTitles.Remove(jobTitles);
            await _context.SaveChangesAsync();

            return jobTitles;
        }

        private bool JobTitlesExists(int id)
        {
            return _context.JobTitles.Any(e => e.Id == id);
        }
    }
}
