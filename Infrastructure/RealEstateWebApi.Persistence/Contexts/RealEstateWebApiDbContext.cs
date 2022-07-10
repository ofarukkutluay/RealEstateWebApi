using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.Common;
using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.Contexts
{
    public class RealEstateWebApiDbContext : DbContext
    {
        public RealEstateWebApiDbContext(DbContextOptions<RealEstateWebApiDbContext> options) : base(options) { }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<DeedStatus> DeedStatuses { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<Front> Fronts { get; set; }
        public DbSet<HeatingType> HeatingTypes { get; set; }
        public DbSet<InternetType> InternetTypes { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyPhoto> PropertyPhotos { get; set; }
        public DbSet<PropertyStatus> PropertyStatuses { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<UsingStatus> UsingStatuses { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach(var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }


            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
