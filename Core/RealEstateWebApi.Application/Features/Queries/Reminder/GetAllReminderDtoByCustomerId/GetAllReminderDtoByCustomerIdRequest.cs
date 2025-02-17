using System;
using MediatR;

namespace RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderDtoByCustomerId;

public class GetAllReminderDtoByCustomerIdRequest : IRequest<GetAllReminderDtoByCustomerIdResponse>
{
    public uint CustomerId { get; set; }

}
