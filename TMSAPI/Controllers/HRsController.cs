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
    public class HRsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public HRsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/HRs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HR>>> Gethr()
        {
            return await _context.hr.ToListAsync();
        }

        // GET: api/HRs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HR>> GetHR(int id)
        {
            var hR = await _context.hr.FindAsync(id);

            if (hR == null)
            {
                return NotFound();
            }

            return hR;
        }

        // PUT: api/HRs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHR(int id, HR hR)
        {
            if (id != hR.HRId)
            {
                return BadRequest();
            }

            _context.Entry(hR).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HRExists(id))
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

        // POST: api/HRs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HR>> PostHR(HR hR)
        {
            _context.hr.Add(hR);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHR", new { id = hR.HRId }, hR);
        }

        // DELETE: api/HRs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHR(int id)
        {
            var hR = await _context.hr.FindAsync(id);
            if (hR == null)
            {
                return NotFound();
            }

            _context.hr.Remove(hR);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HRExists(int id)
        {
            return _context.hr.Any(e => e.HRId == id);
        }
    }
}
