namespace MiniApp.Models
{
    public class InformeAlta
    {
        public int Id { get; set; }

        public string? Servicio { get; set; }
        public string? NumeroCama { get; set; }
        public string? NumeroHistoriaClinica { get; set; }
        public string? NumeroSIS { get; set; }
        public string? Sala { get; set; }

        public string? NombresApellidos { get; set; }
        public string? Edad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Sexo { get; set; }
        public string? Domicilio { get; set; }

        public bool IngresoEmergencia { get; set; }
        public bool IngresoConsultaExterna { get; set; }

        public string? FechaIngresoEmergenciaTexto { get; set; }
        public string? FechaIngresoServicioTexto { get; set; }
        public string? FechaAltaServicioTexto { get; set; }

        public string? DiagnosticoIngreso1 { get; set; }
        public string? CieIngreso1 { get; set; }
        public string? DiagnosticoIngreso2 { get; set; }
        public string? CieIngreso2 { get; set; }
        public string? DiagnosticoIngreso3 { get; set; }
        public string? CieIngreso3 { get; set; }
        public string? DiagnosticoIngreso4 { get; set; }
        public string? CieIngreso4 { get; set; }

        public string? DiagnosticoAlta1 { get; set; }
        public string? CieAlta1 { get; set; }
        public string? DiagnosticoAlta2 { get; set; }
        public string? CieAlta2 { get; set; }
        public string? DiagnosticoAlta3 { get; set; }
        public string? CieAlta3 { get; set; }
        public string? DiagnosticoAlta4 { get; set; }
        public string? CieAlta4 { get; set; }

        public string? ProcedimientosCirugia { get; set; }
        public string? CodigoCpt { get; set; }

        public string? ExamenesImagen { get; set; }
        public string? ExamenesLaboratorio { get; set; }

        public string? Farmaco1 { get; set; }
        public string? DiasFarmaco1 { get; set; }
        public string? Farmaco2 { get; set; }
        public string? DiasFarmaco2 { get; set; }
        public string? Farmaco3 { get; set; }
        public string? DiasFarmaco3 { get; set; }

        public string? RecomendacionesAlta { get; set; }
        public string? OtrasIndicaciones { get; set; }
        public string? Dieta { get; set; }
        public string? CuidadosHigienicos { get; set; }
        public string? Vacunas { get; set; }
        public string? CuidadosTraslado { get; set; }

        public bool MotivoAltaMedica { get; set; }
        public bool MotivoRetiroVoluntario { get; set; }
        public bool MotivoReferencia { get; set; }
        public bool MotivoContrarreferencia { get; set; }
        public bool MotivoFuga { get; set; }
        public bool MotivoFallecido { get; set; }

        public bool CondicionCurado { get; set; }
        public bool CondicionMejorado { get; set; }
        public bool CondicionEstacionario { get; set; }
        public bool CondicionEmpeorado { get; set; }
        public bool CondicionFallecido { get; set; }

        public bool PronosticoBueno { get; set; }
        public bool PronosticoReservado { get; set; }

        public string? CitaConsultorio1 { get; set; }
        public string? FechaCita1 { get; set; }
        public string? CitaConsultorio2 { get; set; }
        public string? FechaCita2 { get; set; }
        public string? CitaConsultorio3 { get; set; }
        public string? FechaCita3 { get; set; }

        public string? FirmaPadreApoderado { get; set; }
        public string? DniApoderado { get; set; }
        public string? Parentesco { get; set; }

        public string? JefeServicio { get; set; }
        public string? MedicoTratante { get; set; }
    }
}