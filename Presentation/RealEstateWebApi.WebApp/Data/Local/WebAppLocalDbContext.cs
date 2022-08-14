using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.WebApp.Models;

namespace RealEstateWebApi.WebApp.Data.Local
{
    public class WebAppLocalDbContext : DbContext
{
    public WebAppLocalDbContext(DbContextOptions<WebAppLocalDbContext> options) : base(options) { }

    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Neighborhood> Neighborhoods { get; set; }    
}
}

