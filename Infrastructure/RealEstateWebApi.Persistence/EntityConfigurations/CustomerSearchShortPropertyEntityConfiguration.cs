using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class CustomerSearchShortPropertyEntityConfiguration : BaseConfiguration<CustomerSearchShortProperty>
    {
        public override void Configure(EntityTypeBuilder<CustomerSearchShortProperty> builder)
        {
            builder.HasOne<Customer>().WithMany().HasForeignKey(e => e.CustomerId);
            builder.HasOne<ShortProperty>().WithMany().HasForeignKey(e => e.ShortPropertyId);
            base.Configure(builder);
        }
    }
}
