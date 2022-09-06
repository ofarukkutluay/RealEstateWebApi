﻿using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface ICustomerSearchShortPropertyReadRepository : IReadRepository<CustomerSearchShortProperty>
    {
        IEnumerable<ShortPropertyDto> GetAllShortPropertyDtoByCustomerId(uint customerId);
    }
}