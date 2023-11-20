using System;
using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Extensions;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDtoByWhere
{
    public class GetAllCustomerOwnedPropertyDtoByWhereHandler : IRequestHandler<GetAllCustomerOwnedPropertyDtoByWhereRequest, GetAllCustomerOwnedPropertyDtoByWhereResponse>
    {
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedPropertyReadRepository;
        private readonly ICityReadRepository _cityReadRepository;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly INeighborhoodReadRepository _neighborhoodReadRepository;

        public GetAllCustomerOwnedPropertyDtoByWhereHandler(ICustomerOwnedPropertyReadRepository customerOwnedPropertyReadRepository, ICityReadRepository cityReadRepository, IDistrictReadRepository districtReadRepository, INeighborhoodReadRepository neighborhoodReadRepository)
        {
            _customerOwnedPropertyReadRepository = customerOwnedPropertyReadRepository;
            _cityReadRepository = cityReadRepository;
            _districtReadRepository = districtReadRepository;
            _neighborhoodReadRepository = neighborhoodReadRepository;
        }

        public async Task<GetAllCustomerOwnedPropertyDtoByWhereResponse> Handle(GetAllCustomerOwnedPropertyDtoByWhereRequest request, CancellationToken cancellationToken)
        {
            string city;
            string district;
            string neighborhood;
            if (request.CityId != null)
                city = ( await _cityReadRepository.GetByIdAsync((uint)request.CityId)).Name.Trim();
            if (request.DistrictId != null)
                district = ( await _districtReadRepository.GetByIdAsync((uint)request.DistrictId)).Name.Trim();
            if (request.NeighborhoodId != null)
                neighborhood = (await _neighborhoodReadRepository.GetByIdAsync((uint)request.NeighborhoodId)).Name.Trim();

            IQueryable<CustomerOwnedPropertyDto> ownedPropertyDtos = _customerOwnedPropertyReadRepository.GetAllCustomerOwnedPropertyDto();
                //.Where(request.CityId != default, cosp => cosp.City == city );

            return new GetAllCustomerOwnedPropertyDtoByWhereResponse();
        }


    }
}

