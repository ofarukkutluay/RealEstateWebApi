using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Property : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public uint CityId { get; set; }
        public uint DistrictId { get; set; }
        public uint NeighborhoodId { get; set; }
        public uint? StreetId { get; set; }
        public uint PropertyTypeId { get; set; }
        public uint PropertyStatusId { get; set; }
        public uint HeatingTypeId { get; set; }
        public uint InternetTypeId { get; set; }
        public uint FrontId { get; set; }
        public uint UsingStatusId { get; set; }
        public uint DeedStatusId { get; set; }
        public uint CompanyId { get; set; }
        public uint ClientId { get; set; }
        public uint AgentId { get; set; }


        public double? LocationLat { get; set; }
        public double? LocationLon { get; set; }

        public int GrossSquareMeter { get; set; }
        public int UsableSquareMeter { get; set; }
        public ushort BuildingTotalFloor { get; set; }
        public ushort BuildingFloor { get; set; }
        public ushort BuildingAge { get; set; }
        public ushort RoomCount { get; set; }
        public ushort LivingRoomCount { get; set; }
        public ushort? BathRoomCount { get; set; }
        public ushort? GarageCount { get; set; }
        public ushort? BalconyCount { get; set; }

        public string? Landscape { get; set; }
        public bool IsSmartHome { get; set; }
        public bool IsFurnished { get; set; }
        public bool IsOnSite { get; set; }
        public string? SiteName { get; set; }

        public double Price { get; set; }
        public double? Aidat { get; set; }
        public bool IsAvailableLoan { get; set; }
        public string? YoutubeLink { get; set; }
        public string? KonumIFrame { get; set; }
    }
}
