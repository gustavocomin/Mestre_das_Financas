using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Domain.Commons.Usuarios
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            string idColumnName = $"Id{builder.Metadata.ClrType.Name}";

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();

            builder.Property(u => u.Nome)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(u => u.Login)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(u => u.Senha)
                   .HasMaxLength(15)
                   .IsRequired();
        }
    }
}