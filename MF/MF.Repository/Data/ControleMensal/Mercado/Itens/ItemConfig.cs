using MF.Domain.ControleMensal.Mercado.Itens;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens
{
    public class ItemConfig : IEntityTypeConfigurationIdBase<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("ITEM");

            builder.Property(e => e.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.HasMany(p => p.MarcaItens)
                   .WithOne(m => m.Item)
                   .HasForeignKey(m => m.CodigoItem)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}