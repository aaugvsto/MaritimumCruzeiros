using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Models
{
    public class Cupom
    {
        public int IdCupom { get; set; }
        public string? Codigo { get; set; }
        public double? PorcentagemDesconto { get; set; }
    }
}
