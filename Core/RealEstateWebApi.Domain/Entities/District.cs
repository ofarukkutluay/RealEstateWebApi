﻿using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class District : IEntity
    {
        public uint Id { get; set; }
        public int CityKey { get; set; }
        public string Name { get; set; }
        public int Key { get; set; }
    }
}
