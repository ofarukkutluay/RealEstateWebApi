using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class CustomerSearchPropertyEntityConfiguration : BaseConfiguration<CustomerSearchProperty>
    {
        public override void Configure(EntityTypeBuilder<CustomerSearchProperty> builder)
        {
            builder.HasOne<Customer>().WithMany().HasForeignKey(e => e.CustomerId);
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
