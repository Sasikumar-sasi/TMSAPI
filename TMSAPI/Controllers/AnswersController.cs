using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMSAPI.Models;
using TMSClient.Models;

namespace TMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly AppDBContext _context;

        public AnswersController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Answers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Answer>>> Getanswers()
        {
            return await _context.answers.ToListAsync();
        }

        // GET: api/Answers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Answer>> GetAnswer(int id)
        {
            var answer = await _context.answers.FindAsync(id);

            if (answer == null)
            {
                return NotFound();
            }

            return answer;
        }

        // PUT: api/Answers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnswer(int id, Answer answer)
        {
            if (id != answer.AnswerID)
            {
                return BadRequest();
            }

            _context.Entry(answer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnswerExists(id))
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

        // POST: api/Answers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Answer>> PostAnswer(Answer answer)
        {
            _context.answers.Add(answer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnswer", new { id = answer.AnswerID }, answer);
        }

        // DELETE: api/Answers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswer(int id)
        {
            var answer = await _context.answers.FindAsync(id);
            if (answer == null)
            {
                return NotFound();
            }

            _context.answers.Remove(answer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnswerExists(int id)
        {
            return _context.answers.Any(e => e.AnswerID == id);
        }
    }
}
