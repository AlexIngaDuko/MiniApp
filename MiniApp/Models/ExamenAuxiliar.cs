using System.Text.Json.Serialization;

namespace MiniApp.Models
{
    public class ExamenAuxiliar
    {
        public int Id { get; set; }

        public int EpicrisisId { get; set; }

        [JsonIgnore]
        public Epicrisis? Epicrisis { get; set; }

        public string? NombreExamen { get; set; }
        public string? Resultado { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Observaciones { get; set; }
    }
}