using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Blog.GetAllBlogByClientId
{
    public class GetAllBlogByClientIdHandler : IRequestHandler<GetAllBlogByClientIdRequest, GetAllBlogByClientIdResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;

        public GetAllBlogByClientIdHandler(IBlogReadRepository blogReadRepository)
        {
            _blogReadRepository = blogReadRepository;
        }

        public Task<GetAllBlogByClientIdResponse> Handle(GetAllBlogByClientIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Blog> blogs = _blogReadRepository.GetWhere(e=>e.ClientId == request.ClientId);
            return Task.FromResult(new GetAllBlogByClientIdResponse()
            {
                Data = blogs,
                Message = $"{request.ClientId} clientdan tüm blog getirildi.",
                Success = true
            });
        }
    }
}
