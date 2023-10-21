using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class HeatingTypeEntityConfiguration : BaseConfiguration<HeatingType>
    {
        public override void Configure(EntityTypeBuilder<HeatingType> builder)
        {
            builder.HasData(new HeatingType { Id = 1, Title = "Doğalgaz Sobalı", CreatedDate = DateTime.UtcNow }, new HeatingType { Id = 2, Title = "Sobalı", CreatedDate = DateTime.UtcNow },
                new HeatingType { Id = 3, Title = "Yerden Isıtma", CreatedDate = DateTime.UtcNow }, new HeatingType { Id = 4, Title = "Kombili", CreatedDate = DateTime.UtcNow },
                new HeatingType { Id = 5, Title = "Merkezi Sistem", CreatedDate = DateTime.UtcNow }, new HeatingType { Id = 6, Title = "FuelOil", CreatedDate = DateTime.UtcNow });

            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
