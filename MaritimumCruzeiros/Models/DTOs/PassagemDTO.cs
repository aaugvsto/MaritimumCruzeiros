namespace MaritimumCruzeiros.Models.DTOs
{
    public class PassagemDTO
    {
        public int? Id { get; set; }
        public int? CruzeiroId { get; set; }
        public string? PessoaCompradoraEmail { get; set; }
        public string? PessoaTitularEmail { get; set; }
        public string? NomeTitularDaPassagem { get; set; }
        public string? TitularCPF { get; set; }
        public string? NumeroPassaporte { get; set; }
    }
}
