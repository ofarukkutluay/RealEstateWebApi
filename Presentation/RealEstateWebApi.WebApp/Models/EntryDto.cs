namespace RealEstateWebApi.WebApp.Models;

public class EntryDto
{
   public uint Id { get; set; }
    public string Customer { get; set; }
    public string Content { get; set; }
    public string EntryType { get; set; }
    public string EntrySubType { get; set; }
    public string? EntrySubTitle { get; set; }
    public string User { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } 
}