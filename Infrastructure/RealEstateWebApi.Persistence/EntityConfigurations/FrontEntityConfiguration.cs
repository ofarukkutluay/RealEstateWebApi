using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class FrontEntityConfiguration : BaseConfiguration<Front>
    {
        public override void Configure(EntityTypeBuilder<Front> builder)
        {
            builder.HasData(new Front { Id = 1,Title = "Kuzey", CreatedDate = DateTime.MinValue }, new Front { Id = 2, Title = "Kuzey Doğu", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() }, 
                new Front { Id = 3, Title = "Doğu", CreatedDate = DateTime.MinValue }, new Front { Id = 4, Title = "Güney Doğu", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() }, 
                new Front { Id = 5, Title = "Güney", CreatedDate = DateTime.MinValue }, new Front { Id = 6, Title = "Güney Batı", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() }, 
                new Front { Id = 7, Title = "Batı", CreatedDate = DateTime.MinValue }, new Front { Id = 8, Title = "Kuzey Batı", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() });

            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
