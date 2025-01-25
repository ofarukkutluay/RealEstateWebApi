using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Application.Repositories
{
    public interface IEntryReadRepository : IReadRepository<Entry>
    {
        IQueryable<EntryDto> GetEntryDtoByCustomerId(uint customerId);
    }


}
