using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class JobTitleEntityConfiguration : BaseConfiguration<JobTitle>
    {
        public override void Configure(EntityTypeBuilder<JobTitle> builder)
        {
            builder.HasOne<Company>().WithMany().HasForeignKey(e=>e.CompanyId);

            base.Configure(builder);
        }
    }
}
