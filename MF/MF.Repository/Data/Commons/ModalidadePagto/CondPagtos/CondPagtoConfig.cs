using MF.Domain.Commons.ModalidadePagto.CondPagtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.ModalidadePagto.CondPagtos
{
    public class CondPagtoConfig : IEntityTypeConfiguration<CondPagto>
    {
        public void Configure(EntityTypeBuilder<CondPagto> builder)
        {
            builder.ToTable("CONDPAGTO");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(cp => cp.Descricao)
                   .HasColumnType("varchar")
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(cp => cp.Credito)
                   .IsRequired();

            builder.Property(cp => cp.QuantParc)
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasMany(cp => cp.Parcs)
                   .WithOne()
                   .HasForeignKey(cp => cp.CodigoCondPagto);
        }
    }
}