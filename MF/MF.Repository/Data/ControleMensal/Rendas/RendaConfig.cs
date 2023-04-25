using MF.Domain.ControleMensal.Rendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RendaConfig : IEntityTypeConfiguration<Renda>
{
    public void Configure(EntityTypeBuilder<Renda> builder)
    {
        builder.ToTable("RENDA");

        string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

        builder.HasKey(mi => mi.Id);

        builder.Property(t => t.Id)
               .HasColumnName(idColumnName);

        builder.Property(mi => mi.DataAlteracao)
               .HasColumnType("TIMESTAMP")
               .IsRequired();

        builder.Property(e => e.Descricao)
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(e => e.Valor)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(e => e.Salario)
               .IsRequired();

        builder.Property(d => d.CodigoConsumidor)
               .HasColumnName("CodigoConsumidor");

        builder.HasOne(d => d.Empresa)
               .WithMany()
               .HasForeignKey(d => d.CodigoEmpresa)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Consumidor)
               .WithMany(x => x.Rendas)
               .HasForeignKey(d => d.CodigoConsumidor)
               .HasConstraintName("FK_DESPESA_CONSUMIDOR")
               .OnDelete(DeleteBehavior.Restrict);
    }
}
