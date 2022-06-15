using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Blog.DeleteBlog
{
    public class DeleteBlogHandler : IRequestHandler<DeleteBlogRequest, DeleteBlogResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IBlogWriteRepository _blogWriteRepository;
        public DeleteBlogHandler(IBlogReadRepository blogReadRepository, IBlogWriteRepository blogWriteRepository)
        {
            _blogReadRepository = blogReadRepository;
            _blogWriteRepository = blogWriteRepository;
        }

        public async Task<DeleteBlogResponse> Handle(DeleteBlogRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Blog blog = await _blogReadRepository.GetByIdAsync(request.BlogId);
            if(blog is null)
                return new DeleteBlogResponse()
                {
                    Message = "Blog bulunamadı.",
                    Success = false
                };

            blog.IsActive = false;
            var result = await _blogWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteBlogResponse()
                {
                    Message = "Db güncellenirken hata alındı",
                    Success = false
                };
            return new DeleteBlogResponse()
            {
                Message = "Blog Güncellendi",
                Success = true
            };
        }
    }
}
