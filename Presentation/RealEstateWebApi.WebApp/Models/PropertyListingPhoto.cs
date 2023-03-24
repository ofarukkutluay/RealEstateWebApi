namespace RealEstateWebApi.WebApp.Models
{
    public class PropertyListingPhoto : File
    {
        public uint PropertyListingDetailId { get; set; }
        public int SortIndex { get; set; }
    }
}
