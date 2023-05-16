using MF.Domain.Commons.Empresas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.Empresas
{
    public class EmpresaConfig : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("EMPRESA");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(e => e.NomeEmpresa)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(e => e.CnpjEmpresa)
                   .HasMaxLength(15);

            builder.Property(e => e.Endereço)
                   .HasMaxLength(200);

            builder.Property(e => e.Bairro)
                   .HasMaxLength(100);

            builder.Property(e => e.Cidade)
                   .HasMaxLength(100);

            builder.Property(e => e.Complemento)
                   .HasMaxLength(100);
        }
    }
}