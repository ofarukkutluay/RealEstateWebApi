using MediatR;


namespace RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderByUserId
{
    public class GetAllReminderByUserIdRequest : IRequest<GetAllReminderByUserIdResponse>
    {
        public uint UserId { get; set; }
    }
}
