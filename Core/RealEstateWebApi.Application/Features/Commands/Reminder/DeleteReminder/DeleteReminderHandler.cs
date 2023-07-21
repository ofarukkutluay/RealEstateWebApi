using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Reminder.DeleteReminder
{
    public class DeleteReminderHandler : IRequestHandler<DeleteReminderRequest, DeleteReminderResponse>
    {
        private readonly IReminderReadRepository _reminderReadRepository;
        private readonly IReminderWriteRepository _reminderWriteRepository;

        public DeleteReminderHandler(IReminderReadRepository reminderReadRepository, IReminderWriteRepository reminderWriteRepository)
        {
            _reminderReadRepository = reminderReadRepository;
            _reminderWriteRepository = reminderWriteRepository;
        }

        public async Task<DeleteReminderResponse> Handle(DeleteReminderRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Reminder reminder = await _reminderReadRepository.GetByIdAsync(request.Id);
            if(reminder == null)
                return new DeleteReminderResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            reminder.IsDeleted = true;
            var result = await _reminderWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteReminderResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteReminderResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
