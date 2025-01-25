using System;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class ReminderWriteRepository : WriteRepository<Reminder, RealEstateWebApiDbContext>, IReminderWriteRepository
    {
        public ReminderWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}

