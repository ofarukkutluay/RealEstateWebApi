using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class PropertyCategoryEntityConfiguration : BaseConfiguration<PropertyCategory>
    {
        public override void Configure(EntityTypeBuilder<PropertyCategory> builder)
        {
            builder.HasData(new PropertyCategory { Id = 1, Title = "Konut", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyCategory { Id = 2, Title = "İşyeri", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyCategory { Id = 3, Title = "Arsa", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyCategory { Id = 4, Title = "Bina", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new PropertyCategory { Id = 5, Title = "Turistik Tesis", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() });
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }

    }
}