using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class PropertyEntityConfiguration : BaseConfiguration<Property>
    {
        public override void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasOne<City>().WithMany().HasForeignKey(e=>e.CityId);
            builder.HasOne<District>().WithMany().HasForeignKey(e => e.DistrictId);
            builder.HasOne<Neighborhood>().WithMany().HasForeignKey(e => e.NeighborhoodId);
            builder.HasOne<Street>().WithMany().HasForeignKey(e => e.StreetId);   
            builder.HasOne<PropertyCategory>().WithMany().HasForeignKey(x=>x.PropertyCategoryId);
            builder.HasOne<PropertyType>().WithMany().HasForeignKey(e => e.PropertyTypeId);
            builder.HasOne<PropertyStatus>().WithMany().HasForeignKey(e => e.PropertyStatusId);
            builder.HasOne<Agent>().WithMany().HasForeignKey(e => e.AgentId);
            builder.HasOne<Client>().WithMany().HasForeignKey(e => e.ClientId);
            builder.HasOne<Company>().WithMany().HasForeignKey(e=>e.CompanyId);



            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
