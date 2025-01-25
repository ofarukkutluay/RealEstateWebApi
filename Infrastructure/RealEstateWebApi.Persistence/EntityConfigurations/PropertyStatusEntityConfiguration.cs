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
            builder.HasOne<PropertyCategory>().WithMany().HasForeignKey(x=>x.PropertyCategoryId);
            builder.HasData(new PropertyStatus { Id = 1, PropertyCategoryId = 1, Title = "Satılık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 2, PropertyCategoryId = 1, Title = "Kiralık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 3, PropertyCategoryId = 1, Title = "Günlük Kiralık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 4, PropertyCategoryId = 1, Title = "Devren Satılık Konut", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime()},
                new PropertyStatus { Id = 5, PropertyCategoryId = 2, Title = "Satılık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 6, PropertyCategoryId = 2, Title = "Kiralık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 7, PropertyCategoryId = 2, Title = "Devren Satılık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 8, PropertyCategoryId = 2, Title = "Devren Kiralık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 9, PropertyCategoryId = 3, Title = "Satılık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 10, PropertyCategoryId = 3, Title = "Kiralık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 11, PropertyCategoryId = 4, Title = "Satılık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 12, PropertyCategoryId = 4, Title = "Kiralık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 13, PropertyCategoryId = 5, Title = "Satılık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyStatus { Id = 14, PropertyCategoryId = 5, Title = "Kiralık", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() }

                );
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
