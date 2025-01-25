using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities.LocalDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface ILocalDbContext
    {
        DbSet<TemporaryPass> TemporaryPass { get; set; }

        int SaveChanges();
    }
}
