using System.ComponentModel.DataAnnotations;

namespace MaritimumCruzeiros.Models
{
    public class Navio
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public int CapacidadePessoas { get; set; }

        public ICollection<Cabine>? Cabines { get; set; }
    }
}
