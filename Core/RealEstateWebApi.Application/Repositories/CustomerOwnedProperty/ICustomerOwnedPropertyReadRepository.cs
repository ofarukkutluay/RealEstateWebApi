using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Repositories
{
    public interface ICustomerOwnedPropertyReadRepository : IReadRepository<CustomerOwnedProperty>
    {
        IEnumerable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDtoByCustomerId(uint customerId);
        IEnumerable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDto(Pagination pagination);

    }
}
