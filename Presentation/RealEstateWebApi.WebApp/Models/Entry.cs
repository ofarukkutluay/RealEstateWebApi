namespace RealEstateWebApi.WebApp.Models
{
    public class Entry
    {

        public uint Id { get; set; }
        public uint CustomerId { get; set; }
        public string Content { get; set; }
        public uint EntryTypeId { get; set; }
        public uint EntrySubTypeId { get; set; }
        public string? EntrySubTitle { get; set; }
        public uint UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
