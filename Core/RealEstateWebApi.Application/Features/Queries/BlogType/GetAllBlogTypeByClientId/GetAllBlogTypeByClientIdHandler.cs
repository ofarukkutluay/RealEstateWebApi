using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.BlogType.GetAllBlogTypeByClientId
{
    public class GetAllBlogTypeByClientIdHandler : IRequestHandler<GetAllBlogTypeByClientIdRequest, GetAllBlogTypeByClientIdResponse>
    {
        private readonly IBlogTypeReadRepository _blogTypeReadRepository;

        public GetAllBlogTypeByClientIdHandler(IBlogTypeReadRepository blogTypeReadRepository)
        {
            _blogTypeReadRepository = blogTypeReadRepository;
        }
        public async Task<GetAllBlogTypeByClientIdResponse> Handle(GetAllBlogTypeByClientIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.BlogType> blogTypes = _blogTypeReadRepository.GetWhere(e=>e.ClientId == request.ClientId);
            return new GetAllBlogTypeByClientIdResponse()
            {
                Data = blogTypes,
                Message = $"{request.ClientId} client id ye ait datalar getirildi",
                Success = true
            };
        }
    }
}
