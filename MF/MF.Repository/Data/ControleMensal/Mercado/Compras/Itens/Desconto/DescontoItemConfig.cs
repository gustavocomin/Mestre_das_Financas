using MF.Domain.ControleMensal.Mercado.Compras.Itens;
using MF.Domain.ControleMensal.Mercado.Compras.Itens.Desconto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras.Itens.Desconto
{
    public class DescontoItemConfig : IEntityTypeConfiguration<DescontoItem>
    {
        public void Configure(EntityTypeBuilder<DescontoItem> builder)
        {
            builder.ToTable("DESCONTOITEM");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(d => d.CodigoItemCompra)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(d => d.ValorDesconto)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.HasOne(x => x.ItemCompra)
               .WithOne(x => x.DescontoItem)
               .HasForeignKey<ItemCompra>(x => x.CodigoDesconto)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}