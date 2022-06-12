using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class BlogEntityConfiguration : BaseConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasOne<Company>().WithMany().HasForeignKey(e=>e.CompanyId);
            builder.HasOne<Agent>().WithMany().HasForeignKey(e=>e.AgentId);
            builder.HasOne<Domain.Entities.File>().WithMany().HasForeignKey(e=>e.BlogPageImgFileId);
            builder.HasOne<BlogType>().WithMany().HasForeignKey(e=>e.BlogTypeId);
            builder.HasOne<Client>().WithMany().HasForeignKey(e => e.ClientId);



            base.Configure(builder);
        }
    }
}
