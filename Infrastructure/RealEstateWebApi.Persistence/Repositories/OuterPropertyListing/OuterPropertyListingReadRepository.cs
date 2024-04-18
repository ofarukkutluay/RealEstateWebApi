using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories;

public class OuterPropertyListingReadRepository : ReadRepository<OuterPropertyListing, RealEstateWebApiDbContext, string>, IOuterPropertyListingReadRepository
{
    public OuterPropertyListingReadRepository(RealEstateWebApiDbContext context) : base(context)
    {
    }
}
