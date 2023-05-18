using MF.Domain.ControleMensal.Mercado.Compras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Compras
{
    public class CompraConfig : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("COMPRA");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(c => c.Descricao)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.DataCompra)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(c => c.ValorTotalNF)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.NumeroNF)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(c => c.NumeroNF)
                   .HasColumnType("VARCHAR")
                   .IsRequired();

            builder.Property(c => c.ValorTotal)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.ValorTotalItens)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.ValorTotalDescontos)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.ValorTributos)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired();

            builder.Property(c => c.COO)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50);

            builder.Property(c => c.CCF)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50);

            builder.Property(c => c.CodigoFormaPagto)
                   .HasColumnType("int");

            builder.Property(c => c.CodigoCondPagto)
                   .HasColumnType("int");

            builder.Property(c => c.CodigoEmpresa)
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