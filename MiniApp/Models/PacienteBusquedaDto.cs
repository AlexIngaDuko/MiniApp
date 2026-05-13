namespace MiniApp.Models
{
    public class PacienteBusquedaDto
    {
        public string? HistoriaClinica { get; set; }
        public string? NumeroSis { get; set; }
        public string? Dni { get; set; }

        public string? Nombres { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? NombreCompleto { get; set; }

        public string? Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Edad { get; set; }

        public string? Procedencia { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
    }
}