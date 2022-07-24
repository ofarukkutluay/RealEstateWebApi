using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.ShortProperty.CreateShortProperty
{
    public class CreateShortPropertyRequest : IRequest<CreateShortPropertyResponse>
    {
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
