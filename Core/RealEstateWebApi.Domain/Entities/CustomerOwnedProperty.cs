using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class CustomerOwnedProperty : BaseEntity
    {
        public uint CustomerId { get; set; }
        public uint? PropertyId { get; set; }
        public string? OuterPropertyListingId { get; set; }
        public uint? PropertyTypeId { get; set; }
        public uint? PropertyStatusId { get; set; }
        public double? RoomCount { get; set; }
        public ushort? LivingRoomCount { get; set; }
        public uint? CityId { get; set; }
        public uint? DistrictId { get; set; }
        public uint? NeighborhoodId { get; set; }
        public uint? StreetId { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public string? ShLink { get; set; }
        public string? EjLink { get; set; }
        public string? HeLink { get; set; }
        public string? OtherLink { get; set; }
    }
}
