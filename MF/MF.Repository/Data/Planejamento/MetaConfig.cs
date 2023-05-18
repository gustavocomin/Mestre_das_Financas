using MF.Domain.Planejamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Planejamento
{
    public class MetaConfig : IEntityTypeConfiguration<Meta>
    {
        public void Configure(EntityTypeBuilder<Meta> builder)
        {
            builder.ToTable("META");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();

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