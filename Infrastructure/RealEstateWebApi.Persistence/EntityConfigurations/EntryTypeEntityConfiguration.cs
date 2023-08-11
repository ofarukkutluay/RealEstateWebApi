using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class EntryTypeEntityConfiguration : BaseConfiguration<EntryType>
    {
        public override void Configure(EntityTypeBuilder<EntryType> builder)
        {
            builder.HasData(new EntryType { Id = 1, Title = "Potansiyel",Key = "PTNSYL", CreatedDate = DateTime.UtcNow},
                new EntryType { Id = 2, Title = "Görüşme",Key = "GRSM", CreatedDate = DateTime.UtcNow },
                new EntryType { Id = 3, Title = "Teklif",Key="TKLF", CreatedDate = DateTime.UtcNow },
                new EntryType { Id = 4, Title = "Sözleşme",Key="SZLSM", CreatedDate = DateTime.UtcNow });
            base.Configure(builder);
        }
    }
}
