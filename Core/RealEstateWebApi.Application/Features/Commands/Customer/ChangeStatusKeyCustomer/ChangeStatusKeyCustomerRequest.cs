using MediatR;

namespace RealEstateWebApi.Application.Features.Commands.Customer.ChangeStatusKeyCustomer;

public class ChangeStatusKeyCustomerRequest : IRequest<ChangeStatusKeyCustomerResponse>
{
    public uint CustomerId { get; set; }  
    public string StatusKey { get; set; }   

}
