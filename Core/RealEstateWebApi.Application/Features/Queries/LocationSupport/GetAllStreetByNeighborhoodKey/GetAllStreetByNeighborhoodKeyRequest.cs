using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllStreetByNeighborhoodKey
{
    public class GetAllStreetByNeighborhoodKeyRequest : IRequest<GetAllStreetByNeighborhoodKeyResponse>
    {
        public int NeighborhoodKey { get; set; }

    }
}
