using System.Globalization;
using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByWhere;

public class GetAllCustomerDtoByWhereHandler : IRequestHandler<GetAllCustomerDtoByWhereRequest, GetAllCustomerDtoByWhereResponse>
{
    private readonly ICustomerReadRepository _customerReadRepository;

    public GetAllCustomerDtoByWhereHandler(ICustomerReadRepository customerReadRepository)
    {
        _customerReadRepository = customerReadRepository;
    }

    public Task<GetAllCustomerDtoByWhereResponse> Handle(GetAllCustomerDtoByWhereRequest request, CancellationToken cancellationToken)
    {
        IQueryable<CustomerDto> customerDtos = _customerReadRepository.GetAllDto();
        
        if(request.FullName is null)
            request.FullName = "";

        IEnumerable<CustomerDto> sizedCustomerDtos = customerDtos
            .Where(c => c.Id == request.Id || c.FullName.Contains(request.FullName) || c.MobileNumber  == request.MobileNumber)
            .Skip(request.PageIndex * request.PageSize).Take(request.PageSize);
        return Task.FromResult(new GetAllCustomerDtoByWhereResponse(){
            Data = sizedCustomerDtos.ToList(),
            TotalDataCount = customerDtos.Count(),
            Success = true,
            Message = $"{sizedCustomerDtos.Count()} data getirildi"
        });
    }
}