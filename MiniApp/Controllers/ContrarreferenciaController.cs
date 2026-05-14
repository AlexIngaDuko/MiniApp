using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniApp.Data;
using MiniApp.Models;

namespace MiniApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContrarreferenciaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContrarreferenciaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetContrarreferencias()
        {
            var contrarreferencias = await _context.Contrarreferencias
                .OrderByDescending(c => c.Id)
                .ToListAsync();

            return Ok(contrarreferencias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContrarreferencia(int id)
        {
            var contrarreferencia = await _context.Contrarreferencias
                .FirstOrDefaultAsync(c => c.Id == id);

            if (contrarreferencia == null)
                return NotFound("No se encontró la contrarreferencia.");

            return Ok(contrarreferencia);
        }

        [HttpPost]
        public async Task<IActionResult> CrearContrarreferencia([FromBody] Contrarreferencia contrarreferencia)
        {
            if (contrarreferencia == null)
                return BadRequest("La información enviada está vacía.");

            contrarreferencia.FechaRegistro = DateTime.Now;

            _context.Contrarreferencias.Add(contrarreferencia);
            await _context.SaveChangesAsync();

            return Ok(contrarreferencia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarContrarreferencia(int id, [FromBody] Contrarreferencia contrarreferencia)
        {
            var existente = await _context.Contrarreferencias.FindAsync(id);

            if (existente == null)
                return NotFound("No se encontró la contrarreferencia.");

            existente.Fecha = contrarreferencia.Fecha;
            existente.Hora = contrarreferencia.Hora;
            existente.NumeroContrarreferencia = contrarreferencia.NumeroContrarreferencia;

            existente.Asegurado = contrarreferencia.Asegurado;
            existente.TipoAsegurado = contrarreferencia.TipoAsegurado;

            existente.EstablecimientoOrigen = contrarreferencia.EstablecimientoOrigen;
            existente.EstablecimientoDestino = contrarreferencia.EstablecimientoDestino;

            existente.CodigoSis = contrarreferencia.CodigoSis;
            existente.PlanesSis = contrarreferencia.PlanesSis;
            existente.HistoriaClinica = contrarreferencia.HistoriaClinica;
            existente.DniPaciente = contrarreferencia.DniPaciente;

            existente.ApellidoPaterno = contrarreferencia.ApellidoPaterno;
            existente.ApellidoMaterno = contrarreferencia.ApellidoMaterno;
            existente.Nombres = contrarreferencia.Nombres;

            existente.Sexo = contrarreferencia.Sexo;
            existente.FechaNacimiento = contrarreferencia.FechaNacimiento;
            existente.Edad = contrarreferencia.Edad;
            existente.Direccion = contrarreferencia.Direccion;
            existente.Distrito = contrarreferencia.Distrito;
            existente.Departamento = contrarreferencia.Departamento;

            existente.FechaIngreso = contrarreferencia.FechaIngreso;
            existente.FechaEgreso = contrarreferencia.FechaEgreso;

            existente.DiagnosticoIngreso = contrarreferencia.DiagnosticoIngreso;
            existente.DiagnosticoEgreso = contrarreferencia.DiagnosticoEgreso;
            existente.TratamientoProcedimientos = contrarreferencia.TratamientoProcedimientos;
            existente.ReportesProcedimientos = contrarreferencia.ReportesProcedimientos;

            existente.OrigenReferencia = contrarreferencia.OrigenReferencia;
            existente.CalificacionReferencia = contrarreferencia.CalificacionReferencia;
            existente.UpsContrarreferencia = contrarreferencia.UpsContrarreferencia;
            existente.Especialidad = contrarreferencia.Especialidad;

            existente.Recomendaciones = contrarreferencia.Recomendaciones;

            existente.CondicionUsuario = contrarreferencia.CondicionUsuario;
            existente.NombreResponsable = contrarreferencia.NombreResponsable;
            existente.NumeroColegiatura = contrarreferencia.NumeroColegiatura;

            await _context.SaveChangesAsync();

            return Ok(existente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarContrarreferencia(int id)
        {
            var contrarreferencia = await _context.Contrarreferencias.FindAsync(id);

            if (contrarreferencia == null)
                return NotFound("No se encontró la contrarreferencia.");

            _context.Contrarreferencias.Remove(contrarreferencia);
            await _context.SaveChangesAsync();

            return Ok("Contrarreferencia eliminada correctamente.");
        }
    }
}