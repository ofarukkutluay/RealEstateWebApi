using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class CustomerOwnedShortPropertyEntityConfiguration : BaseConfiguration<CustomerOwnedShortProperty>
    {
        public override void Configure(EntityTypeBuilder<CustomerOwnedShortProperty> builder)
        {
            builder.HasOne<Customer>().WithMany().HasForeignKey(e=>e.CustomerId);
            builder.HasOne<ShortProperty>().WithMany().HasForeignKey(e=>e.ShortPropertyId);
            builder.HasOne<Property>().WithMany().HasForeignKey(e=>e.PropertyId);
            base.Configure(builder);
        }
    }
}
