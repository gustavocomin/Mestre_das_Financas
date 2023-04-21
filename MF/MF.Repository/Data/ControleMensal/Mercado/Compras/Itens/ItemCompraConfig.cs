using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras.Itens
{
    public class ItemCompraConfig : EntityTypeConfigurationIdBaseDtAlt<ItemCompra>
    {
        public void Configure(EntityTypeBuilder<ItemCompra> builder)
        {
            builder.ToTable("ITEMCOMPRA");

            builder.Property(x => x.CodigoCompra)
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(x => x.SequencialItem)
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(x => x.Descricao)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(x => x.Quantidade)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(x => x.ValorUnitario)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(x => x.ValorTotalItem)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(x => x.CodigoCompra)
                   .HasColumnType("INT")
                   .IsRequired();

            builder.Property(x => x.CodigoDesconto)
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