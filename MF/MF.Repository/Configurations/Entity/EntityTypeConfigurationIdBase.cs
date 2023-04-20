using MF.Domain.Commons.ClassesBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MF.Repository.Configurations.Entity
{
    public class EntityTypeConfigurationIdBase<T> : IEntityTypeConfiguration<T> where T : IdBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            string idColumnName = $"ID_{builder.Metadata.GetTableName()}".ToUpper();

            builder.HasKey(mi => mi.Id);

            builder.Property(t => t.Id)
                   .HasColumnName(idColumnName);
        }
    }
}