using MF.Domain.Commons.ModalidadePagto.CondPagtos.Parcs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.ModalidadePagto.CondPagtos.Parcs
{
    public class CondPagtoParcsConfig : IEntityTypeConfiguration<CondPagtoParcs>
    {
        public void Configure(EntityTypeBuilder<CondPagtoParcs> builder)
        {
            builder.ToTable("CONDPAGTOPARC");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(cp => cp.CodigoOrigem)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(cp => cp.Origem)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(cp => cp.CodigoCondPagto)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(cp => cp.ValorParc)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(cp => cp.SeqParc)
                   .HasColumnType("int")
                   .IsRequired();
        }
    }
}