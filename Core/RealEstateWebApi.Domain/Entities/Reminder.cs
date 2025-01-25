using RealEstateWebApi.Domain.Entities.Common;

namespace RealEstateWebApi.Domain.Entities
{
	public class Reminder : BaseEntity
	{
		public string? Description { get; set; }
		public DateTime ReminderDate { get; set; }
		public uint? EntryId { get; set; }
		public uint UserId { get; set; }
		public uint? CustomerId { get; set; }
	}
}

