using MF.Domain.Planejamento;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Planejamento
{
    public class MetaConfig : EntityTypeConfigurationIdBaseDtAlt<Meta>
    {
        public void Configure(EntityTypeBuilder<Meta> builder)
        {
            builder.ToTable("META");

            builder.Property(m => m.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(m => m.DataIniVigencia)
                   .HasColumnName("DATA_INI_VIGENCIA")
                   .HasColumnType("date")
                   .HasColumnType("date");

            builder.Property(m => m.DataFimVigencia)
                   .HasColumnName("DATA_FIM_VIGENCIA")
                   .HasColumnType("date")
                   .HasColumnType("date");

            builder.Property(m => m.ValorTotalCompra)
                   .HasColumnName("VALOR_TOTAL_COMPRA")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(m => m.ValorTotalGuardado)
                   .HasColumnName("VALOR_TOTAL_GUARDADO")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(m => m.Status)
                   .HasColumnName("STATUS")
                   .IsRequired();

            builder.HasOne(m => m.Consumidor)
                   .WithMany()
                   .HasForeignKey(m => m.CodigoConsumidor)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(m => m.Itens)
                   .WithOne(i => i.Meta)
                   .HasForeignKey(i => i.CodigoMeta)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}