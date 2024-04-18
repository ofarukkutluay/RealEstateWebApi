using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.Common;
using RealEstateWebApi.Domain.Entities.Identity;
using System.Reflection;


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
        public DbSet<Residential> Residentials { get; set; }
        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Tourism> Tourisms { get; set; }
        public DbSet<PropertyPhoto> PropertyPhotos { get; set; }
        public DbSet<PropertyCategory> PropertyCategories { get; set; }
        public DbSet<PropertyStatus> PropertyStatuses { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<UsingStatus> UsingStatuses { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerOwnedProperty> CustomerOwnedProperties { get; set; }
        public DbSet<CustomerSearchProperty> CustomerSearchProperties { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<EntryType> EntryTypes { get; set; }
        public DbSet<EntrySubType> EntrySubTypes { get; set; }
        //public DbSet<PropertyListingDetail> PropertyListingDetails { get; set; }
        public DbSet<PropertyListingPhoto> PropertyListingPhotos { get; set; }
        public DbSet<OuterPropertyListing> OuterPropertyListings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Commercial>(x=>{
            //     x.HasKey("PropertyId");
            //     x.HasOne<Property>().WithOne().HasForeignKey<Commercial>(x=>x.PropertyId);
            // });

            // modelBuilder.Entity<Land>(x=>{
            //     x.HasKey("PropertyId");
            //     x.HasOne<Property>().WithOne().HasForeignKey<Land>(x=>x.PropertyId);
            // });

            // modelBuilder.Entity<Residential>(x=>{
            //     x.HasKey("PropertyId");
            //     x.HasOne<Property>().WithOne().HasForeignKey<Residential>(x=>x.PropertyId);
            // });

            // modelBuilder.Entity<Tourism>(x=>{
            //     x.HasKey("PropertyId");
            //     x.HasOne<Property>().WithOne().HasForeignKey<Tourism>(x=>x.PropertyId);
            // });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
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
