using MF.Domain.Commons.Consumirdores;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.Consumirdores
{
    public class ConsumidorConfig : EntityTypeConfigurationIdBaseDtAlt<Consumidor>
    {
        public void Configure(EntityTypeBuilder<Consumidor> builder)
        {
            builder.ToTable("CONSUMIDOR");

            builder.Property(u => u.Nome)
                   .HasColumnName("NOME")
                   .HasMaxLength(300)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasColumnName("EMAIL")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(u => u.Celular)
                   .HasColumnName("CELULAR")
                   .HasMaxLength(12);

            builder.Property(u => u.DataNascimento)
                   .HasColumnName("DATA_NASCIMENTO")
                   .HasColumnType("date");

            builder.Property(u => u.RendaTotal)
                   .HasColumnName("RENDA_TOTAL")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.HasMany(u => u.Rendas)
                   .WithOne(r => r.Consumidor)
                   .HasForeignKey(r => r.CodigoConsumidor)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Despesas)
                   .WithOne(d => d.Consumidor)
                   .HasForeignKey(d => d.CodigoConsumidor)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}