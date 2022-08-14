using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Application.Repositories
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
        IEnumerable<CustomerDto> GetAllDto();

        CustomerDto GetDtoById(uint id);
    }
}
