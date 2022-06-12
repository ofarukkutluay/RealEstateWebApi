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
    public class CompanyReadRepository : ReadRepository<Company, RealEstateWebApiDbContext> , ICompanyReadRepository
    {
        public CompanyReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
