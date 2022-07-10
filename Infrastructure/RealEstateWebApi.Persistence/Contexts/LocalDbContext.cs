using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.LocalDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.Contexts
{
    public class LocalDbContext : DbContext, ILocalDbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options) { }

        public DbSet<TemporaryPass> TemporaryPass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TemporaryPass>().HasKey(e=> e.Content);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges() => base.SaveChanges();
    }

}
