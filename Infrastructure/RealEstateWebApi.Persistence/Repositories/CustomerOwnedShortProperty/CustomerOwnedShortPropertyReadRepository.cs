using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class CustomerOwnedShortPropertyReadRepository : ReadRepository<CustomerOwnedShortProperty, RealEstateWebApiDbContext>, ICustomerOwnedShortPropertyReadRepository
    {
        public CustomerOwnedShortPropertyReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }

        public IEnumerable<ShortPropertyDto> GetAllShortPropertyDtoByCustomerId(uint customerId)
        {
            var result = from cosp in Table
                         join sp in _context.ShortProperties on cosp.ShortPropertyId equals sp.Id
                         where cosp.CustomerId == customerId && cosp.IsDeleted == false
                         select new ShortPropertyDto
                         {
                             Id = sp.Id,
                             PropertyType = _context.PropertyTypes.First(x => x.Id == sp.PropertyTypeId).Title,
                             PropertyStatus = _context.PropertyStatuses.First(x => x.Id == sp.PropertyStatusId).Title,
                             RoomCount = sp.RoomCount,
                             LivingRoomCount = sp.LivingRoomCount,
                             City = _context.Cities.First(x => x.Id == sp.CityId).Name,
                             District = _context.Districts.First(x => x.Id == sp.DistrictId).Name,
                             Neighborhood = _context.Neighborhoods.First(x => x.Id == sp.NeighborhoodId).Name,
                             Street = _context.Streets.First(x => x.Id == sp.StreetId).Name,
                             Price = sp.Price,
                             Description = sp.Description,
                             CreatedDate = cosp.CreatedDate,
                             UpdatedDate = cosp.UpdatedDate,
                             IsActive = cosp.IsActive
                         };
            return result.AsEnumerable();
        }
    }
}
