using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Blog.GetBlogById
{
    public class GetBlogByIdHandler : IRequestHandler<GetBlogByIdRequest, GetBlogByIdResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;

        public GetBlogByIdHandler(IBlogReadRepository blogReadRepository)
        {
            _blogReadRepository = blogReadRepository;
        }

        public async Task<GetBlogByIdResponse> Handle(GetBlogByIdRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Blog blog = await _blogReadRepository.GetByIdAsync(request.BlogId);
            if (blog.IsDeleted)
                return new GetBlogByIdResponse()
                {
                    Message = "Data silinmiş",
                    Success = false,
                    Data = null
                };
            return new GetBlogByIdResponse()
            {
                Data = blog,
                Message = $"{request.BlogId} id li blog getirildi.",
                Success = true
            };
        }
    }
}
