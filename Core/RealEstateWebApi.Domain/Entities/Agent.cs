﻿using RealEstateWebApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Domain.Entities
{
    public class Agent : BaseEntity
    {
        public uint CompanyId { get; set; }
        public uint JobTitleId { get; set; }
        public string? ViewMobileNumber { get; set; }
        public string? ViewPhoneNumber { get; set; }
        public string? Description { get; set; }
        public string? FacebookUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? YoutubeProfileUrl { get; set; }


    }
}
