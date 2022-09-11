namespace RealEstateWebApi.WebApp.Models
{
    public class ChangePasswordUser
    {
        public uint UserId { get; set; }
        public string OldPass { get; set; }
        public string NewPass { get; set; }
        public string ReNewPass { get; set; }
    }
}
