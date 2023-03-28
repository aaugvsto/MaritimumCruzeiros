using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class TipoCabineMap : IEntityTypeConfiguration<TipoCabine>
    {
        public void Configure(EntityTypeBuilder<TipoCabine> builder)
        {
            // Propiedades
            builder.ToTable("TIPO_CABINE").HasKey(tc => tc.Id);
            builder.Property(tc => tc.Id).HasColumnName("ID_TIPO_CABINE");

            builder.Property(tc => tc.Tipo).IsRequired().HasColumnName("TIPO");
            builder.Property(tc => tc.Descricao).IsRequired().HasColumnName("DESCRICAO");
        
            // Relações
        }
    }
}
