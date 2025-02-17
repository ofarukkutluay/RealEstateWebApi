using System;
using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class ReminderReadRepository : ReadRepository<Reminder, RealEstateWebApiDbContext>, IReminderReadRepository
    {
        public ReminderReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }

        public IQueryable<ReminderDto> GetAllReminderDtoByCustomerId(uint customerId)
        {
            var result = from rm in Table
                         join c in _context.Customers on rm.CustomerId equals c.Id
                         into temp
                         from c in temp.DefaultIfEmpty()
                         where rm.CustomerId == customerId
                         orderby rm.ReminderDate ascending
                         select new ReminderDto()
                         {
                             Id = rm.Id,
                             CustomerId = rm.CustomerId,
                             UserId = rm.UserId,
                             EntryId = rm.EntryId,
                             ReminderDate = rm.ReminderDate,
                             Description = rm.Description,
                             CreatedDate = rm.CreatedDate,
                             UpdatedDate = rm.UpdatedDate,
                             IsActive = rm.IsActive,
                             CustomerName = c.FullName
                         };
            return result.AsNoTracking();
        }

        public IQueryable<ReminderDto> GetReminderDtosByUserId(uint userId)
        {
            var result = from rm in Table
                         join c in _context.Customers on rm.CustomerId equals c.Id
                         into temp
                         from c in temp.DefaultIfEmpty()
                         where rm.UserId == userId
                         orderby rm.ReminderDate ascending
                         select new ReminderDto()
                         {
                             Id = rm.Id,
                             CustomerId = rm.CustomerId,
                             UserId = rm.UserId,
                             EntryId = rm.EntryId,
                             ReminderDate = rm.ReminderDate,
                             Description = rm.Description,
                             CreatedDate = rm.CreatedDate,
                             UpdatedDate = rm.UpdatedDate,
                             IsActive = rm.IsActive,
                             CustomerName = c.FullName
                         };
            return result.AsNoTracking();
        }
    }
}

