namespace MaritimumCruzeiros.Models
{
    public class Passagem
    {
        public int? Id { get; set; }
        public int? CruzeiroId { get; set; }
        public string? PessoaCompradoraEmail { get; set; }
        public string? PessoaTitularEmail { get; set; }
        public string? NomeTitularDaPassagem { get; set; }
        public string? TitularCPF { get; set; }
        public string? NumeroPassaporte { get; set; }

        public virtual Cruzeiro? Cruzeiro { get; set; }    
    }
}
