using MediatR;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDto;

public class GetAllCustomerDtoRequest : Pagination, IRequest<GetAllCustomerDtoResponse>{
    
}