using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class EntrySubTypeEntityConfiguration : BaseConfiguration<EntrySubType>
    {
        public override void Configure(EntityTypeBuilder<EntrySubType> builder)
        {
            builder.HasOne<EntryType>().WithMany().HasForeignKey(e=>e.EntryTypeId);
            builder.HasData(new EntrySubType { Id = 1, EntryTypeId = 1, Title = "Telefon",Key="TLFN", CreatedDate = DateTime.UtcNow },
                new EntrySubType { Id = 2, EntryTypeId = 1, Title = "Ziyaret",Key="ZYRT" ,CreatedDate = DateTime.UtcNow },
                new EntrySubType { Id = 3, EntryTypeId = 1, Title = "Referans",Key="RFRNS", CreatedDate = DateTime.UtcNow },

                new EntrySubType { Id = 4 , EntryTypeId = 2, Title = "Ziyaret",Key="ZYRT", CreatedDate = DateTime.UtcNow},
                new EntrySubType { Id = 5, EntryTypeId = 2, Title = "Telefon", Key="TLFN", CreatedDate = DateTime.UtcNow },
                new EntrySubType { Id = 6, EntryTypeId = 2, Title = "Potansiyele Düşür", Key="DOWN", CreatedDate = DateTime.UtcNow },

                new EntrySubType { Id = 7, EntryTypeId = 3, Title = "Ön Teklif",Key="OTKLF", CreatedDate = DateTime.UtcNow },
                new EntrySubType { Id = 8, EntryTypeId = 3, Title = "Revize",Key="RVZ", CreatedDate = DateTime.UtcNow },
                new EntrySubType { Id = 9, EntryTypeId = 3, Title = "Kabul Etmedi", Key="DOWN", CreatedDate = DateTime.UtcNow },

                new EntrySubType { Id = 10, EntryTypeId = 4, Title = "Sunulan", Key ="SNLN", CreatedDate = DateTime.UtcNow },
                new EntrySubType { Id = 11, EntryTypeId = 4, Title = "Yapıldı", Key= "YPLD", CreatedDate = DateTime.UtcNow },
                new EntrySubType { Id = 12, EntryTypeId = 4, Title = "Kabul Etmedi", Key="DOWN", CreatedDate = DateTime.UtcNow });

            base.Configure(builder);
        }
    }
}
