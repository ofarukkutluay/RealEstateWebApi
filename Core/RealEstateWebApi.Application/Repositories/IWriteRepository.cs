using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        Task<TEntity> AddAndSaveAsync(TEntity model);
        Task<bool> AddAsync(TEntity model);
        Task<bool> AddRangeAsync(IEnumerable<TEntity> datas);
        bool Remove(TEntity model);
        bool RemoveRange(IEnumerable<TEntity> datas);
        Task<bool> RemoveAsync(uint id);
        bool Update(TEntity model);
        Task<int> SaveAsync();

    }
}
