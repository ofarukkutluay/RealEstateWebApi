using MediatR;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByWhere;

public class GetAllCustomerDtoByWhereRequest : Pagination, IRequest<GetAllCustomerDtoByWhereResponse>{
    public uint? Id { get; set; }   
    public string? FullName { get; set; } = "";
    public string? City { get; set; }
    public string? District { get; set; }
    public string? Neighborhood { get; set; }
    public string? MobileNumber { get; set; } 
}