﻿using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class PropertyStatus : BaseEntity
    {
        public string Title { get; set; }
        public uint PropertyCategoryId { get; set; }
    }
}
