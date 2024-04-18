namespace RealEstateWebApi.Domain.Entities
{
    public class Commercial : Property
    {
        public int OutdoorSquareMeters { get; set; }
        public int IndoorSquareMeters { get; set; }

        //Apartman Dairesi
        public double SectionAndRoomCount { get; set; }
        public ushort BathroomCount { get; set; }
        public ushort BuildingTotalFloor { get; set; }
        public ushort BuildingFloor { get; set; }
        public double? Fees { get; set; }
        public string? FeesCurrency { get; set; }
        public ushort BuildingAge { get; set; }
        public uint HeatingTypeId { get; set; }
        public uint UsingStatusId { get; set; }
        public uint DeedStatusId { get; set; }
        public string BuildingStatus { get; set; }
        public bool IsAvailableLoan { get; set; }
        public bool IsBarter { get; set; }


        //Akaryakıt istasyonu için
        public int? PumpCount { get; set; }
        public int? DailySaleFuelLiter { get; set; }

        //Atölye
        public int EntryHeightMeters { get; set; }

        //Avm
        public int ElevatorCount { get; set; }

        //Büfe
        public string BuildingType { get; set; }

        //Cafe&Bar
        public bool AlcoholLicense { get; set; }

        //Depo&Antrepo
        public string GroundSurvey { get; set; }

        //Düğün Salonu
        public int TableCapacity { get; set; }
        public int PeopleCapacity { get; set; }

        //Fabrika 
        public int BuildingCount { get; set; }

        //Maden Ocağı
        public bool MiningLicense { get; set; }

        //Otopark
        public int VehicleCapacity { get; set; }

        //Sinema & Konferans salonu
        public int CeilingHeightMeters { get; set; }

        //kiralık için ek gerekenler 
        public double? Deposit { get; set; }
        public string? DepositCurrency { get; set; }
    }
    
}