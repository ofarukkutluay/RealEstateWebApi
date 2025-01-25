using System.ComponentModel.DataAnnotations.Schema;
using RealEstateWebApi.Domain.Entities.Common;

namespace RealEstateWebApi.Domain.Entities;

public class OuterPropertyListing : IEntity<string>
{
    public string Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ListingDate { get; set; }
    virtual public DateTime? UpdatedDate { get; set; }
    //public bool IsActive { get; set; } = true;
    //public bool IsDeleted { get; set; } = false;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? DescriptionHtml { get; set; }

    public string? City { get; set; }
    public string? District { get; set; }
    public string? Neighborhood { get; set; }
    public string? PropertyCategory { get; set; }
    public string? PropertyStatus { get; set; }
    public string? PropertyType { get; set; }
    public double? Price { get; set; }
    public string? PriceCurrency { get; set; }
    public int? GrossSquareMeter { get; set; }
    public int? UsableSquareMeter { get; set; }
    public string? LocationLat { get; set; }
    public string? LocationLon { get; set; }

    public string? ListingStoreName { get; set; }
    public string? ListingUserName { get; set; }
    public string? ListingPhoneNumbers { get; set; }
    public string? FromProfile { get; set; }
    public string? ListiningLink { get; set; }

    public string? PhotoLinks { get; set; }
    public string? PhotoPaths { get; set; } 

    [NotMapped]
    public List<PropertyListingPhoto> PropertyListingPhotos { get; set; }

    public double? RoomCount { get; set; }
    public ushort? LivingRoomCount { get; set; }
    public string? BuildingAge { get; set; }
    public string? BuildingTotalFloor { get; set; }
    public string? BuildingFloor { get; set; }
    public string? HeatingType { get; set; }
    public ushort? BathroomCount { get; set; }
    public bool? IsBalcony { get; set; }
    public bool? IsElevator { get; set; }
    public string? Garage { get; set; }
    public bool? IsFurnished { get; set; }
    public string? UsingStatus { get; set; }
    public double? Fees { get; set; }
    public string? FeesCurrency { get; set; }
    public bool? IsAvailableLoan { get; set; }
    public string? DeedStatus { get; set; }
    public bool? IsBarter { get; set; }
    public bool? IsOnSite { get; set; }
    public string? SiteName { get; set; }

    //kiralık için ek gerekenler 
    public double? Deposit { get; set; }
    public string? DepositCurrency { get; set; }

    //Tek bina içinin ek gereken 
    public int? SpaceSquareMeters { get; set; }

    //Devren satılık için ek gereken 
    public double? RemainingPaymentAmount { get; set; }
    public int? RemainingInstallment { get; set; }

    public string? ReconstructionStatus { get; set; }
    public int? BlockNo { get; set; }
    public int? PlotNo { get; set; }
    public int? LayoutNo { get; set; }
    public double? FloorAreaRatio { get; set; }
    public double? Gabari { get; set; }
    public bool? ExchangeForBuilding { get; set; }

    public int? OutdoorSquareMeters { get; set; }
    public int? IndoorSquareMeters { get; set; }

    //Apartman Dairesi
    public double? SectionAndRoomCount { get; set; }

    public uint? HeatingTypeId { get; set; }
    public uint? UsingStatusId { get; set; }
    public uint? DeedStatusId { get; set; }
    public string? BuildingStatus { get; set; }


    //Akaryakıt istasyonu için
    public int? PumpCount { get; set; }
    public int? DailySaleFuelLiter { get; set; }

    //Atölye
    public int? EntryHeightMeters { get; set; }

    //Avm
    public int? ElevatorCount { get; set; }

    //Büfe
    public string? BuildingType { get; set; }

    //Cafe&Bar
    public bool? AlcoholLicense { get; set; }

    //Depo&Antrepo
    public string? GroundSurvey { get; set; }

    //Düğün Salonu
    public int? TableCapacity { get; set; }
    public int? PeopleCapacity { get; set; }

    //Fabrika 
    public int? BuildingCount { get; set; }

    //Maden Ocağı
    public bool? MiningLicense { get; set; }

    //Otopark
    public int? VehicleCapacity { get; set; }

    //Sinema & Konferans salonu
    public int? CeilingHeightMeters { get; set; }


    public int? StarCount { get; set; }
    public int? BedCount { get; set; }


    //apart otel
    public int? ApartCount { get; set; }

    //Kamp Yeri
    public int? TotalLandAcres { get; set; }

}
