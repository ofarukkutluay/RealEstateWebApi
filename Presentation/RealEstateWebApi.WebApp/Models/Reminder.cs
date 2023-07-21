using System;
namespace RealEstateWebApi.WebApp.Models
{
	public class Reminder
	{
        public uint Id { get; set; }
        public DateTime CreatedDate { get; set; }
        virtual public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public DateTime ReminderDate { get; set; }
        public uint? EntryId { get; set; }
        public uint UserId { get; set; }
        public uint? CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}

