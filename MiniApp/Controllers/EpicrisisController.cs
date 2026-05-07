using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniApp.Data;
using MiniApp.Models;

namespace MiniApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpicrisisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EpicrisisController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEpicrisis()
        {
            return Ok(await _context.Epicrisis
                .Include(e => e.ExamenesAuxiliares)
                .Include(e => e.ProcedimientosTerapeuticos)
                .ToListAsync());
        }

        [HttpGet("count")]
        public async Task<IActionResult> CountEpicrisis()
        {
            var cantidad = await _context.Epicrisis.CountAsync();

            return Ok(new
            {
                total = cantidad
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEpicrisis(int id)
        {
            var epicrisis = await _context.Epicrisis
                .Include(e => e.ExamenesAuxiliares)
                .Include(e => e.ProcedimientosTerapeuticos)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (epicrisis == null)
                return NotFound();

            return Ok(epicrisis);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEpicrisis(Epicrisis epicrisis)
        {
            _context.Epicrisis.Add(epicrisis);
            await _context.SaveChangesAsync();

            return Ok(epicrisis);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEpicrisis(int id, Epicrisis updatedEpicrisis)
        {
            var epicrisis = await _context.Epicrisis
                .Include(e => e.ExamenesAuxiliares)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (epicrisis == null)
                return NotFound();

            _context.Entry(epicrisis).CurrentValues.SetValues(updatedEpicrisis);

            epicrisis.ExamenesAuxiliares.Clear();

            foreach (var examen in updatedEpicrisis.ExamenesAuxiliares)
            {
                epicrisis.ExamenesAuxiliares.Add(new ExamenAuxiliar
                {
                    NombreExamen = examen.NombreExamen,
                    Resultado = examen.Resultado,
                    Fecha = examen.Fecha,
                    Observaciones = examen.Observaciones
                });
            }

            await _context.SaveChangesAsync();

            return Ok(epicrisis);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEpicrisis(int id)
        {
            var epicrisis = await _context.Epicrisis
                .Include(e => e.ExamenesAuxiliares)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (epicrisis == null)
                return NotFound();

            _context.Epicrisis.Remove(epicrisis);
            await _context.SaveChangesAsync();

            return Ok("Epicrisis eliminada");
        }
    }
}