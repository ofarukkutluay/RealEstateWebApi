using System;
using MediatR;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDtoByWhere
{
	public class GetAllCustomerOwnedPropertyDtoByWhereRequest : Pagination, IRequest<GetAllCustomerOwnedPropertyDtoByWhereResponse>
	{
        public uint? PropertyTypeId { get; set; }
        public uint? PropertyStatusId { get; set; }
        public uint? CityId { get; set; }
        public uint? DistrictId { get; set; }
        public uint? NeighborhoodId { get; set; }
    }
}

