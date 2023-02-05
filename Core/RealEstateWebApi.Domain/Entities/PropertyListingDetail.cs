using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class PropertyListingDetail : BaseEntity
    {
        public string? Title { get; set; }
        public string? ListingStoreName { get; set; }
        public string? ListingUserName { get; set; }
        public string? ListingPhoneNumbers { get; set; }
        public string? Description { get; set; }
        public string? DescriptionHtml { get; set; }
        public DateTime? ListingDate { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Neighborhood { get; set; }
        public string? LocationLat { get; set; }
        public string? LocationLon { get; set; }
        public double Price { get; set; }
        public string? Currency { get; set; }
        public string? Category { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public string? ReconstructionStatus { get; set; }
        public string? StructureType { get; set; }
        public int GrossSquareMeter { get; set; }
        public int UsableSquareMeter { get; set; }
        public double PricePerSquareMeter { get; set; }
        public int IndoorAreaSquareMeter { get; set; }
        public int OutdoorAreaSquareMeter { get; set; }

        public string? BlockNo { get; set; }
        public string? PlotNo { get; set; }
        public string? LayoutNo { get; set; }
        public string? FloorAreaRatio { get; set; }
        public string? Gabari { get; set; }
        public double RoomCount { get; set; }
        public short LivingRoomCount { get; set; }
        public string? BuildingAge { get; set; }
        public string? Floor { get; set; }
        public string? BuildingTotalFloor { get; set; }
        public string? ElevatorCount { get; set; }
        public string? InletHeight { get; set; }
        public string? HeatingType { get; set; }
        public short BathroomCount { get; set; }
        public bool IsThereBalcony { get; set; }
        public bool IsFurnished { get; set; }
        public string? UsingStatus { get; set; }
        public bool IsOnSite { get; set; }
        public string? SiteName { get; set; }
        public double Fees { get; set; }
        public bool IsAvailableLoan { get; set; }
        public string? DeedStatus { get; set; }
        public string? FromProfile { get; set; }
        public bool IsBarter { get; set; }
        public bool AlcoholLicense { get; set; }
        public bool SoilSurvey { get; set; }

        public string? Shlink { get; set; }

        public string ShPhotoLinks { get; set; } = String.Empty;
        public string PhotoPaths { get; set; } = String.Empty;

        [NotMapped]
        public List<PropertyListingPhoto> PropertyListingPhotos { get; set; }

    }
}
