using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class CustomerOwnedShortProperty : BaseEntity
    {
        public uint CustomerId { get; set; }
        public uint ShortPropertyId { get; set; }
        public uint? PropertyId { get; set; }
        public string? ShLink { get; set; }
        public string? EjLink { get; set; }
        public string? HeLink { get; set; }
        public string? OtherLink { get; set; }
    }
}
