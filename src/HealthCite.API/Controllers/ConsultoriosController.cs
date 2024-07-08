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
    public class ConsultoriosController : ControllerBase
    {
        private readonly HealthCiteDbContext _context;

        public ConsultoriosController(HealthCiteDbContext context)
        {
            _context = context;
        }

        // GET: api/Consultorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Consultorios>>> GetConsultorios()
        {
            return await _context.Consultorios.ToListAsync();
        }

        // GET: api/Consultorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Consultorios>> GetConsultorios(int id)
        {
            var consultorios = await _context.Consultorios.FindAsync(id);

            if (consultorios == null)
            {
                return NotFound();
            }

            return consultorios;
        }

        // PUT: api/Consultorios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultorios(int id, Consultorios consultorios)
        {
            if (id != consultorios.Id)
            {
                return BadRequest();
            }

            _context.Entry(consultorios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultoriosExists(id))
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

        // POST: api/Consultorios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consultorios>> PostConsultorios(Consultorios consultorios)
        {
            _context.Consultorios.Add(consultorios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsultorios", new { id = consultorios.Id }, consultorios);
        }

        // DELETE: api/Consultorios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultorios(int id)
        {
            var consultorios = await _context.Consultorios.FindAsync(id);
            if (consultorios == null)
            {
                return NotFound();
            }

            _context.Consultorios.Remove(consultorios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConsultoriosExists(int id)
        {
            return _context.Consultorios.Any(e => e.Id == id);
        }
    }
}
