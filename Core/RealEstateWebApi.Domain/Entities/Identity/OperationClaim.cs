﻿using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities.Identity
{
    public class OperationClaim : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Alias { get; set; }
    }
}
