using MF.Domain.Commons.Consumirdores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.Consumirdores
{
    public class ConsumidorConfig : IEntityTypeConfiguration<Consumidor>
    {
        public void Configure(EntityTypeBuilder<Consumidor> builder)
        {
            builder.ToTable("Consumidor");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(u => u.Celular)
                   .HasMaxLength(12);

            builder.Property(u => u.DataNascimento)
                   .HasColumnType("date");

            builder.Property(u => u.RendaTotal)
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