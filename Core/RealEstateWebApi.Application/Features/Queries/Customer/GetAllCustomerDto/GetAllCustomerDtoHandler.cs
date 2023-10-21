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
        IEnumerable<CustomerDto> sizedCustomerDtos =
            customerDtos.Skip(request.PageIndex * request.PageSize).Take(request.PageSize);
        return Task.FromResult(new GetAllCustomerDtoResponse(){
            Data = sizedCustomerDtos,
            TotalDataCount = customerDtos.Count(),
            Success = true,
            Message = $"{sizedCustomerDtos.Count()} data getirildi"
        });
    }
}