using MediatR;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByWhere;

public class GetAllCustomerDtoByWhereRequest : Pagination, IRequest<GetAllCustomerDtoByWhereResponse>{
    public uint? Id { get; set; }   
    public string? FullName { get; set; } = "";
    public uint? CityId { get; set; }
    public uint? DistrictId { get; set; }
    public uint? NeighborhoodId { get; set; }
    public string? MobileNumber { get; set; } = "";
}