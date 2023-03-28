using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class CabineTripulanteMap : IEntityTypeConfiguration<CabineTripulante>
    {
        public void Configure(EntityTypeBuilder<CabineTripulante> builder)
        {
            builder.ToTable("CABINE_TRIPULANTE").HasKey(ct => ct.CabineTripulanteId);
            builder.Property(ct => ct.CabineTripulanteId).HasColumnName("ID_CABINE_TRIPULANTE");


            builder.Property(ct => ct.CabineId).IsRequired().HasColumnName("ID_CABINE");
            builder.Property(ct => ct.TripulanteId).IsRequired().HasColumnName("ID_TRIPULANTE");
            builder.Property(ct => ct.CruzeiroId).IsRequired().HasColumnName("ID_CRUZEIRO");

            builder.HasOne(ct => ct.Cabine)
                .WithMany()
                .HasForeignKey(ct => ct.CabineId);

            builder.HasOne(ct => ct.Tripulante)
                .WithMany()
                .HasForeignKey(ct => ct.TripulanteId);

            builder.HasOne(ct => ct.Cruzeiro)
                .WithMany().
                HasForeignKey(ct => ct.CruzeiroId);
        }
    }
}
