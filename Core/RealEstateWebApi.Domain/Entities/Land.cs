namespace RealEstateWebApi.Domain.Entities
{
    public class Land :Property
    {
        public string ReconstructionStatus { get; set; }
        public int? BlockNo { get; set; }
        public int? PlotNo { get; set; }
        public int? LayoutNo { get; set; }
        public double? FloorAreaRatio { get; set; }
        public double? Gabari { get; set; }
        public bool ExchangeForBuilding { get; set; }
        
        //kiralık için ek gerekenler 
        public double? Deposit { get; set; }
        public string? DepositCurrency { get; set; }
        
    }
    
}