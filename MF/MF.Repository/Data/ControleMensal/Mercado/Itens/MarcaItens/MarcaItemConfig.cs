using MF.Domain.ControleMensal.Mercado.Itens.MarcaItens;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.ControleMensal.Mercado.Itens.MarcaItens
{
    public class MarcaItemConfig : IEntityTypeConfiguration<MarcaItem>
    {
        public void Configure(EntityTypeBuilder<MarcaItem> builder)
        {
            builder.ToTable("MARCAITEM");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();

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