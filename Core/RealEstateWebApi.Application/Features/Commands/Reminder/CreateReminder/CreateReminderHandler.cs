using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Reminder.CreateReminder
{
    public class CreateReminderHandler : IRequestHandler<CreateReminderRequest, CreateReminderResponse>
    {
        private readonly IReminderWriteRepository _reminderWriteRepository;
        private readonly IMapper _mapper;
        public CreateReminderHandler( IReminderWriteRepository reminderWriteRepository, IMapper mapper)
        {
            _reminderWriteRepository = reminderWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateReminderResponse> Handle(CreateReminderRequest request, CancellationToken cancellationToken)
        {

            Domain.Entities.Reminder reminder = _mapper.Map<Domain.Entities.Reminder>(request);
            var result = await _reminderWriteRepository.AddAndSaveAsync(reminder);
            
            if(result == null)
                return new CreateReminderResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateReminderResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
