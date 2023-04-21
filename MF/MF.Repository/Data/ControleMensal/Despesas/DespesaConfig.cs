using MF.Domain.ControleMensal.Despesas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Despesas
{
    public class DespesaConfig : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.ToTable("DESPESA");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();

            builder.Property(d => d.Descricao)
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(d => d.Valor)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(d => d.TipoDespesa)
                   .IsRequired();

            builder.Property(d => d.DataDespesa)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(d => d.Mensal)
                   .IsRequired();

            builder.Property(d => d.DataInicial)
                   .HasColumnType("date");

            builder.Property(d => d.DataFinal)
                   .HasColumnType("date");

            builder.Property(t => t.CodigoEmpresa)
                   .HasColumnType("int");

            builder.Property(t => t.CodigoConsumidor)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(t => t.CodigoFormaPagto)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(t => t.CodigoCondPagto)
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(d => d.FormaPagto)
                   .WithMany()
                   .HasForeignKey(d => d.CodigoFormaPagto)
                   .IsRequired();

            builder.HasOne(d => d.CondPagto)
                   .WithMany()
                   .HasForeignKey(d => d.CodigoCondPagto)
                   .IsRequired();

            builder.HasOne(d => d.Consumidor)
                   .WithMany()
                   .HasForeignKey(d => d.CodigoConsumidor)
                   .IsRequired();

            builder.HasOne(d => d.Empresa)
                   .WithMany()
                   .HasForeignKey(d => d.CodigoEmpresa)
                   .IsRequired();
        }
    }
}