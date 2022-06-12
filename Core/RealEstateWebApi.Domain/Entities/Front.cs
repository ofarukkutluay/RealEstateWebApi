using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Front : BaseEntity
    {
        public uint ClientId { get; set; }
        public string Title { get; set; }
    }
}
