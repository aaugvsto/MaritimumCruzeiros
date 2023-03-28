using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class SexoPessoaMap : IEntityTypeConfiguration<SexoPessoa>
    {
        public void Configure(EntityTypeBuilder<SexoPessoa> builder)
        {
            // Propiedades

            builder.ToTable("SEXO_PESSOA").HasKey(sx => sx.Id);
            builder.Property(sx => sx.Id).HasColumnName("ID_SEXO_PESSOA");
            builder.Property(sx => sx.Sexo).IsRequired().HasColumnName("SEXO");

            // Relações

        }
    }
}
