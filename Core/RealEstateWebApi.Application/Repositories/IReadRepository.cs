using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface IReadRepository<TEntity,TId> : IRepository<TEntity,TId> where TEntity : class,IEntity<TId> 
    {
        IQueryable<TEntity> GetAll(bool tracking = true);
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true,CancellationToken cancellationToken = default);
        Task<TEntity> GetByIdAsync(TId id, bool tracking = true,CancellationToken cancellationToken = default);
    }

    public interface IReadRepository<TEntity> :IReadRepository<TEntity,uint>, IRepository<TEntity> where TEntity : class,IEntity
    {

    }

}
