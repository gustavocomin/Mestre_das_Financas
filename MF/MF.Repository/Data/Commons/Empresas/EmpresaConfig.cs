using MF.Domain.Commons.Empresas;
using MF.Repository.Configurations.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.Empresas
{
    public class EmpresaConfig : EntityTypeConfigurationIdBase<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("EMPRESA");

            builder.Property(e => e.NomeEmpresa)
                   .HasColumnName("NOME_EMPRESA")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(e => e.CnpjEmpresa)
                   .HasColumnName("CNPJ_EMPRESA")
                   .HasMaxLength(14);

            builder.Property(e => e.Endereço)
                .HasColumnName("ENDEREÇO")
                .HasMaxLength(200);

            builder.Property(e => e.Bairro)
                .HasColumnName("BAIRRO")
                .HasMaxLength(100);

            builder.Property(e => e.Cidade)
                .HasColumnName("CIDADE")
                .HasMaxLength(100);

            builder.Property(e => e.Complemento)
                .HasColumnName("COMPLEMENTO")
                .HasMaxLength(100);
        }
    }
}