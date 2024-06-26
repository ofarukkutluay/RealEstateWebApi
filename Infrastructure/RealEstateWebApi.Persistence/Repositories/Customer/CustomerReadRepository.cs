﻿using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer, RealEstateWebApiDbContext>, ICustomerReadRepository
    {
        public CustomerReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }

        public IQueryable<CustomerDto> GetAllDto(){
            var result = from c in Table
                        join city in _context.Cities on c.CityId equals city.Id
                        join dist in _context.Districts on c.DistrictId equals dist.Id
                        join reguser in _context.Users on c.RegisterUserId equals reguser.Id
                        join assinguser in _context.Users on c.AssignedUserId equals assinguser.Id
                        orderby c.Id descending
                        select new CustomerDto{
                            Id = c.Id,
                            FirstName = c.FirstName,
                            LastName = c.LastName,
                            FullName = c.FullName,
                            MobileNumber = c.MobileNumber,
                            MobileNumber2 = c.MobileNumber2,
                            PhoneNumber = c.PhoneNumber,
                            PhoneNumber2 = c.PhoneNumber2,
                            Email = c.Email,
                            CityId = c.CityId,
                            City = city.Name,
                            DistrictId = c.DistrictId,
                            District = dist.Name,
                            NeighborhoodId = c.NeighborhoodId,
                            Neighborhood = (from neigh in _context.Neighborhoods where c.NeighborhoodId == neigh.Id select neigh).First().Name,
                            BirthDay = c.BirthDay,
                            CitizenNumber = c.CitizenNumber,
                            StatusKey =c.StatusKey,
                            Status = _context.EntrySubTypes.FirstOrDefault(x=>x.Key == c.StatusKey).Title,
                            RegisterUser = $"{reguser.FirstName} {reguser.LastName}",
                            AssignedUser = $"{assinguser.FirstName} {assinguser.LastName}",
                            RegisterUserId = c.RegisterUserId,
                            AssignedUserId = c.AssignedUserId,
                            CreatedDate = c.CreatedDate.ToLocalTime(),
                            UpdatedDate = c.UpdatedDate != null ? c.UpdatedDate.Value.ToLocalTime() : null ,
                            IsActive = c.IsActive
                        };
            return result.AsNoTracking();

        }

        public IQueryable<CustomerDto> GetAllDtoByAssignedUserId(uint assignedUserId)
        {
            var result = from c in Table
                         join city in _context.Cities on c.CityId equals city.Id
                         join dist in _context.Districts on c.DistrictId equals dist.Id
                         join reguser in _context.Users on c.RegisterUserId equals reguser.Id
                         join assinguser in _context.Users on c.AssignedUserId equals assinguser.Id
                         where c.AssignedUserId == assignedUserId
                         orderby c.Id descending
                         select new CustomerDto
                         {
                             Id = c.Id,
                             FirstName = c.FirstName,
                             LastName = c.LastName,
                             FullName = c.FullName,
                             MobileNumber = c.MobileNumber,
                             MobileNumber2 = c.MobileNumber2,
                             PhoneNumber = c.PhoneNumber,
                             PhoneNumber2 = c.PhoneNumber2,
                             Email = c.Email,
                             City = city.Name,
                             District = dist.Name,
                             Neighborhood = (from neigh in _context.Neighborhoods where c.NeighborhoodId == neigh.Id select neigh).First().Name,
                             BirthDay = c.BirthDay,
                             CitizenNumber = c.CitizenNumber,
                             StatusKey = c.StatusKey,
                             Status = _context.EntrySubTypes.FirstOrDefault(x => x.Key == c.StatusKey).Title,
                             RegisterUser = $"{reguser.FirstName} {reguser.LastName}",
                             AssignedUser = $"{assinguser.FirstName} {assinguser.LastName}",
                             RegisterUserId = c.RegisterUserId,
                             AssignedUserId = c.AssignedUserId,
                             CreatedDate = c.CreatedDate.ToLocalTime(),
                             UpdatedDate = c.UpdatedDate != null ? c.UpdatedDate.Value.ToLocalTime() : null,
                             IsActive = c.IsActive
                         };
            return result.AsNoTracking();
        }

        public IQueryable<CustomerDto> GetAllDtoByStatusKey(string statusKey, uint assignedUserId)
        {
            var result = from c in Table
                         join city in _context.Cities on c.CityId equals city.Id
                         join dist in _context.Districts on c.DistrictId equals dist.Id
                         join reguser in _context.Users on c.RegisterUserId equals reguser.Id
                         join assinguser in _context.Users on c.AssignedUserId equals assinguser.Id
                         where c.AssignedUserId == assignedUserId && c.StatusKey == statusKey
                         orderby c.Id descending
                         select new CustomerDto
                         {
                             Id = c.Id,
                             FirstName = c.FirstName,
                             LastName = c.LastName,
                             FullName = c.FullName,
                             MobileNumber = c.MobileNumber,
                             MobileNumber2 = c.MobileNumber2,
                             PhoneNumber = c.PhoneNumber,
                             PhoneNumber2 = c.PhoneNumber2,
                             Email = c.Email,
                             City = city.Name,
                             District = dist.Name,
                             Neighborhood = (from neigh in _context.Neighborhoods where c.NeighborhoodId == neigh.Id select neigh).First().Name,
                             BirthDay = c.BirthDay,
                             CitizenNumber = c.CitizenNumber,
                             StatusKey = c.StatusKey,
                             Status = _context.EntrySubTypes.FirstOrDefault(x => x.Key == c.StatusKey).Title,
                             RegisterUser = $"{reguser.FirstName} {reguser.LastName}",
                             AssignedUser = $"{assinguser.FirstName} {assinguser.LastName}",
                             RegisterUserId = c.RegisterUserId,
                             AssignedUserId = c.AssignedUserId,
                             CreatedDate = c.CreatedDate.ToLocalTime(),
                             UpdatedDate = c.UpdatedDate != null ? c.UpdatedDate.Value.ToLocalTime() : null,
                             IsActive = c.IsActive
                         };
            return result.AsNoTracking();
        }

        public CustomerDto GetDtoById (uint id){
            var result = from c in Table
                        join city in _context.Cities on c.CityId equals city.Id
                        join dist in _context.Districts on c.DistrictId equals dist.Id
                        join reguser in _context.Users on c.RegisterUserId equals reguser.Id
                        join assinguser in _context.Users on c.AssignedUserId equals assinguser.Id
                        where c.Id == id 
                        select new CustomerDto{
                            Id = c.Id,
                            FirstName = c.FirstName,
                            LastName = c.LastName,
                            FullName = c.FullName,
                            MobileNumber = c.MobileNumber,
                            MobileNumber2 = c.MobileNumber2,
                            PhoneNumber = c.PhoneNumber,
                            PhoneNumber2 = c.PhoneNumber2,
                            Email = c.Email,
                            City = city.Name,
                            District = dist.Name,
                            Neighborhood = (from neigh in _context.Neighborhoods where c.NeighborhoodId == neigh.Id select neigh).First().Name,
                            BirthDay = c.BirthDay,
                            CitizenNumber = c.CitizenNumber,
                            StatusKey = c.StatusKey,
                            Status = _context.EntrySubTypes.FirstOrDefault(x => x.Key == c.StatusKey).Title,
                            RegisterUser = $"{reguser.FirstName} {reguser.LastName}",
                            AssignedUser = $"{assinguser.FirstName} {assinguser.LastName}",
                            RegisterUserId = c.RegisterUserId,
                            AssignedUserId = c.AssignedUserId,
                            CreatedDate = c.CreatedDate.ToLocalTime(),
                            UpdatedDate = c.UpdatedDate != null ? c.UpdatedDate.Value.ToLocalTime() : null,
                            IsActive = c.IsActive
                        };
            return result.AsNoTracking().First();

        }
    }
}
