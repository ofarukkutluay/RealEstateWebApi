using System;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Application.Repositories
{
	public interface IReminderReadRepository : IReadRepository<Reminder>
	{
        IQueryable<ReminderDto> GetAllReminderDtoByCustomerId(uint customerId);
        IQueryable<ReminderDto> GetReminderDtosByUserId(uint userId);
	}
}

