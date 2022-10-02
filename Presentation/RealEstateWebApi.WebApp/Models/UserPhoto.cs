namespace RealEstateWebApi.WebApp.Models
{
    public class UserPhoto
    {
        public uint UserId { get; set; }
        public IFormFile ProfilePhoto { get; set; }
    }
}
