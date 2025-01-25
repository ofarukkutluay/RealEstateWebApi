using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class EntryTypeEntityConfiguration : BaseConfiguration<EntryType>
    {
        public override void Configure(EntityTypeBuilder<EntryType> builder)
        {
            builder.HasData(new EntryType { Id = 1,Title = "Görüşme",Key = "GRSM",  CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime()},
                new EntryType { Id = 2, Title = "Potansiyel",Key = "PTNSYL", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntryType { Id = 3, Title = "İlan",Key = "ILAN", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntryType { Id = 4, Title = "Teklif",Key="TKLF", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntryType { Id = 5, Title = "Sözleşme",Key="SZLSM", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() },
                new EntryType { Id = 6, Title = "Ulaşılamadı",Key="ULSLMD", CreatedDate = DateTime.MinValue.AddYears(2000).ToUniversalTime() });
            builder.HasQueryFilter(p => p.IsDeleted == false);
            base.Configure(builder);
        }
    }
}
