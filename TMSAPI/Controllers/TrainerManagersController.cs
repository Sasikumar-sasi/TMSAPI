using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMSAPI.Models;

namespace TMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerManagersController : ControllerBase
    {
        private readonly AppDBContext _context;

        public TrainerManagersController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/TrainerManagers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainerManager>>> GettrainersManager()
        {
            return await _context.trainersManager.ToListAsync();
        }

        // GET: api/TrainerManagers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainerManager>> GetTrainerManager(int id)
        {
            var trainerManager = await _context.trainersManager.FindAsync(id);

            if (trainerManager == null)
            {
                return NotFound();
            }

            return trainerManager;
        }

        // PUT: api/TrainerManagers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainerManager(int id, TrainerManager trainerManager)
        {
            if (id != trainerManager.TMID)
            {
                return BadRequest();
            }

            _context.Entry(trainerManager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainerManagerExists(id))
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

        // POST: api/TrainerManagers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TrainerManager>> PostTrainerManager(TrainerManager trainerManager)
        {
            _context.trainersManager.Add(trainerManager);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainerManager", new { id = trainerManager.TMID }, trainerManager);
        }

        // DELETE: api/TrainerManagers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrainerManager(int id)
        {
            var trainerManager = await _context.trainersManager.FindAsync(id);
            if (trainerManager == null)
            {
                return NotFound();
            }

            _context.trainersManager.Remove(trainerManager);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrainerManagerExists(int id)
        {
            return _context.trainersManager.Any(e => e.TMID == id);
        }
    }
}
