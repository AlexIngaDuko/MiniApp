using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniApp.Data;
using MiniApp.Models;

namespace MiniApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformesAltaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InformesAltaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetInformesAlta()
        {
            return Ok(await _context.InformesAlta.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInformeAltaById(int id)
        {
            var informe = await _context.InformesAlta.FindAsync(id);

            if (informe == null)
                return NotFound();

            return Ok(informe);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInformeAlta(InformeAlta informeAlta)
        {
            _context.InformesAlta.Add(informeAlta);
            await _context.SaveChangesAsync();

            return Ok(informeAlta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInformeAlta(int id, InformeAlta updatedInforme)
        {
            var informe = await _context.InformesAlta.FindAsync(id);

            if (informe == null)
                return NotFound();

            _context.Entry(informe).CurrentValues.SetValues(updatedInforme);
            await _context.SaveChangesAsync();

            return Ok(informe);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInformeAlta(int id)
        {
            var informe = await _context.InformesAlta.FindAsync(id);

            if (informe == null)
                return NotFound();

            _context.InformesAlta.Remove(informe);
            await _context.SaveChangesAsync();

            return Ok("Informe de alta eliminado");
        }
    }
}