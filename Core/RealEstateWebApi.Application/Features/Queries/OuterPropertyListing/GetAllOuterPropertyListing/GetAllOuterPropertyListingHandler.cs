using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.OuterPropertyListing.GetAllOuterPropertyListing
{
    public class GetAllOuterPropertyListingHandler : IRequestHandler<GetAllOuterPropertyListingRequest, GetAllOuterPropertyListingResponse>
    {
        private readonly IOuterPropertyListingReadRepository _outerPropertyListingReadRepository;

        public GetAllOuterPropertyListingHandler(IOuterPropertyListingReadRepository outerPropertyListingReadRepository)
        {
            _outerPropertyListingReadRepository = outerPropertyListingReadRepository;
        }

        public async Task<GetAllOuterPropertyListingResponse> Handle(GetAllOuterPropertyListingRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.OuterPropertyListing> outerPropertyListinges = _outerPropertyListingReadRepository.GetAll(false).OrderByDescending(e=>e.CreatedDate);
            return await Task.FromResult(new GetAllOuterPropertyListingResponse()
            {
                Message = $"{outerPropertyListinges.Count()} adet data getirildi",
                Success = true,
                TotalDataCount = outerPropertyListinges.Count(),
                Data = outerPropertyListinges
            });
        }
    }
}
