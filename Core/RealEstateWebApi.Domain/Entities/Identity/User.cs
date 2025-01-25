using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities.Identity
{
    public class User : BaseEntity
    {
        public long? CitizenNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        public string MobileNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public byte[] PassHash { get; set; }
        public byte[] PassSalt { get; set; }
        public uint? ProfileImgFileId { get; set; }


    }
}
