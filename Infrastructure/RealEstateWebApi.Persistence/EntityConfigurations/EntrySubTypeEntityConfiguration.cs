using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class EntrySubTypeEntityConfiguration : BaseConfiguration<EntrySubType>
    {
        public override void Configure(EntityTypeBuilder<EntrySubType> builder)
        {
            builder.HasOne<EntryType>().WithMany().HasForeignKey(e=>e.EntryTypeId);
            builder.HasData(new EntrySubType { Id = 1 , EntryTypeId = 1, Title = "Ziyaret",CreatedDate = DateTime.UtcNow},
                new EntrySubType { Id = 2, EntryTypeId = 1, Title = "Telefon", CreatedDate = DateTime.UtcNow });

            base.Configure(builder);
        }
    }
}
