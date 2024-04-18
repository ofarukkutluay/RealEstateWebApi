using RealEstateWebApi.Domain.Entities.Common;


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
        public uint PropertyCategoryId { get; set; }
        public uint PropertyStatusId { get; set; }
        public uint PropertyTypeId { get; set; }
        public double Price { get; set; }
        public string PriceCurrency { get; set; }  
        public int GrossSquareMeter { get; set; }
        public int UsableSquareMeter { get; set; }     
        public uint? CompanyId { get; set; }
        public uint? ClientId { get; set; }
        public uint AgentId { get; set; }
        public double LocationLat { get; set; }
        public double LocationLon { get; set; }
        public string? YoutubeLink { get; set; }

    }
}
