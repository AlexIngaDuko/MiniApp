using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MiniApp.Models;

namespace MiniApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public PacientesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarPaciente(
            [FromQuery] string? dni,
            [FromQuery] string? hc,
            [FromQuery] string? nombres,
            [FromQuery] string? apellidos)
        {
            var connectionString = _configuration.GetConnectionString("HospitalConnection");

            var pacientes = new List<PacienteBusquedaDto>();

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            var sql = @"
                SELECT TOP 20
                    CNUMEROSHC,
                    SCOD_AFIL,
                    DNIPACI,
                    CAPATERPAC,
                    CAMATERPAC,
                    CNOMBREPAC,
                    CNPACIENTE,
                    CSEXOSPACI,
                    CFECHANACI,
                    CEDADSACTU,
                    CDIREPROCE,
                    CORREO,
                    CCTELEFONO
                FROM [Gestion_2012].[dbo].[HC]
                WHERE
                    (@dni IS NULL OR DNIPACI LIKE '%' + @dni + '%')
                    AND (@hc IS NULL OR CNUMEROSHC LIKE '%' + @hc + '%')
                    AND (@nombres IS NULL OR CNOMBREPAC LIKE '%' + @nombres + '%')
                    AND (@apellidos IS NULL OR 
                        (ISNULL(CAPATERPAC,'') + ' ' + ISNULL(CAMATERPAC,'')) LIKE '%' + @apellidos + '%')
                ORDER BY CNUMEROSHC DESC
            ";

            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@dni", string.IsNullOrWhiteSpace(dni) ? DBNull.Value : dni);
            command.Parameters.AddWithValue("@hc", string.IsNullOrWhiteSpace(hc) ? DBNull.Value : hc);
            command.Parameters.AddWithValue("@nombres", string.IsNullOrWhiteSpace(nombres) ? DBNull.Value : nombres);
            command.Parameters.AddWithValue("@apellidos", string.IsNullOrWhiteSpace(apellidos) ? DBNull.Value : apellidos);

            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var paciente = new PacienteBusquedaDto
                {
                    HistoriaClinica = reader["CNUMEROSHC"]?.ToString(),
                    NumeroSis = reader["SCOD_AFIL"]?.ToString(),
                    Dni = reader["DNIPACI"]?.ToString(),

                    ApellidoPaterno = reader["CAPATERPAC"]?.ToString(),
                    ApellidoMaterno = reader["CAMATERPAC"]?.ToString(),
                    Nombres = reader["CNOMBREPAC"]?.ToString(),
                    NombreCompleto = reader["CNPACIENTE"]?.ToString(),

                    Sexo = reader["CSEXOSPACI"]?.ToString(),
                    Edad = reader["CEDADSACTU"]?.ToString(),
                    Procedencia = reader["CDIREPROCE"]?.ToString(),
                    Correo = reader["CORREO"]?.ToString(),
                    Telefono = reader["CCTELEFONO"]?.ToString()
                };

                if (reader["CFECHANACI"] != DBNull.Value)
                    paciente.FechaNacimiento = Convert.ToDateTime(reader["CFECHANACI"]);

                pacientes.Add(paciente);
            }

            return Ok(pacientes);
        }
    }
}