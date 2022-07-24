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
    public class EntryEntityConfiguration : BaseConfiguration<Entry>
    {
        public override void Configure(EntityTypeBuilder<Entry> builder)
        {
            builder.HasOne<Customer>().WithMany().HasForeignKey(e=>e.CustomerId);
            builder.HasOne<EntryType>().WithMany().HasForeignKey(e=>e.EntryTypeId);
            builder.HasOne<EntrySubType>().WithMany().HasForeignKey(e=>e.EntrySubTypeId);
            builder.HasOne<User>().WithMany().HasForeignKey(e=>e.UserId);

            base.Configure(builder);
        }
    }
}
