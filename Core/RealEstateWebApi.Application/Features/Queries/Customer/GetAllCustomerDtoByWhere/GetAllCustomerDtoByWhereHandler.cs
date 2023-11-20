using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Extensions;
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
        // kullanımdan kaldırıldı. GetAllCustomerDto ya filtreleme eklendi.

        IQueryable<CustomerDto> customerDtos = _customerReadRepository.GetAllDto()
            .Where(request.CityId != default,(arg) => arg.CityId == request.CityId)
            .Where(request.DistrictId != default, d => d.DistrictId == request.DistrictId)
            .Where(request.NeighborhoodId != default, n => n.NeighborhoodId == request.NeighborhoodId)
            .Where(request.Id != default, c => c.Id == request.Id)
            .Where(c => c.FullName.Contains(request.FullName ?? ""))
            .Where(c=> c.MobileNumber.Contains(request.MobileNumber ?? ""));

        List<CustomerDto> sizedCustomerDtos = customerDtos
            .Skip(request.PageIndex * request.PageSize).Take(request.PageSize).ToList();
        return Task.FromResult(new GetAllCustomerDtoByWhereResponse(){
            Data = sizedCustomerDtos,
            TotalDataCount = customerDtos.Count(),
            Success = true,
            Message = $"{sizedCustomerDtos.Count()} data getirildi"
        });
    }
}