using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.CreateCustomerOwnedShortProperty
{
    public class CreateCustomerOwnedShortPropertyRequest : IRequest<CreateCustomerOwnedShortPropertyResponse>
    {
        public uint CustomerId { get; set; }
        public uint ShortPropertyId { get; set; }
        public uint? PropertyId { get; set; }
        public string? ShLink { get; set; }
        public string? EjLink { get; set; }
        public string? HeLink { get; set; }
        public string? OtherLink { get; set; }


        //short property
        public uint PropertyTypeId { get; set; }
        public uint PropertyStatusId { get; set; }
        public ushort? RoomCount { get; set; }
        public ushort? LivingRoomCount { get; set; }
        public uint CityId { get; set; }
        public uint DistrictId { get; set; }
        public uint? NeighborhoodId { get; set; }
        public uint? StreetId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
