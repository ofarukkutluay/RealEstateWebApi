using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.Reminder.UpdateReminder
{
    public class UpdateReminderRequest : IRequest<UpdateReminderResponse>
    {
        public uint Id { get; set; }
        public string? Description { get; set; }
        public DateTime ReminderDate { get; set; }
        public bool IsActive { get; set; }
    }
}
