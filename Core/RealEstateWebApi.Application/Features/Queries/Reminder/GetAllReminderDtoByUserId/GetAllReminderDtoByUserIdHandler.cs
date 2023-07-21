using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderDtoByUserId
{
    public class GetAllReminderDtoByUserIdHandler : IRequestHandler<GetAllReminderDtoByUserIdRequest, GetAllReminderDtoByUserIdResponse>
    {
        private readonly IReminderReadRepository _reminderReadRepository;

        public GetAllReminderDtoByUserIdHandler(IReminderReadRepository reminderReadRepository)
        {
            _reminderReadRepository = reminderReadRepository;
        }

        public async Task<GetAllReminderDtoByUserIdResponse> Handle(GetAllReminderDtoByUserIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<ReminderDto> reminders = _reminderReadRepository.GetReminderDtosByUserId(request.UserId);
            return await Task.FromResult(new GetAllReminderDtoByUserIdResponse()
            {
                Data = reminders,
                Message = $"{reminders.Count()} adet data getirildi.",
                Success = true
            });
        }
    }
}
