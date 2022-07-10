using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.EntityConfigurations
{
    public class PropertyTypeEntityConfiguraiton : BaseConfiguration<PropertyType>
    {
        public override void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.HasData(new PropertyType { Id = 1, Title = "Daire", CreatedDate = DateTime.UtcNow }, new PropertyType { Id = 2, Title = "Residans", CreatedDate = DateTime.UtcNow },
                new PropertyType { Id = 3, Title = "Müstakil Ev", CreatedDate = DateTime.UtcNow }, new PropertyType { Id = 4, Title = "Müstakil Bina", CreatedDate = DateTime.UtcNow },
                new PropertyType { Id = 5, Title = "Villa", CreatedDate = DateTime.UtcNow }, new PropertyType { Id = 6, Title = "Çiftlik Evi", CreatedDate = DateTime.UtcNow },
                new PropertyType { Id = 7, Title = "Yazlık", CreatedDate = DateTime.UtcNow }, new PropertyType { Id = 8, Title = "Büro/Ofis", CreatedDate = DateTime.UtcNow },
                new PropertyType { Id = 9, Title = "Depo/Antrepo", CreatedDate = DateTime.UtcNow }, new PropertyType { Id = 10, Title = "Dükkan/Mağaza", CreatedDate = DateTime.UtcNow },
                new PropertyType { Id = 11, Title = "Plaza", CreatedDate = DateTime.UtcNow }, new PropertyType { Id = 12, Title = "Palaza Katı", CreatedDate = DateTime.UtcNow },
                new PropertyType { Id = 13, Title = "Sağlık Merkezi", CreatedDate = DateTime.UtcNow }, new PropertyType { Id = 14, Title = "Spor Tesisi", CreatedDate = DateTime.UtcNow });
            base.Configure(builder);
        }
    }
}
