using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Client : BaseEntity
    {
        public uint CompanyId { get; set; }
        public string? FacebookUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        public string? About { get; set; }
        public string? SummaryInfo { get; set; }
        public string ViewName { get; set; }
        public string Dns { get; set; }
        public uint? LogoImgFileId { get; set; }
    }
}
