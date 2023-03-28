namespace MaritimumCruzeiros.Models
{
    public class Pessoa
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public int SexoPessoaId { get; set; }
        public string? Documento { get; set; }

        public virtual SexoPessoa? SexoPessoa { get; set; }
    }
}
