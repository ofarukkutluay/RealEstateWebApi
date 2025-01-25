namespace RealEstateWebApi.WebApp.Models
{
    public class PropertyListingPhoto : File
    {
        public string OuterPropertyListingId { get; set; }
        public int SortIndex { get; set; }
    }
}
