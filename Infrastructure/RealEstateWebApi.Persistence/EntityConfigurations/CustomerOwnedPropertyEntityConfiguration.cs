using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class CustomerOwnedPropertyEntityConfiguration : BaseConfiguration<CustomerOwnedProperty>
    {
        public override void Configure(EntityTypeBuilder<CustomerOwnedProperty> builder)
        {
            builder.HasOne<Customer>().WithMany().HasForeignKey(e=>e.CustomerId);
            builder.HasOne<Property>().WithMany().HasForeignKey(e=>e.PropertyId);
            builder.HasOne<PropertyListingDetail>().WithMany().HasForeignKey(e => e.PropertyListingDetailId);

            base.Configure(builder);
        }
    }
}
