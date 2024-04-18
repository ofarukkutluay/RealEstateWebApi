using MediatR;
using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Extensions;
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
        IEnumerable<CustomerDto> customerDtos = _customerReadRepository.GetAllDto()
            .Where(request.CityId != default, (arg) => arg.CityId == request.CityId)
            .Where(request.DistrictId != default, d => d.DistrictId == request.DistrictId)
            .Where(request.NeighborhoodId != default, n => n.NeighborhoodId == request.NeighborhoodId)
            .Where(request.Id != default, c => c.Id == request.Id)
            .Where(request.RegisterUserId != default, c => c.RegisterUserId == request.RegisterUserId)
            .Where(request.AssignedUserId != default, c => c.AssignedUserId == request.AssignedUserId)
            .Where(!string.IsNullOrEmpty(request.StatusKey), c => c.StatusKey.Contains(request.StatusKey ?? ""))
            .AsEnumerable()
            .Where(c => c.FullName.Contains(request.FullName ?? "", StringComparison.OrdinalIgnoreCase))
            .Where(c => c.MobileNumber.Contains(request.MobileNumber ?? ""));
            

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