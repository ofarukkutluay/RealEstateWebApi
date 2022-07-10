using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class DeedStatusEntityConfiguration : BaseConfiguration<DeedStatus>
    {
        public override void Configure(EntityTypeBuilder<DeedStatus> builder)
        {
            builder.HasData(new DeedStatus { Id = 1, Title = "Kat Mülkiyetli", CreatedDate = DateTime.UtcNow}, new DeedStatus { Id = 2, Title = "Kat İrtifaklı", CreatedDate = DateTime.UtcNow }, 
                new DeedStatus { Id = 3, Title = "Arsa", CreatedDate = DateTime.UtcNow }, new DeedStatus { Id = 4, Title = "Tarla", CreatedDate = DateTime.UtcNow });
            base.Configure(builder);
        }
    }
}
