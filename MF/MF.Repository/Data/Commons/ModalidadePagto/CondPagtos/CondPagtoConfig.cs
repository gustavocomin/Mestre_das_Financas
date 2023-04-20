using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.ModalidadePagto.CondPagtos
{
    public class CondPagtoConfig : EntityTypeConfigurationIdBase<CondPagto>
    {
        public void Configure(EntityTypeBuilder<CondPagto> builder)
        {
            builder.ToTable("CONDPAGTO");

            builder.Property(cp => cp.Descricao)
                   .HasColumnName("DESCRICAO")
                   .HasColumnType("varchar")
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(cp => cp.Credito)
                   .HasColumnName("CREDITO")
                   .IsRequired();

            builder.Property(cp => cp.QuantParc)
                   .HasColumnName("QUANT_PARC")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasMany(cp => cp.Parcs)
                .WithOne()
                .HasForeignKey(cp => cp.CodigoCondPagto);
        }
    }
}