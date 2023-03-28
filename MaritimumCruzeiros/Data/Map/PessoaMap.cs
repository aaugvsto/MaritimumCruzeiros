using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            // Propriedades
            builder.ToTable("PESSOAS").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ID_PESSOA");

            builder.Property(p => p.Nome).IsRequired().HasMaxLength(255).HasColumnName("NOME");
            builder.Property(P => P.Idade).IsRequired().HasColumnName("IDADE");
            builder.Property(p => p.SexoPessoaId).IsRequired().HasColumnName("ID_SEXO_PESSOA");
            builder.Property(p => p.Documento).IsRequired().HasColumnName("DOCUMENTO");

            // Relações

            builder.HasOne(p => p.SexoPessoa)
                .WithMany()
                .HasForeignKey(p => p.SexoPessoaId);
        }
    }
}
