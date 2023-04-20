using MF.Domain.ControleMensal.Rendas;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Rendas
{
    public class RendaConfig : EntityTypeConfigurationIdBaseDtAlt<Renda>
    {
        public void Configure(EntityTypeBuilder<Renda> builder)
        {
            builder.ToTable("RENDA");

            builder.Property(e => e.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(e => e.Valor)
                   .HasColumnName("VALOR")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(e => e.Salario)
                   .HasColumnName("SALARIO")
                   .IsRequired();

            builder.Property(e => e.CodigoEmpresa)
                   .HasColumnName("CODIGO_EMPRESA")
                   .HasColumnType("int");

            builder.Property(e => e.CodigoConsumidor)
                   .HasColumnName("CODIGO_CONSUMIDOR")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(d => d.Empresa)
                   .WithMany()
                   .HasForeignKey(d => d.CodigoEmpresa)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Consumidor)
                   .WithMany()
                   .HasForeignKey(d => d.CodigoConsumidor)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}