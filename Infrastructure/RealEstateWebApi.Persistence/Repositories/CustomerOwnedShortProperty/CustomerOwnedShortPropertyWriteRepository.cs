using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class CustomerOwnedShortPropertyWriteRepository : WriteRepository<CustomerOwnedShortProperty, RealEstateWebApiDbContext>, ICustomerOwnedShortPropertyWriteRepository
    {
        public CustomerOwnedShortPropertyWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
