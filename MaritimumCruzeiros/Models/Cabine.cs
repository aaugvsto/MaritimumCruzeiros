using MaritimumCruzeiros.Models;
using System.ComponentModel.DataAnnotations;

namespace MaritimumCruzeiros.Models
{
    public class Cabine
    {
        public int? Id { get; set; }
        public int NavioId { get; set; }
        public string? Numero { get; set; }
        public string? Piso { get; set; }
        public int CapacidadeMaxima { get; set; }
        public int TipoCabineId { get; set; }

        public virtual Navio? Navio { get; set; }
        public virtual TipoCabine? TipoCabine { get; set; }
    }
}
