namespace RealEstateWebApi.WebApp.Models
{
    public class CustomerFilter
    {
        public uint? Id { get; set; }   
        public string? FullName { get; set; }
        public string? MobileNumber { get; set; }
        public uint? CityId { get; set; }
        public uint? DistrictId { get; set; }
        public uint? NeighborhoodId { get; set; }
    }
}