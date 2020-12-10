using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TargetaCreditoController : ControllerBase
    {
        private readonly db _context;

        public TargetaCreditoController(db context)
        {
            _context = context;
        }

        // GET: api/TargetaCredito
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TargetaCredito>>> GetTargetaCredito()
        {
            return await _context.TargetaCredito.ToListAsync();
        }

        // GET: api/TargetaCredito/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TargetaCredito>> GetTargetaCredito(int id)
        {
            var targetaCredito = await _context.TargetaCredito.FindAsync(id);

            if (targetaCredito == null)
            {
                return NotFound();
            }

            return targetaCredito;
        }

        // PUT: api/TargetaCredito/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTargetaCredito(int id, TargetaCredito targetaCredito)
        {
            if (id != targetaCredito.id)
            {
                return BadRequest();
            }

            _context.Entry(targetaCredito).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TargetaCreditoExists(id))
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

        // POST: api/TargetaCredito
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TargetaCredito>> PostTargetaCredito(TargetaCredito targetaCredito)
        {
            _context.TargetaCredito.Add(targetaCredito);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTargetaCredito", new { id = targetaCredito.id }, targetaCredito);
        }

        // DELETE: api/TargetaCredito/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TargetaCredito>> DeleteTargetaCredito(int id)
        {
            var targetaCredito = await _context.TargetaCredito.FindAsync(id);
            if (targetaCredito == null)
            {
                return NotFound();
            }

            _context.TargetaCredito.Remove(targetaCredito);
            await _context.SaveChangesAsync();

            return targetaCredito;
        }

        private bool TargetaCreditoExists(int id)
        {
            return _context.TargetaCredito.Any(e => e.id == id);
        }
    }
}
