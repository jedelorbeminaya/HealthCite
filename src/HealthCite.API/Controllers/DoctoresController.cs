using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthCite.Domain.Entities;
using HealthCite.Infrastructure;

namespace HealthCite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        private readonly HealthCiteDbContext _context;

        public DoctoresController(HealthCiteDbContext context)
        {
            _context = context;
        }

        // GET: api/Doctores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctores>>> GetDoctores()
        {
            return await _context.Doctores.ToListAsync();
        }

        // GET: api/Doctores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Doctores>> GetDoctores(int id)
        {
            var doctores = await _context.Doctores.FindAsync(id);

            if (doctores == null)
            {
                return NotFound();
            }

            return doctores;
        }

        // PUT: api/Doctores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctores(int id, Doctores doctores)
        {
            if (id != doctores.Id)
            {
                return BadRequest();
            }

            _context.Entry(doctores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctoresExists(id))
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

        // POST: api/Doctores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Doctores>> PostDoctores(Doctores doctores)
        {
            _context.Doctores.Add(doctores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoctores", new { id = doctores.Id }, doctores);
        }

        // DELETE: api/Doctores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctores(int id)
        {
            var doctores = await _context.Doctores.FindAsync(id);
            if (doctores == null)
            {
                return NotFound();
            }

            _context.Doctores.Remove(doctores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DoctoresExists(int id)
        {
            return _context.Doctores.Any(e => e.Id == id);
        }
    }
}
