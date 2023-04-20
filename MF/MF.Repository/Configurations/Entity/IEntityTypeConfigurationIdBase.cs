using MF.Domain.Commons.ClassesBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Configurations.Entity
{
    public interface IEntityTypeConfigurationIdBase<T> : IEntityTypeConfiguration<T> where T : IdBase
    {
        void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName($"ID_{builder.Metadata.Name}");
        }
    }
}