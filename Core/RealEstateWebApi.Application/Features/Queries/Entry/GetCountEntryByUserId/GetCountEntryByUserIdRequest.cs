using System;
using MediatR;

namespace RealEstateWebApi.Application.Features.Queries.Entry.GetCountEntryByUserId
{
	public class GetCountEntryByUserIdRequest : IRequest<GetCountEntryByUserIdResponse>
	{
		public uint UserId { get; set; }
		public DateTime FirstDate { get; set; }
		public DateTime? LastDate { get; set; }
	}
}

