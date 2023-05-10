using MaritimumCruzeiros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaritimumCruzeiros.Data.Map
{
    public class TransacaoMap : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.ToTable("TRANSACOES");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID_TRANSACAO");
            builder.Property(x => x.EmailCliente).HasColumnName("EMAIL_CLIENTE");
            builder.Property(x => x.NumerosFinaisCartao).HasColumnName("NUMEROS_FINAIS_CARTAO");
            builder.Property(x => x.ValorTotal).HasColumnName("VALOR_TOTAL");
            builder.Property(x => x.NumeroParcelas).HasColumnName("NUMERO_PARCELAS");
            builder.Property(x => x.TipoCartao).HasColumnName("TIPO_CARTAO");
            builder.Property(x => x.Resultado).HasColumnName("RESULTADO_TRANSACAO");
        }
    }
}
