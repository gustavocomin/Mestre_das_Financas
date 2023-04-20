using MF.Domain.Commons.ClassesBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Configurations.Entity
{
    public interface IEntityTypeConfigurationIdBaseDtAlt<T> : IEntityTypeConfigurationIdBase<T> where T : IdBaseDtAlt
    {
        void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnName("DATA_ALTERACAO")
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();
        }
    }
}