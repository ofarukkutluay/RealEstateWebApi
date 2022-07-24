using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer, RealEstateWebApiDbContext>, ICustomerReadRepository
    {
        public CustomerReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
