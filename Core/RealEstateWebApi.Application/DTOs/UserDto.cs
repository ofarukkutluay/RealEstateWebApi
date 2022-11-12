using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.DTOs
{
    public class UserDto
    {
        public uint Id { get; set; }
        public long? CitizenNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        public string MobileNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfileImgFilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<OperationClaim> OperationClaims { get; set; }

    }
}
