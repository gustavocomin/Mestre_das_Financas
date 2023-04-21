using MF.Domain.Commons.ModalidadePagto.FormaPagtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.ModalidadePagto.FormaPagtos
{
    public class FormaPagtoConfig : IEntityTypeConfiguration<FormaPagto>
    {
        public void Configure(EntityTypeBuilder<FormaPagto> builder)
        {
            builder.ToTable("FORMAPAGTO");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(fp => fp.Descricao)
                   .HasColumnType("varchar")
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}