using System;
using MediatR;

namespace RealEstateWebApi.Application.Features.Queries.Entry.GetCountEntryByUserId
{
	public class GetCountEntryByUserIdRequest : IRequest<GetCountEntryByUserIdResponse>
	{
		public uint UserId { get; set; }
		public long FirstDate { get; set; }
		public long? LastDate { get; set; }
	}
}

