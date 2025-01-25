using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Reminder.UpdateReminder
{
    public class UpdateReminderHandler : IRequestHandler<UpdateReminderRequest, UpdateReminderResponse>
    {
        private readonly IReminderReadRepository _reminderReadRepository;
        private readonly IReminderWriteRepository _reminderWriteRepository;
        public UpdateReminderHandler(IReminderReadRepository reminderReadRepository, IReminderWriteRepository reminderWriteRepository)
        {
            _reminderReadRepository = reminderReadRepository;
            _reminderWriteRepository = reminderWriteRepository;
        }

        public async Task<UpdateReminderResponse> Handle(UpdateReminderRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Reminder reminder = await _reminderReadRepository.GetByIdAsync(request.Id);
            if(reminder is null)
                return new UpdateReminderResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            reminder.Description = String.IsNullOrEmpty(request.Description) ? reminder.Description : request.Description;
            reminder.ReminderDate = request.ReminderDate;
            reminder.IsActive = request.IsActive;
            var result = await _reminderWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateReminderResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateReminderResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
