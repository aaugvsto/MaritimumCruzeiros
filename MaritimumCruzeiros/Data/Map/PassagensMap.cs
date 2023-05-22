using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class PassagensMap : IEntityTypeConfiguration<Passagem>
    {
        public void Configure(EntityTypeBuilder<Passagem> builder)
        {
            builder.ToTable("PASSAGENS");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID_PASSAGEM");
            builder.Property(x => x.CruzeiroId).HasColumnName("CRUZEIRO_ID").IsRequired();
            builder.Property(x => x.PessoaCompradoraEmail).HasColumnName("EMAIL_PESSOA_COMPRADORA").IsRequired();
            builder.Property(x => x.PessoaTitularEmail).HasColumnName("EMAIL_PESSOA_TITULAR");
            builder.Property(x => x.NomeTitularDaPassagem).HasColumnName("NOME_TITULAR_PASSAGEN");
            builder.Property(x => x.TitularCPF).HasColumnName("CPF_TITULAR_PASSAGEM");
            builder.Property(x => x.NumeroPassaporte).HasColumnName("PASSAPORTE_TITULAR_PASSAGEM");

            builder.HasOne(x => x.Cruzeiro)
                .WithMany()
                .HasForeignKey(x => x.CruzeiroId);
        }
    }
}
