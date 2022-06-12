using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Message : BaseEntity
    {
        public uint ClientId { get; set; }
        public uint CompanyId { get; set; }
        public string SenderName { get; set; }
        public string? SenderEmail { get; set; }
        public string SenderMobile { get; set; }
        public string Content { get; set; }

    }
}
