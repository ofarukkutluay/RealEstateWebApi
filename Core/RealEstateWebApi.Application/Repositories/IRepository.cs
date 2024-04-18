using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface IRepository<TEntity,TId> where TEntity : class ,IEntity<TId> 
    {
        DbSet<TEntity> Table { get; }
    }

    public interface IRepository<TEntity> : IRepository<TEntity,uint> where TEntity : class ,IEntity
    {
    }
}
