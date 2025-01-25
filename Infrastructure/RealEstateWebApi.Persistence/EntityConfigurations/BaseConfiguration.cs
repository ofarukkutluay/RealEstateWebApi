using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities.Common;


namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class BaseConfiguration<TEntity,TId> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
    public class BaseConfiguration<TEntity> : BaseConfiguration<TEntity,uint>, IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
    }
}
