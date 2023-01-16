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
    public class CustomerSearchPropertyReadRepository : ReadRepository<CustomerSearchProperty, RealEstateWebApiDbContext>, ICustomerSearchPropertyReadRepository
    {
        public CustomerSearchPropertyReadRepository(RealEstateWebApiDbContext context) : base(context)
        {

        }

        public IEnumerable<CustomerSearchPropertyDto> GetAllCustomerSearchPropertyDtoByCustomerId(uint customerId)
        {
            var result = from cssp in Table
                         where cssp.CustomerId == customerId && cssp.IsDeleted == false
                         select new CustomerSearchPropertyDto
                         {
                             Id = cssp.Id,
                             CustomerId = cssp.CustomerId,
                             PropertyType = _context.PropertyTypes.First(x=>x.Id== cssp.PropertyTypeId).Title,
                             PropertyStatus = _context.PropertyStatuses.First(x => x.Id == cssp.PropertyStatusId).Title,
                             RoomCount = cssp.RoomCount,
                             LivingRoomCount = cssp.LivingRoomCount,
                             City = _context.Cities.First(x=>x.Id== cssp.CityId).Name,
                             District = _context.Districts.First(x=>x.Id== cssp.DistrictId).Name,
                             Neighborhood = _context.Neighborhoods.First(x=>x.Id== cssp.NeighborhoodId).Name,
                             Street = _context.Streets.First(x=>x.Id == cssp.StreetId).Name,
                             Price = cssp.Price,
                             Description = cssp.Description,
                             CreatedDate = cssp.CreatedDate,
                             UpdatedDate = cssp.UpdatedDate,
                             IsActive = cssp.IsActive
                         };
            return result.AsEnumerable();
        }
    }
}
