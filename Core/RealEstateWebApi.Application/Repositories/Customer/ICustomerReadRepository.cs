using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Application.Repositories
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
        IQueryable<CustomerDto> GetAllDto();
        IQueryable<CustomerDto> GetAllDtoByAssignedUserId(uint assignedUserId);
        IQueryable<CustomerDto> GetAllDtoByStatusKey(string statusKey, uint assignedUserId);


        CustomerDto GetDtoById(uint id);
    }
}
