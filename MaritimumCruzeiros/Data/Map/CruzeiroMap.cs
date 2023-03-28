using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class CruzeiroMap : IEntityTypeConfiguration<Cruzeiro>
    {
        public void Configure(EntityTypeBuilder<Cruzeiro> builder)
        {
            // Propiedades

            builder.ToTable("CRUZEIROS").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("ID_CRUZEIRO");

            builder.Property(c => c.NomeExpedicao).IsRequired().HasMaxLength(100).HasColumnName("NOME_EXPEDICAO");
            builder.Property(c => c.DataPartida).IsRequired().HasColumnName("DATA_PARTIDA");
            builder.Property(c => c.DataChegada).IsRequired().HasColumnName("DATA_CHEGADA");
            builder.Property(c => c.Descricao).HasColumnName("DESCRICAO");
            builder.Property(c => c.NavioId).IsRequired().HasColumnName("ID_NAVIO");

            // Relações

            builder.HasMany(c => c.Tripulantes)
                .WithOne(t => t.Cruzeiro)
                .HasForeignKey(c => c.CruzeiroId);

            builder.HasOne(c => c.Navio)
                .WithMany()
                .HasForeignKey(c => c.NavioId);
        }
    }
}
