using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras.Itens
{
    public class ItemCompraConfig : IEntityTypeConfigurationIdBaseDtAlt<ItemCompra>
    {
        public void Configure(EntityTypeBuilder<ItemCompra> builder)
        {
            builder.ToTable("ITEMCOMPRA");

            builder.Property(x => x.CodigoCompra)
                   .HasColumnName("ID_COMPRA")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(x => x.SequencialItem)
                   .HasColumnName("SEQ_ITEM")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(x => x.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(x => x.Quantidade)
                   .HasColumnName("QUANT")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(x => x.ValorUnitario)
                   .HasColumnName("VALOR_UNIT")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(x => x.ValorTotalItem)
                   .HasColumnName("VALOR_TOTAL_ITEM")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(x => x.CodigoCompra)
                   .HasColumnName("CODIGO_COMPRA")
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(x => x.CodigoDesconto)
                   .HasColumnName("CODIGO_DESCONTO")
                   .HasColumnType("INT");

            builder.HasOne(ic => ic.Compra)
                   .WithMany(c => c.Itens)
                   .HasForeignKey(ic => ic.CodigoCompra)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DescontoItem)
               .WithOne(x => x.ItemCompra)
               .HasForeignKey<ItemCompra>(x => x.CodigoDesconto)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}