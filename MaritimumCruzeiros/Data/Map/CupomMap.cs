using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class CupomMap : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("CUPONS");
            builder.HasKey(x => x.IdCupom);

            builder.Property(x => x.IdCupom).HasColumnName("ID_CUPOM");
            builder.Property(x => x.Codigo).HasColumnName("CODIGO").IsRequired();
            builder.Property(x => x.PorcentagemDesconto).HasColumnName("PORCENTAGEM_DESCONTO").IsRequired();

            builder.HasIndex(x => x.Codigo).IsUnique();
        }
    }
}
