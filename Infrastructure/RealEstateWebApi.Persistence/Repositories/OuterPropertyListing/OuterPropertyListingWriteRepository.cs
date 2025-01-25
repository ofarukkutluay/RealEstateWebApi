using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories;

public class OuterPropertyListingWriteRepository : WriteRepository<OuterPropertyListing, RealEstateWebApiDbContext, string>, IOuterPropertyListingWriteRepository
{
    public OuterPropertyListingWriteRepository(RealEstateWebApiDbContext context) : base(context)
    {
    }
}
