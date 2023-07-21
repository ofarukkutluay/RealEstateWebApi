using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.Reminder.CreateReminder
{
    public class CreateReminderRequest : IRequest<CreateReminderResponse>
    {
        public string? Description { get; set; }
        public DateTime ReminderDate { get; set; }
        public uint? EntryId { get; set; }
        public uint UserId { get; set; }
        public uint? CustomerId { get; set; }
    }
}
