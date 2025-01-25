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
            builder.HasData(new InternetType { Id = 1, Title = "Adsl/Vdsl", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() }, 
            new InternetType { Id = 2, Title = "Fiber", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() }, 
                new InternetType { Id = 3, Title = "Uydu", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() }, 
                new InternetType { Id = 4, Title = "Altyapı Yok", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() });

            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
