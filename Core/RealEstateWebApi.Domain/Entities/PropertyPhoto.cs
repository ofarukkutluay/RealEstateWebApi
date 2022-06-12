using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class PropertyPhoto : File
    {
        public uint PropertyId { get; set; }
        public int SortIndex { get; set; }

    }
}
