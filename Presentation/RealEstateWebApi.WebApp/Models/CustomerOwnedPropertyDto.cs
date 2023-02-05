﻿namespace RealEstateWebApi.WebApp.Models
{
    public class CustomerOwnedPropertyDto
    {
        public uint Id { get; set; }
        public uint CustomerId { get; set; }
        public PropertyListingDetail? PropertyListingDetail { get; set; }
        public uint? PropertyId { get; set; }
        public string? PropertyType { get; set; }
        public string? PropertyStatus { get; set; }
        public ushort? RoomCount { get; set; }
        public ushort? LivingRoomCount { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Neighborhood { get; set; }
        public string? Street { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public string? ShLink { get; set; }
        public string? EjLink { get; set; }
        public string? HeLink { get; set; }
        public string? OtherLink { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}