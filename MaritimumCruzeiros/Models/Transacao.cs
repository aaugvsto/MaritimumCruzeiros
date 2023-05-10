namespace MaritimumCruzeiros.Models
{
    public class Transacao
    {
        public int? Id { get; set; }
        public string? EmailCliente { get; set; }
        public string? NumerosFinaisCartao { get; set; }
        public char? TipoCartao { get; set; }
        public int? NumeroParcelas { get; set; }
        public string? Resultado { get; set; }
        public double? ValorTotal { get; set; }
    }
}
