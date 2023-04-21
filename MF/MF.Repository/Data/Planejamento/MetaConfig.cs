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
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(m => m.DataIniVigencia)
                   .HasColumnType("date")
                   .HasColumnType("date");

            builder.Property(m => m.DataFimVigencia)
                   .HasColumnType("date")
                   .HasColumnType("date");

            builder.Property(m => m.ValorTotalCompra)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(m => m.ValorTotalGuardado)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(m => m.Status)
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