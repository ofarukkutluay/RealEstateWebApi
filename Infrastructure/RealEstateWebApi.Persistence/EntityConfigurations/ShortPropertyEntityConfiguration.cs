using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class ShortPropertyEntityConfiguration : BaseConfiguration<ShortProperty>
    {
        public override void Configure(EntityTypeBuilder<ShortProperty> builder)
        {
            builder.HasOne<PropertyType>().WithMany().HasForeignKey(e=>e.PropertyTypeId);
            builder.HasOne<PropertyStatus>().WithMany().HasForeignKey(e=>e.PropertyStatusId);
            builder.HasOne<City>().WithMany().HasForeignKey(e => e.CityId);
            builder.HasOne<District>().WithMany().HasForeignKey(e => e.DistrictId);
            builder.HasOne<Neighborhood>().WithMany().HasForeignKey(e => e.NeighborhoodId);
            builder.HasOne<Street>().WithMany().HasForeignKey(e => e.StreetId);
            base.Configure(builder);
        }
    }
}
