namespace RealEstateWebApi.Domain.Entities
{
    public class Tourism :Property
    {
        public int StarCount { get; set; }
        public int RoomCount { get; set; }
        public int BedCount { get; set; }
        public int BuildingTotalFloor { get; set; }
        public int BuildingAge { get; set; }
        public int IndoorSquareMeters { get; set; }
        public int OutdoorSquareMeters { get; set; }
        public string GroundSurvey { get; set; }
        public bool IsAvailableLoan { get; set; }
        public string BuildingStatus { get; set; }

        //apart otel
        public int ApartCount { get; set; }

        //Kamp Yeri
        public int TotalLandAcres { get; set; }
    }
    
}