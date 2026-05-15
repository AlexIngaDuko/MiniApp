namespace MiniApp.Models
{
    public class Epicrisis
    {
        public List<ProcedimientoTerapeuticoEpicrisis> ProcedimientosTerapeuticos { get; set; } = new();
        public int Id { get; set; }

        public string? Servicio { get; set; }
        public string? HistoriaClinicaNumero { get; set; }
        public string? NumeroSIS { get; set; }

        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Edad { get; set; }
        public string? TipoEdad { get; set; }
        public string? Sexo { get; set; }
        public string? NumeroCama { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Procedencia { get; set; }

        public DateTime? FechaIngresoINSN { get; set; }
        public DateTime? FechaIngresoServicio { get; set; }
        public DateTime? FechaIngresoOtrosServicios { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public int? EstadiaTotalDias { get; set; }
        public string? FechaIngresoINSNTexto { get; set; }
        public string? FechaIngresoServicioTexto { get; set; }
        public string? FechaIngresoOtrosServiciosTexto { get; set; }
        public string? FechaAltaTexto { get; set; }
        public string? FechaEgresoTexto { get; set; }


        public string? Antecedentes { get; set; }
        public string? EnfermedadActualResumen { get; set; }
        public string? ExamenFisico { get; set; }
        public string? EvolucionTratamiento { get; set; }

        public decimal? TemperaturaIngreso { get; set; }
        public string? PresionArterial { get; set; }
        public string? Pulso { get; set; }
        public decimal? Temperatura { get; set; }
        public int? FrecuenciaCardiaca { get; set; }
        public int? FrecuenciaRespiratoria { get; set; }

        public string? DiagnosticoIngreso { get; set; }
        public string? Cie10Ingreso { get; set; }

        public string? DiagnosticoNutricional { get; set; }
        public string? Evolucion { get; set; }

        public DateTime? InterconsultaFecha1 { get; set; }
        public string? InterconsultaEspecialidad1 { get; set; }
        public string? InterconsultaConclusion1 { get; set; }

        public DateTime? InterconsultaFecha2 { get; set; }
        public string? InterconsultaEspecialidad2 { get; set; }
        public string? InterconsultaConclusion2 { get; set; }

        public DateTime? InterconsultaFecha3 { get; set; }
        public string? InterconsultaEspecialidad3 { get; set; }
        public string? InterconsultaConclusion3 { get; set; }

        public string? Medicamento1 { get; set; }
        public string? DosisMgKg1 { get; set; }
        public string? Via1 { get; set; }
        public string? TiempoAdministracion1 { get; set; }

        public string? Medicamento2 { get; set; }
        public string? DosisMgKg2 { get; set; }
        public string? Via2 { get; set; }
        public string? TiempoAdministracion2 { get; set; }

        public string? Medicamento3 { get; set; }
        public string? DosisMgKg3 { get; set; }
        public string? Via3 { get; set; }
        public string? TiempoAdministracion3 { get; set; }

        public string? ProcedimientoTerapeutico1 { get; set; }
        public string? CodigoProcedimiento1 { get; set; }

        public string? ProcedimientoTerapeutico2 { get; set; }
        public string? CodigoProcedimiento2 { get; set; }

        public string? ProcedimientoTerapeutico3 { get; set; }
        public string? CodigoProcedimiento3 { get; set; }

        public string? DiagnosticoAlta { get; set; }
        public string? Cie10Alta { get; set; }

        public string? Nutricional { get; set; }

        public bool InmunizacionCompleta { get; set; }
        public bool InmunizacionIncompleta { get; set; }

        public bool CondicionCurado { get; set; }
        public bool CondicionMejorado { get; set; }
        public bool CondicionEmpeorado { get; set; }
        public bool CondicionEstacionario { get; set; }
        public bool CondicionFallecido { get; set; }

        public bool TipoAltaMedica { get; set; }
        public bool TipoAltaVoluntaria { get; set; }
        public bool TipoAltaTransferencia { get; set; }
        public bool TipoAltaFallecido { get; set; }

        public bool NecropsiaSi { get; set; }
        public bool NecropsiaNo { get; set; }

        public string? Pronostico { get; set; }
        public string? Pendiente { get; set; }
        public string? IndicacionesAlta { get; set; }

        public string? NombreFirmaInterno { get; set; }
        public string? NombreFirmaMedicoResidente1 { get; set; }
        public string? NombreFirmaMedicoTratante { get; set; }
        public string? NombreFirmaMedicoResidente2 { get; set; }
        public string? NombresFinales { get; set; }
        public string? ApellidosFinales { get; set; }
        public string? HcFinal { get; set; }
        public string? CamaFinal { get; set; }

        public List<ExamenAuxiliar> ExamenesAuxiliares { get; set; } = new();
    }
}