﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.HasOne<Client>().WithMany().HasForeignKey(e => e.ClientId);

            base.Configure(builder);
        }
    }
}
