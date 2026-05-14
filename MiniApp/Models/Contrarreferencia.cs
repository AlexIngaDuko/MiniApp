namespace MiniApp.Models
{
    public class Contrarreferencia
    {
        public int Id { get; set; }

        public string? Fecha { get; set; }
        public string? Hora { get; set; }
        public string? NumeroContrarreferencia { get; set; }

        public string? Asegurado { get; set; }
        public string? TipoAsegurado { get; set; }
        public string? PlanesSis { get; set; }

        public string? EstablecimientoOrigen { get; set; }
        public string? EstablecimientoDestino { get; set; }

        public string? CodigoSis { get; set; }
        public string? HistoriaClinica { get; set; }
        public string? DniPaciente { get; set; }

        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Nombres { get; set; }

        public string? Sexo { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Edad { get; set; }

        public string? Direccion { get; set; }
        public string? Distrito { get; set; }
        public string? Departamento { get; set; }

        public string? FechaIngreso { get; set; }
        public string? FechaEgreso { get; set; }

        public string? DiagnosticoIngreso { get; set; }
        public string? DiagnosticoEgreso { get; set; }

        public string? Cie10DiagnosticoEgreso { get; set; }
        public string? DprDiagnosticoEgreso { get; set; }

        public string? TratamientoProcedimientos { get; set; }
        public string? ReportesProcedimientos { get; set; }

        public string? OrigenReferencia { get; set; }
        public string? CalificacionReferencia { get; set; }
        public string? UpsContrarreferencia { get; set; }
        public string? Especialidad { get; set; }

        public string? Recomendaciones { get; set; }

        public string? CondicionUsuario { get; set; }

        public string? NombreResponsable { get; set; }
        public string? NumeroColegiatura { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}