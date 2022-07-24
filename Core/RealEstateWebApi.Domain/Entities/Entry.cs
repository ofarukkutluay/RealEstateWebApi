using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Entry : BaseEntity
    {
        public uint CustomerId { get; set; }
        public string Content { get; set; }
        public uint EntryTypeId { get; set; }
        public uint EntrySubTypeId { get; set; }
        public string? EntrySubTitle { get; set; }
        public uint UserId { get; set; }

        
    }
}
