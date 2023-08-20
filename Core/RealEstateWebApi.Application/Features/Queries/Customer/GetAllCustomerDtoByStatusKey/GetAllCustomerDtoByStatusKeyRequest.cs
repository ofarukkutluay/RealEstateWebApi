using System;
using MediatR;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByStatusKey
{
	public class GetAllCustomerDtoByStatusKeyRequest : IRequest<GetAllCustomerDtoByStatusKeyResponse>
	{
		public uint AssignedUserId { get; set; }
		public string StatusKey { get; set; }
	}
}

