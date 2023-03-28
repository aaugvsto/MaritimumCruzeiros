using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class CabineMap : IEntityTypeConfiguration<Cabine>
    {
        public void Configure(EntityTypeBuilder<Cabine> builder)
        {
            // Propiedades

            builder.ToTable("CABINES").HasKey(c  => c.Id);
            builder.Property(c => c.Id).HasColumnName("ID_CABINE");

            builder.Property(c => c.NavioId).IsRequired().HasColumnName("ID_NAVIO");
            builder.Property(c => c.Numero).IsRequired().HasColumnName("NUMERO");
            builder.Property(c => c.Piso).IsRequired().HasColumnName("PISO");
            builder.Property(c => c.CapacidadeMaxima).IsRequired().HasColumnName("CAPACIDADE_MAXIMA");
            builder.Property(c => c.TipoCabineId).IsRequired().HasColumnName("ID_TIPO_CABINE");

            // Relações

            builder.HasOne(c => c.Navio)
                .WithMany(n => n.Cabines)
                .HasForeignKey(c => c.NavioId);

            builder.HasOne(c => c.TipoCabine)
                .WithMany()
                .HasForeignKey(c => c.TipoCabineId);
        }
    }
}
