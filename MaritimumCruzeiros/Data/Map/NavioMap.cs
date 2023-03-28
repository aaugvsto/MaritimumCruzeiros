using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class NavioMap : IEntityTypeConfiguration<Navio>
    {
        public void Configure(EntityTypeBuilder<Navio> builder)
        {
            // Propiedades

            builder.ToTable("NAVIOS").HasKey(n => n.Id);
            builder.Property(n => n.Id).HasColumnName("ID_NAVIO");

            builder.Property(n => n.Nome).HasColumnName("NOME").IsRequired();
            builder.Property(n => n.CapacidadePessoas).IsRequired().HasColumnName("CAPACIDADE_PESSOAS");

            // Relações
            builder.HasMany(n => n.Cabines)
                .WithOne(c => c.Navio)
                .HasForeignKey(c => c.NavioId);
        }
    }
}
