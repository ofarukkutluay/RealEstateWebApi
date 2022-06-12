using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class InternetTypeEntityConfiguration : BaseConfiguration<InternetType>
    {
        public override void Configure(EntityTypeBuilder<InternetType> builder)
        {
            builder.HasOne<Client>().WithMany().HasForeignKey(e => e.ClientId);

            base.Configure(builder);
        }
    }
}
