﻿using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Repositories
{
    public interface IUserReadRepository : IReadRepository<User>
    {
        IEnumerable<OperationClaim> GetClaims(User user);
    }
}