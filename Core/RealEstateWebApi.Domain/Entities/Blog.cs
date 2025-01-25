using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public uint ClientId { get; set; }
        public uint CompanyId { get; set; }
        public uint AgentId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public uint? BlogPageImgFileId { get; set; }
        public string Content { get; set; }
        public uint BlogTypeId { get; set; }

    }
}
