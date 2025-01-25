using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Repositories
{
    public interface ICustomerOwnedPropertyReadRepository : IReadRepository<CustomerOwnedProperty>
    {
        IQueryable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDtoByCustomerId(uint customerId);
        IQueryable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDto();

    }
}
