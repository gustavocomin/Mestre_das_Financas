using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;
using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens.Models;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens.MarcaItens
{
    public class MarcaItemConfig : EntityTypeConfigurationIdBaseDtAlt<MarcaItemView>
    {
        public void Configure(EntityTypeBuilder<MarcaItemView> builder)
        {
            builder.ToTable("MARCAITEM");

            builder.Property(x => x.Descricao)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.CodigoItem)
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(c => c.Item)
                   .WithMany()
                   .HasForeignKey(c => c.CodigoItem)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}