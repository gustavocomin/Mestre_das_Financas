using MF.Domain.Commons.Usuarios.Email;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Data.Commons.Usuarios.Email
{
    public class EmailProviderConfig : IEntityTypeConfiguration<EmailProvider>
    {
        public void Configure(EntityTypeBuilder<EmailProvider> builder)
        {
            builder.ToTable("EmailProvider");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(u => u.Senha)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(u => u.UsuarioAlteracao)
                   .HasMaxLength(100)
                   .IsRequired();
        }
    }
}