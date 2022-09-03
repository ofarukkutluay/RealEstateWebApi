namespace RealEstateWebApi.WebApp.Models
{
    public class ShortProperty
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

        //app'e özel customerId eklendi
        public uint CustomerId { get; set; }
    }
}
