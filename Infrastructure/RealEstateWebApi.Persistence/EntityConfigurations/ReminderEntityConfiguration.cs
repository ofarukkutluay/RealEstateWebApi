using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.Identity;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
	public class ReminderEntityConfiguration : BaseConfiguration<Reminder>
	{
        public override void Configure(EntityTypeBuilder<Reminder> builder)
        {
            builder.HasOne<User>().WithMany().HasForeignKey(x => x.UserId);
            builder.HasOne<Entry>().WithMany().HasForeignKey(x => x.EntryId);
            builder.HasOne<Customer>().WithMany().HasForeignKey(x => x.CustomerId);

            base.Configure(builder);
        }
    }
}

