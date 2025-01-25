using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.BlogType.GetAllBlogType
{
    public class GetAllBlogTypeHandler : IRequestHandler<GetAllBlogTypeRequest, GetAllBlogTypeResponse>
    {
        private readonly IBlogTypeReadRepository _blogTypeReadRepository;

        public GetAllBlogTypeHandler(IBlogTypeReadRepository blogTypeReadRepository)
        {
            _blogTypeReadRepository = blogTypeReadRepository;
        }
        public async Task<GetAllBlogTypeResponse> Handle(GetAllBlogTypeRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.BlogType> blogTypes = _blogTypeReadRepository.GetAll(false).AsEnumerable();
            return await Task.FromResult( new GetAllBlogTypeResponse()
            {
                Data = blogTypes,
                Message = $"Tüm Blog Type leri datalar getirildi",
                Success = true
            });
        }
    }
}
