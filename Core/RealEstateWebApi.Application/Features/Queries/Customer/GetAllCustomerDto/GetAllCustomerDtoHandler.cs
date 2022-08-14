using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDto;

public class GetAllCustomerDtoHandler : IRequestHandler<GetAllCustomerDtoRequest, GetAllCustomerDtoResponse>
{
    private readonly ICustomerReadRepository _customerReadRepository;

    public GetAllCustomerDtoHandler(ICustomerReadRepository customerReadRepository)
    {
        _customerReadRepository = customerReadRepository;
    }

    public Task<GetAllCustomerDtoResponse> Handle(GetAllCustomerDtoRequest request, CancellationToken cancellationToken)
    {
        IEnumerable<CustomerDto> customerDtos = _customerReadRepository.GetAllDto();
        return Task.FromResult(new GetAllCustomerDtoResponse(){
            Data = customerDtos,
            Success = true,
            Message = $"{customerDtos.Count()} data getirildi"
        });
    }
}