namespace RealEstateWebApi.WebApp.Models
{
    public class CustomerFilter
    {
        public uint? Id { get; set; }   
        public string FullName { get; set; } = "";
        public string? MobileNumber { get; set; }
    }
}