using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Results;


namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDto
{
    public class GetAllCustomerOwnedPropertyDtoResponse : DataResult<IEnumerable<CustomerOwnedPropertyDto>>
    {
    }
}
