using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens.MarcaItens
{
    public class MarcaItemConfig : IEntityTypeConfigurationIdBaseDtAlt<MarcaItem>
    {
        public void Configure(EntityTypeBuilder<MarcaItem> builder)
        {
            builder.ToTable("MARCAITEM");

            builder.Property(x => x.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.CodigoItem)
                   .HasColumnName("CODIGO_ITEM")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(c => c.Item)
                   .WithMany()
                   .HasForeignKey(c => c.CodigoItem)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}