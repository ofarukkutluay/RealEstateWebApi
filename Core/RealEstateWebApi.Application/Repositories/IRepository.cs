using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface IRepository<TEntity> where TEntity : class ,IEntity
    {
        DbSet<TEntity> Table { get; }
    }
}
