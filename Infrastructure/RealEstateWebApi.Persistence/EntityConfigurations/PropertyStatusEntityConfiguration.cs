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
            builder.HasData(new PropertyStatus { Id = 1, Title = "Satılık", CreatedDate = DateTime.UtcNow }, new PropertyStatus { Id = 2, Title = "Kiralık", CreatedDate = DateTime.UtcNow },
                new PropertyStatus { Id = 3, Title = "Devren Satılık", CreatedDate = DateTime.UtcNow }, new PropertyStatus { Id = 4, Title = "Devren Kiralık", CreatedDate = DateTime.UtcNow });
            base.Configure(builder);
        }
    }
}
