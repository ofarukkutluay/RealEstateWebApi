using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public uint TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public ushort StartingYear { get; set; }
        public string Address { get; set; }

    }
}
