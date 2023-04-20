using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public class CondPagtoParcsConfig : EntityTypeConfigurationIdBase<CondPagtoParcs>
    {
        public void Configure(EntityTypeBuilder<CondPagtoParcs> builder)
        {
            builder.ToTable("CONDPAGTOPARC");

            builder.Property(cp => cp.CodigoCondPagto)
                   .HasColumnName("ID_COND_PAGTO")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(cp => cp.ValorParc)
                   .HasColumnName("VALOR_PARC")
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(cp => cp.SeqParc)
                   .HasColumnName("SEQ_PARC")
                   .HasColumnType("int")
                   .IsRequired();
        }
    }
}