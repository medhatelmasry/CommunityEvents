using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkyWeb.Models.Custom;
using DataModel.Models;

namespace SkyWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Activity")]
    public class ActivityController : Controller
    {
        private readonly SkyContext _context;

        public ActivityController(SkyContext context)
        {
            _context = context;
        }

        // GET: api/Activity
        [HttpGet]
        public IEnumerable<Activity> GetActivities()
        {
            return _context.Activities;
            //return _context.Activities.Include(a => a.Category);
        }

        // GET: api/Activity/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Activity activity = await _context.Activities.SingleOrDefaultAsync(m => m.ActivityId == id);

            if (activity == null)
            {
                return NotFound();
            }

            return Ok(activity);
        }

        // PUT: api/Activity/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivity([FromRoute] int id, [FromBody] Activity activity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != activity.ActivityId)
            {
                return BadRequest();
            }

            _context.Entry(activity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityExists(id))
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

        // POST: api/Activity
        [HttpPost]
        public async Task<IActionResult> PostActivity([FromBody] Activity activity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Activities.Add(activity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ActivityExists(activity.ActivityId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActivity", new { id = activity.ActivityId }, activity);
        }

        // DELETE: api/Activity/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Activity activity = await _context.Activities.SingleOrDefaultAsync(m => m.ActivityId == id);
            if (activity == null)
            {
                return NotFound();
            }

            _context.Activities.Remove(activity);
            await _context.SaveChangesAsync();

            return Ok(activity);
        }

        private bool ActivityExists(int id)
        {
            return _context.Activities.Any(e => e.ActivityId == id);
        }
    }
}