using MediatR;


namespace RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderDtoByUserId
{
    public class GetAllReminderDtoByUserIdRequest : IRequest<GetAllReminderDtoByUserIdResponse>
    {
        public uint UserId { get; set; }
    }
}
