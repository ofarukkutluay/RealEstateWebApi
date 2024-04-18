using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class PropertyListingPhoto : File
    {
        public string OuterPropertyListingId { get; set; }
        public int SortIndex { get; set; }
    }
}
