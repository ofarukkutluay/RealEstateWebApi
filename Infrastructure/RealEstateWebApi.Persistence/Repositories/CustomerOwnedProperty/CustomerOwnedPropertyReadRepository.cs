using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class CustomerOwnedPropertyReadRepository : ReadRepository<CustomerOwnedProperty, RealEstateWebApiDbContext>, ICustomerOwnedPropertyReadRepository
    {
        public CustomerOwnedPropertyReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }

        public IEnumerable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDtoByCustomerId(uint customerId)
        {
            var result = from cosp in Table
                         where cosp.CustomerId == customerId && cosp.IsDeleted == false
                         select new CustomerOwnedPropertyDto
                         {
                             Id = cosp.Id,
                             CustomerId = cosp.CustomerId,
                             Property = _context.Properties.FirstOrDefault(x=>x.Id == cosp.PropertyId),
                             PropertyListingDetail = _context.PropertyListingDetails.FirstOrDefault(x => x.Id == cosp.PropertyListingDetailId),
                             PropertyListingPhotos = _context.PropertyListingPhotos.Where(x=>x.PropertyListingDetailId == cosp.PropertyListingDetailId).AsEnumerable(),
                             PropertyType = _context.PropertyTypes.First(x => x.Id == cosp.PropertyTypeId).Title,
                             PropertyStatus = _context.PropertyStatuses.First(x => x.Id == cosp.PropertyStatusId).Title,
                             RoomCount = cosp.RoomCount,
                             LivingRoomCount = cosp.LivingRoomCount,
                             City = _context.Cities.First(x => x.Id == cosp.CityId).Name,
                             District = _context.Districts.First(x => x.Id == cosp.DistrictId).Name,
                             Neighborhood = _context.Neighborhoods.First(x => x.Id == cosp.NeighborhoodId).Name,
                             Street = _context.Streets.First(x => x.Id == cosp.StreetId).Name,
                             Price = cosp.Price,
                             Description = cosp.Description,
                             ShLink = cosp.ShLink,
                             HeLink = cosp.HeLink,
                             EjLink = cosp.EjLink,
                             OtherLink = cosp.OtherLink,
                             CreatedDate = cosp.CreatedDate,
                             UpdatedDate = cosp.UpdatedDate,
                             IsActive = cosp.IsActive
                         };
            return result.AsEnumerable();
        }

        public IEnumerable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDto()
        {
            var result = from cosp in Table
                         where cosp.IsDeleted == false
                         select new CustomerOwnedPropertyDto
                         {
                             Id = cosp.Id,
                             CustomerId = cosp.CustomerId,
                             Property = _context.Properties.FirstOrDefault(x => x.Id == cosp.PropertyId),
                             PropertyListingDetail = _context.PropertyListingDetails.FirstOrDefault(x => x.Id == cosp.PropertyListingDetailId),
                             PropertyListingPhotos = _context.PropertyListingPhotos.Where(x => x.PropertyListingDetailId == cosp.PropertyListingDetailId).AsEnumerable(),
                             PropertyType = _context.PropertyTypes.First(x => x.Id == cosp.PropertyTypeId).Title,
                             PropertyStatus = _context.PropertyStatuses.First(x => x.Id == cosp.PropertyStatusId).Title,
                             RoomCount = cosp.RoomCount,
                             LivingRoomCount = cosp.LivingRoomCount,
                             City = _context.Cities.First(x => x.Id == cosp.CityId).Name,
                             District = _context.Districts.First(x => x.Id == cosp.DistrictId).Name,
                             Neighborhood = _context.Neighborhoods.First(x => x.Id == cosp.NeighborhoodId).Name,
                             Street = _context.Streets.First(x => x.Id == cosp.StreetId).Name,
                             Price = cosp.Price,
                             Description = cosp.Description,
                             ShLink = cosp.ShLink,
                             HeLink = cosp.HeLink,
                             EjLink = cosp.EjLink,
                             OtherLink = cosp.OtherLink,
                             CreatedDate = cosp.CreatedDate,
                             UpdatedDate = cosp.UpdatedDate,
                             IsActive = cosp.IsActive
                         };
            return result.AsEnumerable();
        }
    }
}
