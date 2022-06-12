using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class ClientEntityConfiguration : BaseConfiguration<Client>
    {
        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasOne<Company>().WithMany().HasForeignKey(x => x.CompanyId);
            builder.HasOne<Domain.Entities.File>().WithMany().HasForeignKey(x=>x.LogoImgFileId);

            base.Configure(builder);
        }
    }
}
