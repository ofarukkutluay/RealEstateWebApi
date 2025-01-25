using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class CustomerEntityConfiguration : BaseConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne<City>().WithMany().HasForeignKey(e=>e.CityId);
            builder.HasOne<District>().WithMany().HasForeignKey(e => e.DistrictId);
            builder.HasOne<Neighborhood>().WithMany().HasForeignKey(e => e.NeighborhoodId);
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
