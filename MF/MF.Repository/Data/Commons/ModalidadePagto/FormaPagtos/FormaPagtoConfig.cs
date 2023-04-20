using MF.Domain.Commons.ModalidadePagto.FormaPagtos;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.ModalidadePagto.FormaPagtos
{
    public class FormaPagtoConfig : IEntityTypeConfigurationIdBase<FormaPagto>
    {
        public void Configure(EntityTypeBuilder<FormaPagto> builder)
        {
            builder.ToTable("FORMAPAGTO");

            builder.Property(fp => fp.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasColumnType("varchar")
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}