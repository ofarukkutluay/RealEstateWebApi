using MediatR;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDto;

public class GetAllCustomerDtoRequest : Pagination, IRequest<GetAllCustomerDtoResponse>{
    public uint? Id { get; set; }
    public string? FullName { get; set; } = "";
    public uint? CityId { get; set; }
    public uint? DistrictId { get; set; }
    public uint? NeighborhoodId { get; set; }
    public string? MobileNumber { get; set; } = "";
    
    public uint? RegisterUserId { get; set; }
    public uint? AssignedUserId { get; set; }
    public string? StatusKey { get; set; } = "";
}