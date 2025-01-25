using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Street : IEntity
    {
        public uint Id { get; set; }
        public int NeighborhoodKey { get; set; }
        public string Name { get; set; }
    }
}
