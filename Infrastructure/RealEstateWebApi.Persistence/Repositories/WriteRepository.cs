using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class WriteRepository<TEntity, TContext> : IWriteRepository<TEntity> where TEntity : class, IEntity where TContext : DbContext
    {
        private readonly TContext _context;
        public WriteRepository(TContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<bool> AddAsync(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(IEnumerable<TEntity> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(uint id)
        {
            TEntity model = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Remove(model);
        }

        public bool RemoveRange(IEnumerable<TEntity> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public bool Update(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
