using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Results;


namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchShortProperty.GetAllShortPropertyDtoByCustomerId
{
    public class GetAllShortPropertyDtoByCustomerIdResponse : DataResult<IEnumerable<CustomerSearchShortPropertyDto>>
    {
    }
}
