using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class AgentEntityConfiguration : BaseConfiguration<Agent>
    {
        public override void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasOne<User>().WithOne().HasForeignKey<Agent>(e=>e.Id);
            builder.HasOne<Company>().WithMany().HasForeignKey(e=>e.CompanyId);
            builder.HasOne<JobTitle>().WithMany().HasForeignKey(e=>e.JobTitleId);
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
