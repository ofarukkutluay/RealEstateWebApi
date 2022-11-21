using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class CustomerSearchShortPropertyReadRepository : ReadRepository<CustomerSearchShortProperty, RealEstateWebApiDbContext>, ICustomerSearchShortPropertyReadRepository
    {
        public CustomerSearchShortPropertyReadRepository(RealEstateWebApiDbContext context) : base(context)
        {

        }

        public IEnumerable<ShortPropertyDto> GetAllShortPropertyDtoByCustomerId(uint customerId)
        {
            var result = from cssp in Table
                         join sp in _context.ShortProperties on cssp.ShortPropertyId equals sp.Id
                         where cssp.CustomerId == customerId && cssp.IsDeleted == false
                         select new ShortPropertyDto
                         {
                             Id = sp.Id,
                             PropertyType = _context.PropertyTypes.First(x=>x.Id==sp.PropertyTypeId).Title,
                             PropertyStatus = _context.PropertyStatuses.First(x => x.Id == sp.PropertyStatusId).Title,
                             RoomCount = sp.RoomCount,
                             LivingRoomCount = sp.LivingRoomCount,
                             City = _context.Cities.First(x=>x.Id==sp.CityId).Name,
                             District = _context.Districts.First(x=>x.Id==sp.DistrictId).Name,
                             Neighborhood = _context.Neighborhoods.First(x=>x.Id==sp.NeighborhoodId).Name,
                             Street = _context.Streets.First(x=>x.Id == sp.StreetId).Name,
                             Price = sp.Price,
                             Description = sp.Description,
                             CreatedDate = cssp.CreatedDate,
                             UpdatedDate = cssp.UpdatedDate,
                             IsActive = cssp.IsActive
                         };
            return result.AsEnumerable();
        }
    }
}
