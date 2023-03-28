using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class TipoTripulanteMap : IEntityTypeConfiguration<TipoTripulante>
    {
        public void Configure(EntityTypeBuilder<TipoTripulante> builder)
        {
            // Propiedades

            builder.ToTable("TIPO_TRIPULATE").HasKey(tt => tt.Id);
            builder.Property(tt => tt.Id).HasColumnName("ID_TIPO_TRIPULANTE");

            builder.Property(tt => tt.Tipo).HasColumnName("TIPO");

            // Relações

        }
    }
}
