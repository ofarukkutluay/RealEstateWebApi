using System;
namespace RealEstateWebApi.Application.DTOs
{
	public class ReminderDto
	{
        public uint Id { get; set; }
        public string? Description { get; set; }
        public DateTime ReminderDate { get; set; }
        public uint? EntryId { get; set; }
        public uint UserId { get; set; }
        public uint? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}

