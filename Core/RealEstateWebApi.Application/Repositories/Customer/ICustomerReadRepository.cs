using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Application.Repositories
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
        IEnumerable<CustomerDto> GetAllDto();
        IEnumerable<CustomerDto> GetAllDtoByAssignedUserId(uint assignedUserId);
        IEnumerable<CustomerDto> GetAllDtoByStatusKey(string statusKey, uint assignedUserId);


        CustomerDto GetDtoById(uint id);
    }
}
