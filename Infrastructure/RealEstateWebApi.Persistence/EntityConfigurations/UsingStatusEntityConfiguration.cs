using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class UsingStatusEntityConfiguration : BaseConfiguration<UsingStatus>
    {
        public override void Configure(EntityTypeBuilder<UsingStatus> builder)
        {
            builder.HasData(new UsingStatus { Id = 1, Title = "Boş", CreatedDate = DateTime.UtcNow }, new UsingStatus { Id = 2, Title = "Mülk Sahibi", CreatedDate = DateTime.UtcNow },
                new UsingStatus { Id = 3, Title = "Kiracılı", CreatedDate = DateTime.UtcNow });
            base.Configure(builder);
        }
    }
}
