using MF.Domain.Planejamento.Itens;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Planejamento.Itens
{
    public class MetaItemConfig : IEntityTypeConfigurationIdBaseDtAlt<MetaItem>
    {
        public void Configure(EntityTypeBuilder<MetaItem> builder)
        {
            builder.ToTable("METAITEM");

            builder.Property(mi => mi.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasColumnType("varchar")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(mi => mi.ValorCompra)
                   .HasColumnName("VALOR_COMPRA")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.LinkCompra)
                   .HasColumnName("LINK_COMPRA")
                   .HasColumnType("varchar")
                   .HasMaxLength(900);

            builder.Property(mi => mi.ValorReservaCompra)
                   .HasColumnName("VALOR_RESERVA_COMPRA")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.DiferencaCompraReserva)
                   .HasColumnName("DIFERENCA_COMPRA_RESERVA")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.DataExpectativaAquisicao)
                   .HasColumnName("DATA_EXPECTATIVA_AQUISICAO")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(mi => mi.ValorGuardarMes)
                   .HasColumnName("VALOR_GUARDAR_MES")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(mi => mi.Status)
                   .HasColumnName("STATUS")
                   .IsRequired();

            builder.Property(mi => mi.CodigoMeta)
                   .HasColumnName("CODIGO_META")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.HasOne(mi => mi.Meta)
                .WithMany(m => m.Itens)
                .HasForeignKey(mi => mi.CodigoMeta)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}




