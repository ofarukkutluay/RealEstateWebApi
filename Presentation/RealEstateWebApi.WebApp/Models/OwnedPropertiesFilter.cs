namespace RealEstateWebApi.WebApp.Models;

public class OwnedPropertiesFilter
{
    public uint? PropertyTypeId { get; set; }
    public uint? PropertyStatusId { get; set; }
    public uint? CityId { get; set; }
    public uint? DistrictId { get; set; }
    public uint? NeighborhoodId { get; set; }
    
}