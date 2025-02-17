using System;
using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderDtoByCustomerId;

public class GetAllReminderDtoByCustomerIdHandler : IRequestHandler<GetAllReminderDtoByCustomerIdRequest, GetAllReminderDtoByCustomerIdResponse>
{
    private readonly IReminderReadRepository _reminderReadRepository;

    public GetAllReminderDtoByCustomerIdHandler(IReminderReadRepository reminderReadRepository)
    {
        _reminderReadRepository = reminderReadRepository;
    }

    public Task<GetAllReminderDtoByCustomerIdResponse> Handle(GetAllReminderDtoByCustomerIdRequest request, CancellationToken cancellationToken)
    {
        IEnumerable<ReminderDto> reminderDtos = _reminderReadRepository.GetAllReminderDtoByCustomerId(request.CustomerId);
        return Task.FromResult(new GetAllReminderDtoByCustomerIdResponse { 
            Data = reminderDtos, Success = true, Message = "Reminders retrieved successfully", TotalDataCount = reminderDtos.Count() });

    }
}
