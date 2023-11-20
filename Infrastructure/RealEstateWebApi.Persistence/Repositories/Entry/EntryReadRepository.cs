using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;
using RealEstateWebApi.Application.DTOs;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class EntryReadRepository : ReadRepository<Entry, RealEstateWebApiDbContext>, IEntryReadRepository
    {
        public EntryReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }

        public IQueryable<EntryDto> GetEntryDtoByCustomerId(uint customerId){
            var result = from e in Table
                        join et in _context.EntryTypes on e.EntryTypeId equals et.Id
                        join est in _context.EntrySubTypes on e.EntrySubTypeId equals est.Id
                        join c in _context.Customers on e.CustomerId equals c.Id
                        join u in _context.Users on e.UserId equals u.Id
                        where e.CustomerId == customerId && e.IsDeleted == false
                        select new EntryDto{
                            Content = e.Content,
                            CreatedDate = e.CreatedDate.ToLocalTime(),
                            Customer = c.FullName,
                            EntrySubTitle = e.EntrySubTitle,
                            EntrySubType = est.Title,
                            EntryType = et.Title,
                            Id = e.Id,
                            IsActive = e.IsActive,
                            UpdatedDate = e.UpdatedDate != null ? e.UpdatedDate.Value.ToLocalTime() : null,
                            User = $"{u.FirstName} {u.LastName}"
                        };
            return result;
        }
    }
}
