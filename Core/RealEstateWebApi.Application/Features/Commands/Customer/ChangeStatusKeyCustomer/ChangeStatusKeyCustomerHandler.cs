using MediatR;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain;
using RealEstateWebApi.Domain.Enums;

namespace RealEstateWebApi.Application.Features.Commands.Customer.ChangeStatusKeyCustomer;

public class ChangeStatusKeyCustomerHandler : IRequestHandler<ChangeStatusKeyCustomerRequest, ChangeStatusKeyCustomerResponse>
{
    private readonly ICustomerReadRepository _customerReadRepository;
    private readonly ICustomerWriteRepository _customerWriteRepository;
    public ChangeStatusKeyCustomerHandler(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
    {
        _customerReadRepository = customerReadRepository;
        _customerWriteRepository = customerWriteRepository;
    }


    public async Task<ChangeStatusKeyCustomerResponse> Handle(ChangeStatusKeyCustomerRequest request, CancellationToken cancellationToken)
    {
        Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.CustomerId, tracking:true,cancellationToken:cancellationToken);

        if (customer == null)
            return new ChangeStatusKeyCustomerResponse{
                Success = false,
                Message = "Customer not found"
            };

        var customerStatusKey = typeof(CustomerStatusKey).GetField(request.StatusKey.ToUpper());
        if (customerStatusKey == null)
            return new ChangeStatusKeyCustomerResponse{
                Success = false,
                Message = "Girilen Status key hatalı"
            };


        customer.StatusKey = request.StatusKey.ToUpper();

        await _customerWriteRepository.SaveAsync(cancellationToken);

        return new ChangeStatusKeyCustomerResponse{
            Success = true,
            Message = "Data updated"
        };

        
    }
}
