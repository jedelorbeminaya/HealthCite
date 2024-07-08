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
    public class EstadoCitasController : ControllerBase
    {
        private readonly HealthCiteDbContext _context;

        public EstadoCitasController(HealthCiteDbContext context)
        {
            _context = context;
        }

        // GET: api/EstadoCitas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoCitas>>> GetEstadosCitas()
        {
            return await _context.EstadosCitas.ToListAsync();
        }

        // GET: api/EstadoCitas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadoCitas>> GetEstadoCitas(int id)
        {
            var estadoCitas = await _context.EstadosCitas.FindAsync(id);

            if (estadoCitas == null)
            {
                return NotFound();
            }

            return estadoCitas;
        }

        // PUT: api/EstadoCitas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadoCitas(int id, EstadoCitas estadoCitas)
        {
            if (id != estadoCitas.Id)
            {
                return BadRequest();
            }

            _context.Entry(estadoCitas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadoCitasExists(id))
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

        // POST: api/EstadoCitas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstadoCitas>> PostEstadoCitas(EstadoCitas estadoCitas)
        {
            _context.EstadosCitas.Add(estadoCitas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadoCitas", new { id = estadoCitas.Id }, estadoCitas);
        }

        // DELETE: api/EstadoCitas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadoCitas(int id)
        {
            var estadoCitas = await _context.EstadosCitas.FindAsync(id);
            if (estadoCitas == null)
            {
                return NotFound();
            }

            _context.EstadosCitas.Remove(estadoCitas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadoCitasExists(int id)
        {
            return _context.EstadosCitas.Any(e => e.Id == id);
        }
    }
}
