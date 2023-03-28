using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CruzeirosEmporio.Data.Map
{
    public class TripulanteMap : IEntityTypeConfiguration<Tripulante>
    {
        public void Configure(EntityTypeBuilder<Tripulante> builder)
        {
            // Propiedades

            builder.ToTable("TRIPULANTES").HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("ID_TRIPULANTE");

            builder.Property(t => t.PessoaId).IsRequired().HasColumnName("ID_PESSOA");
            builder.Property(t => t.TipoTripulanteId).IsRequired().HasColumnName("ID_TIPO_TRIPULANTE");
            builder.Property(t => t.CruzeiroId).IsRequired().HasColumnName("ID_CRUZEIRO");
            builder.Property(t => t.CabineTripulanteId).IsRequired(false).HasColumnName("ID_CABINE_TRIPULANTE");

            // Relações

            builder.HasOne(t => t.TipoTripulante)
                .WithMany()
                .HasForeignKey(t => t.TipoTripulanteId);

            builder.HasOne(t => t.Pessoa)
                .WithMany()
                .HasForeignKey(t => t.PessoaId);

            builder.HasOne(t => t.Cruzeiro)
                .WithMany(c => c.Tripulantes)
                .HasForeignKey(t => t.CruzeiroId);

            builder.HasOne(t => t.CabineTripulante)
                .WithMany()
                .HasForeignKey(t => t.CabineTripulanteId);
        }
    }
}
