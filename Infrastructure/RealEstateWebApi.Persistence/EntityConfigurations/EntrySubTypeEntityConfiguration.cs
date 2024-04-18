using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class EntrySubTypeEntityConfiguration : BaseConfiguration<EntrySubType>
    {
        public override void Configure(EntityTypeBuilder<EntrySubType> builder)
        {
            builder.HasOne<EntryType>().WithMany().HasForeignKey(e=>e.EntryTypeId);
            builder.HasData(new EntrySubType { Id = 1, EntryTypeId = 1, Title = "Telefon",Key="TLFN", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 2, EntryTypeId = 1, Title = "Ziyaret",Key="ZYRT" ,CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },

                new EntrySubType { Id = 3, EntryTypeId = 2, Title = "Takip", Key="TAKIP", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 4, EntryTypeId = 2, Title = "Görüşme", Key="GRSM", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 5 , EntryTypeId = 2, Title = "İstemiyor",Key="DOWN", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime()},
                
                new EntrySubType { Id = 6, EntryTypeId = 3, Title = "Girmeden Çalış",Key="GIRME", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 7, EntryTypeId = 3, Title = "Yetkili",Key="YETKI", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 8, EntryTypeId = 3, Title = "Yetkisiz",Key="YETKISIZ", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 9, EntryTypeId = 3, Title = "Vazgeçti", Key="PDOWN", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },

                new EntrySubType { Id = 10, EntryTypeId = 4, Title = "Gelen", Key ="GLN", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 11, EntryTypeId = 4, Title = "Takip", Key= "TAKIP", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 12, EntryTypeId = 4, Title = "Kabul Etmedi", Key="IDOWN", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                
                new EntrySubType { Id = 13, EntryTypeId = 5, Title = "Satıldı",Key="STLDI", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntrySubType { Id = 14, EntryTypeId = 5, Title = "Kiralandı",Key="KRLND" ,CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                
                new EntrySubType { Id = 15, EntryTypeId = 6, Title = "Ulaşılamadı",Key="ULSLMD", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() });

            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
