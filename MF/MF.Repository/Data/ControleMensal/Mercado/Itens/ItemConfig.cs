using MF.Domain.ControleMensal.Mercado.Itens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("ITEM");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(e => e.Descricao)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.HasMany(p => p.MarcaItens)
                   .WithOne(m => m.Item)
                   .HasForeignKey(m => m.CodigoItem)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}