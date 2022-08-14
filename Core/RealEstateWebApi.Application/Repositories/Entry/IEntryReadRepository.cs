using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;


namespace RealEstateWebApi.Application.Repositories
{
    public interface IEntryReadRepository : IReadRepository<Entry>
    {
        IEnumerable<EntryDto> GetEntryDtoByCustomerId(uint customerId);
    }


}
