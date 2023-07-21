using System;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Application.Repositories
{
	public interface IReminderReadRepository : IReadRepository<Reminder>
	{
		IEnumerable<ReminderDto> GetReminderDtosByUserId(uint userId);
	}
}

