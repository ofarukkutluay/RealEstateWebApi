using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class UserOperationClaimEntityConfiguration : BaseConfiguration<UserOperationClaim>
    {
        public override void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasOne<User>().WithMany().HasForeignKey(x=>x.UserId);
            builder.HasOne<OperationClaim>().WithMany().HasForeignKey(x=>x.OperationClaimId);
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
