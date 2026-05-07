namespace MiniApp.Models
{
    public class ProcedimientoTerapeuticoEpicrisis
    {
        public int Id { get; set; }

        public string? Procedimiento { get; set; }
        public string? Codigo { get; set; }

        public int EpicrisisId { get; set; }
        public Epicrisis? Epicrisis { get; set; }
    }
}