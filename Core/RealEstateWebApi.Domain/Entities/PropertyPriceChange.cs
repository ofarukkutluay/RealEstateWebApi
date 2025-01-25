using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    [Keyless]
    public class PropertyPriceChange
    {
        public double Price { get; set; }
        public DateTime CreatingDate { get; set; } = DateTime.Now;
        public long ListingId { get; set; }
    }
}
