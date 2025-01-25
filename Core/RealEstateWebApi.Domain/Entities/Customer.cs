using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string? MobileNumber2 { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumber2 { get; set; }
        public string? Email { get; set; }
        public uint CityId { get; set; }
        public uint DistrictId { get; set; }
        public uint? NeighborhoodId { get; set; }
        public string? StatusKey { get; set; } = "YENI";

        [DataType(DataType.Date)]
        public DateTime? BirthDay { get; set; }
        public long? CitizenNumber { get; set; }
        public uint RegisterUserId { get; set; }
        public uint AssignedUserId { get; set; }


    }
}
