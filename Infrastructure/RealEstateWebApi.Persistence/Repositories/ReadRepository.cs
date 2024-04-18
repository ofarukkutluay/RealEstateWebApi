using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Common;
using System.Linq.Expressions;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class ReadRepository<TEntity,TContext,TId> : IReadRepository<TEntity,TId> where TEntity : class,IEntity<TId> where TContext : DbContext 
    {
        protected readonly TContext _context;
        public ReadRepository(TContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true,CancellationToken cancellationToken = default)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(method,cancellationToken);
        }
        public async Task<TEntity> GetByIdAsync(TId id, bool tracking = true,CancellationToken cancellationToken = default)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id.Equals(id), cancellationToken);
        }
    }

    public class ReadRepository<TEntity, TContext> : ReadRepository<TEntity, TContext, uint>, IReadRepository<TEntity> where TEntity : class, IEntity where TContext : DbContext
    {
        public ReadRepository(TContext context) : base(context)
        {
        }
    }

}
