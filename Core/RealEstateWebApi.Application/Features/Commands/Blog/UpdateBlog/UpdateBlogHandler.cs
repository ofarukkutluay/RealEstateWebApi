using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Blog.UpdateBlog
{
    public class UpdateBlogHandler : IRequestHandler<UpdateBlogRequest, UpdateBlogResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IBlogWriteRepository _blogWriteRepository;
        public UpdateBlogHandler(IBlogReadRepository blogReadRepository, IBlogWriteRepository blogWriteRepository)
        {
            _blogReadRepository = blogReadRepository;
            _blogWriteRepository = blogWriteRepository;
        }


        public async Task<UpdateBlogResponse> Handle(UpdateBlogRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Blog blog = await _blogReadRepository.GetByIdAsync(request.BlogId);
            if (blog is null)
            {
                return new UpdateBlogResponse()
                {
                    Message = "Blog Bulunamadı.",
                    Success = false
                };
            }


            blog.Author = request.Author == default ? blog.Author : request.Author;
            blog.BlogTypeId = request.BlogTypeId == default ? blog.BlogTypeId : request.BlogTypeId;
            blog.Title = request.Title == default ? blog.Title : request.Title;
            blog.AgentId = request.AgentId == default ? blog.AgentId : request.AgentId;
            blog.Content = request.Content == default ? blog.Content : request.Content;
            blog.ClientId = request.ClientId == default ? blog.ClientId : request.ClientId;
            blog.CompanyId = request.CompanyId == default ? blog.CompanyId : request.CompanyId;
            blog.IsActive = request.IsActive == default ? blog.IsActive : request.IsActive;
            var result = await _blogWriteRepository.SaveAsync();
            if (result<0)
            {
                return new UpdateBlogResponse()
                {
                    Message = "Db güncellenirken hata alındı.",
                    Success = false
                };
            }
            return new UpdateBlogResponse()
            {
                Message = "Blog Güncellendi",
                Success = true
            };

        }
    }
}
