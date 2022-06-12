using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class PropertyStatusEntityConfiguration : BaseConfiguration<PropertyStatus>
    {
        public override void Configure(EntityTypeBuilder<PropertyStatus> builder)
        {
            builder.HasOne<Client>().WithMany().HasForeignKey(e => e.ClientId);

            base.Configure(builder);
        }
    }
}
