using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace MiniApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetasController : ControllerBase
    {
        [HttpPost("enviar-correo")]
        public async Task<IActionResult> EnviarCorreo([FromBody] RecetaCorreoRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Correo))
                return BadRequest("Debe ingresar un correo.");

            if (string.IsNullOrWhiteSpace(request.Receta))
                return BadRequest("La receta está vacía.");

            var mensaje = new MailMessage
            {
                From = new MailAddress("TU_CORREO@gmail.com"),
                Subject = "Receta médica",
                Body = request.Receta
            };

            mensaje.To.Add(request.Correo);

            using var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("TU_CORREO@gmail.com", "TU_CLAVE_DE_APLICACION"),
                EnableSsl = true
            };

            await smtp.SendMailAsync(mensaje);

            return Ok("Receta enviada correctamente al correo.");
        }

        [HttpPost("enviar-sms")]
        public IActionResult EnviarSms([FromBody] RecetaSmsRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Celular))
                return BadRequest("Debe ingresar un celular.");

            if (string.IsNullOrWhiteSpace(request.Receta))
                return BadRequest("La receta está vacía.");

            // Aquí luego conectaremos un proveedor real de SMS.
            return Ok("SMS enviado correctamente.");
        }
    }

    public class RecetaCorreoRequest
    {
        public string? Correo { get; set; }
        public string? Receta { get; set; }
    }

    public class RecetaSmsRequest
    {
        public string? Celular { get; set; }
        public string? Receta { get; set; }
    }
}