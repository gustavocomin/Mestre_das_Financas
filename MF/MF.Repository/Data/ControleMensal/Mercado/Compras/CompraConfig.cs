using MF.Domain.ControleMensal.Mercado.Compras;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras
{
    public class CompraConfig : EntityTypeConfigurationIdBase<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("COMPRA");

            builder.Property(c => c.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.DataCompra)
                   .HasColumnName("DATA_COMPRA")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(c => c.ValorTotal)
                   .HasColumnName("VALOR_TOTAL")
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.ValorTotalItens)
                   .HasColumnName("VALOR_TOTAL_ITENS")
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.ValorTotalDescontos)
                   .HasColumnName("VALOR_TOTAL_DESCONTOS")
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.ValorTributos)
                   .HasColumnName("VALOR_TRIBUTOS")
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.COO)
                   .HasColumnName("COO")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50);

            builder.Property(c => c.CCF)
                   .HasColumnName("CCF")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50);

            builder.Property(c => c.CodigoFormaPagto)
                   .HasColumnName("CODIGO_FORMA_PAGTO")
                   .HasColumnType("int");

            builder.Property(c => c.CodigoCondPagto)
                   .HasColumnName("CODIGO_COND_PAGTO")
                   .HasColumnType("int");

            builder.Property(c => c.CodigoEmpresa)
                   .HasColumnName("CODIGO_EMPRESA")
                   .HasColumnType("int");

            builder.HasOne(c => c.Empresa)
                   .WithMany()
                   .HasForeignKey(c => c.CodigoEmpresa);

            builder.HasOne(c => c.FormaPagto)
                   .WithMany()
                   .HasForeignKey(c => c.CodigoFormaPagto);

            builder.HasOne(c => c.CondPagto)
                   .WithMany()
                   .HasForeignKey(c => c.CodigoCondPagto);

            builder.HasMany(c => c.Itens)
                   .WithOne(ic => ic.Compra)
                   .HasForeignKey(ic => ic.CodigoCompra)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}