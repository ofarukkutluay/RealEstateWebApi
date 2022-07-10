﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class OperationClaimEntityConfiguration : BaseConfiguration<OperationClaim>
    {
        public override void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasData(new OperationClaim { Id=1,Name="Admin",Alias="ADMIN",Description="Admin account", CreatedDate = DateTime.UtcNow },
                new OperationClaim { Id = 2, Name = "User", Alias = "USER", Description = "User account", CreatedDate = DateTime.UtcNow },
                new OperationClaim { Id = 3, Name = "Agent", Alias = "AGENT", Description = "Agent account", CreatedDate = DateTime.UtcNow });
            base.Configure(builder);
        }
    }
}
