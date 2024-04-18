using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Common;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class WriteRepository<TEntity, TContext,TId> : IWriteRepository<TEntity,TId> where TEntity : class, IEntity<TId> where TContext : DbContext 
    {
        private readonly TContext _context;
        public WriteRepository(TContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<bool> AddAsync(TEntity model,CancellationToken cancellationToken = default)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(model,cancellationToken);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(IEnumerable<TEntity> datas,CancellationToken cancellationToken = default)
        {
            await Table.AddRangeAsync(datas,cancellationToken);
            return true;
        }

        public async Task<TEntity> AddAndSaveAsync(TEntity model,CancellationToken cancellationToken = default)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(model,cancellationToken);
            if (entityEntry.State == EntityState.Added)
            {
                try
                {
                    await SaveAsync(cancellationToken);
                    return entityEntry.Entity;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        public bool Remove(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(TId id,CancellationToken cancellationToken = default)
        {
            TEntity model = await Table.FirstOrDefaultAsync(x => x.Id.Equals(id),cancellationToken);
            return Remove(model);
        }

        public bool RemoveRange(IEnumerable<TEntity> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public bool Update(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }

    public class WriteRepository<TEntity, TContext> : WriteRepository<TEntity, TContext, uint>, IWriteRepository<TEntity> where TEntity : class, IEntity where TContext : DbContext
    {
        public WriteRepository(TContext context) : base(context)
        {
        }
    }

}
