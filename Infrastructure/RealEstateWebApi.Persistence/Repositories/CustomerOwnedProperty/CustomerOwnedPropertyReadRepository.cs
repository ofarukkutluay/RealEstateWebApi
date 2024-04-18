using MediatR;
using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.HelperEntities;
using RealEstateWebApi.Persistence.Contexts;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class CustomerOwnedPropertyReadRepository : ReadRepository<CustomerOwnedProperty, RealEstateWebApiDbContext>, ICustomerOwnedPropertyReadRepository
    {
        public CustomerOwnedPropertyReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }

        public IQueryable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDtoByCustomerId(uint customerId)
        {
            var result = from cosp in Table
                         where cosp.CustomerId == customerId
                         select new CustomerOwnedPropertyDto
                         {
                             Id = cosp.Id,
                             CustomerId = cosp.CustomerId,
                             Property = _context.Properties.FirstOrDefault(x=>x.Id == cosp.PropertyId),
                             OuterPropertyListing = _context.OuterPropertyListings.FirstOrDefault(x => x.Id == cosp.OuterPropertyListingId),
                             PropertyListingPhotos = _context.PropertyListingPhotos.Where(x=>x.OuterPropertyListingId == cosp.OuterPropertyListingId).AsEnumerable(),
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
            return result.AsNoTracking();
        }

        public IQueryable<CustomerOwnedPropertyDto> GetAllCustomerOwnedPropertyDto()
        {
            var result = (from cosp in Table
                          orderby cosp.CreatedDate descending
                         select new CustomerOwnedPropertyDto
                         {
                             Id = cosp.Id,
                             CustomerId = cosp.CustomerId,
                             Property = _context.Properties.FirstOrDefault(x => x.Id == cosp.PropertyId),
                             OuterPropertyListing = _context.OuterPropertyListings.FirstOrDefault(x => x.Id == cosp.OuterPropertyListingId),
                             PropertyListingPhotos = _context.PropertyListingPhotos.Where(x => x.OuterPropertyListingId == cosp.OuterPropertyListingId).AsEnumerable(),
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
                         }).AsNoTracking();
            return result;
        }
    }
}
