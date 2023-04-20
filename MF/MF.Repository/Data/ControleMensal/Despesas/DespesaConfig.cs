using MF.Domain.ControleMensal.Despesas;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Despesas
{
    public class DespesaConfig : IEntityTypeConfigurationIdBaseDtAlt<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.ToTable("DESPESA");

            builder.Property(d => d.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(d => d.Valor)
                   .HasColumnName("VALOR")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(d => d.TipoDespesa)
                   .HasColumnName("TIPO_DESPESA")
                   .IsRequired();

            builder.Property(d => d.DataDespesa)
                   .HasColumnName("DATA_DESPESA")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(d => d.Mensal)
                   .HasColumnName("MENSAL")
                   .IsRequired();

            builder.Property(d => d.DataInicial)
                   .HasColumnName("DATA_INICIAL")
                   .HasColumnType("date");

            builder.Property(d => d.DataFinal)
                   .HasColumnName("DATA_FINAL")
                   .HasColumnType("date");

            builder.Property(t => t.CodigoEmpresa)
                   .HasColumnType("int")
                   .HasColumnName("CODIGO_EMPRESA");

            builder.Property(t => t.CodigoConsumidor)
                   .HasColumnName("CODIGO_CONSUMIDOR")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(t => t.CodigoFormaPagto)
                   .HasColumnName("CODIGO_FORMA_PAGTO")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(t => t.CodigoCondPagto)
                   .HasColumnName("CODIGO_COND_PAGTO")
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