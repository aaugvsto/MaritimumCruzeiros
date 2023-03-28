using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MaritimumCruzeiros.Models
{
    public class Cruzeiro
    {
        public int? Id { get; set; }
        public string? NomeExpedicao { get; set; }
        public DateTime DataPartida { get; set; }
        public DateTime DataChegada { get; set; }
        public string? Descricao { get; set; }
        public int? NavioId { get; set; }

        public virtual ICollection<Tripulante>? Tripulantes { get; set; }
        public virtual Navio? Navio { get; set; }
    }
}
