﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.ShortProperty.UpdateShortProperty
{
    public class UpdateShortPropertyRequest : IRequest<UpdateShortPropertyResponse>
    {
        public uint Id { get; set; }
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
        public bool IsActive { get; set; }
    }
}
