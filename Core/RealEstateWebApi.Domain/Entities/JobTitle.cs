﻿using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class JobTitle : BaseEntity
    {
        public uint ClientId { get; set; }
        public uint CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
