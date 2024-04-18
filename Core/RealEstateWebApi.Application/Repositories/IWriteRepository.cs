using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface IWriteRepository<TEntity,TId> : IRepository<TEntity,TId> where TEntity : class, IEntity<TId> 
    {
        Task<TEntity> AddAndSaveAsync(TEntity model,CancellationToken cancellationToken = default);
        Task<bool> AddAsync(TEntity model,CancellationToken cancellationToken = default);
        Task<bool> AddRangeAsync(IEnumerable<TEntity> datas,CancellationToken cancellationToken = default);
        bool Remove(TEntity model);
        bool RemoveRange(IEnumerable<TEntity> datas);
        Task<bool> RemoveAsync(TId id,CancellationToken cancellationToken = default);
        bool Update(TEntity model);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);

    }

    public interface IWriteRepository<TEntity> : IWriteRepository<TEntity,uint>, IRepository<TEntity> where TEntity : class, IEntity
    {


    }
}
