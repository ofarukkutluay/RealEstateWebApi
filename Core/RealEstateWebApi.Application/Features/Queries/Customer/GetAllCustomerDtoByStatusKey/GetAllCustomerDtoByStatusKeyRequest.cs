using System;
using MediatR;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByStatusKey
{
	public class GetAllCustomerDtoByStatusKeyRequest : Pagination, IRequest<GetAllCustomerDtoByStatusKeyResponse>
	{
		public uint AssignedUserId { get; set; }
		public string StatusKey { get; set; }
	}
}

