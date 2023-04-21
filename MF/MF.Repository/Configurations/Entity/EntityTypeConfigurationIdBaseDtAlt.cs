using MF.Domain.Commons.ClassesBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Configurations.Entity
{
    public abstract class EntityTypeConfigurationIdBaseDtAlt<T> : EntityTypeConfigurationIdBase<T> where T : IdBaseDtAlt
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.Property(mi => mi.DataAlteracao)
                   .HasColumnType("TIMESTAMP")
                   .IsRequired();
        }
    }
}