using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RealEstateWebApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<RealEstateWebApiDbContext>
    {
        public RealEstateWebApiDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<RealEstateWebApiDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<RealEstateWebApiDbContext>();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new RealEstateWebApiDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
