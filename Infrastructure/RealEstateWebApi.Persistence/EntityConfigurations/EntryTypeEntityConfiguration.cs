using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class EntryTypeEntityConfiguration : BaseConfiguration<EntryType>
    {
        public override void Configure(EntityTypeBuilder<EntryType> builder)
        {
            builder.HasData(new EntryType { Id = 1, Title = "Görüşme" , CreatedDate = DateTime.UtcNow});
            base.Configure(builder);
        }
    }
}
