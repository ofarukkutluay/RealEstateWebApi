﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class BlogTypeEntityConfiguration : BaseConfiguration<BlogType>
    {
        public override void Configure(EntityTypeBuilder<BlogType> builder)
        {
            builder.HasOne<Client>().WithMany().HasForeignKey(e=>e.ClientId);
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
