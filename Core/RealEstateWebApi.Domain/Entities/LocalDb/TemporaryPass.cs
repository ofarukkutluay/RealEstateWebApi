using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities.LocalDb
{
    public class TemporaryPass
    {
        public uint LoginUserId { get; set; }
        public string Content { get; set; }
    }
}
