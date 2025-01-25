namespace RealEstateWebApi.Domain.Entities
{
    public class Residential :Property
    {
        
        public double RoomCount { get; set; }
        public ushort LivingRoomCount { get; set; }
        public ushort BuildingAge { get; set; }
        public ushort BuildingTotalFloor { get; set; }
        public ushort? BuildingFloor { get; set; }
        public uint HeatingTypeId { get; set; }
        public ushort BathRoomCount { get; set; }
        public bool IsBalcony { get; set; }
        public bool IsElevator { get; set; }
        public ushort GarageCount { get; set; }
        public bool? IsFurnished { get; set; }
        public uint UsingStatusId { get; set; }
        public double? Fees { get; set; }
        public string? FeesCurrency { get; set; }
        public bool? IsAvailableLoan { get; set; }
        public uint DeedStatusId { get; set; }
        public bool IsBarter { get; set; }
        public bool IsOnSite { get; set; }
        public string? SiteName { get; set; }

        //kiralık için ek gerekenler 
        public double? Deposit { get; set; }
        public string? DepositCurrency { get; set; }

        //Tek bina içinin ek gereken 
        public int? SpaceSquareMeters { get; set; }

        //Devren satılık için ek gereken 
        public double? RemainingPaymentAmount { get; set; }
        public int? RemainingInstallment { get; set; }

    }
    
}