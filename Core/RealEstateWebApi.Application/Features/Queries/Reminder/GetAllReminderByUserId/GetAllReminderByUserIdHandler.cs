using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderByUserId
{
    public class GetAllReminderByUserIdHandler : IRequestHandler<GetAllReminderByUserIdRequest, GetAllReminderByUserIdResponse>
    {
        private readonly IReminderReadRepository _reminderReadRepository;

        public GetAllReminderByUserIdHandler(IReminderReadRepository reminderReadRepository)
        {
            _reminderReadRepository = reminderReadRepository;
        }

        public async Task<GetAllReminderByUserIdResponse> Handle(GetAllReminderByUserIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Reminder> reminders = _reminderReadRepository.GetWhere(e=>e.UserId == request.UserId);
            return await Task.FromResult(new GetAllReminderByUserIdResponse()
            {
                Data = reminders,
                Message = $"{reminders.Count()} adet data getirildi.",
                Success = true
            });
        }
    }
}
