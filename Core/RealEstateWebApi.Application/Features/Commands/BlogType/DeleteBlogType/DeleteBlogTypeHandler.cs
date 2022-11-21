using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.BlogType.DeleteBlogType
{
    public class DeleteBlogTypeHandler : IRequestHandler<DeleteBlogTypeRequest, DeleteBlogTypeResponse>
    {
        private readonly IBlogTypeReadRepository _blogTypeReadRepository;
        private readonly IBlogTypeWriteRepository _blogTypeWriteRepository;

        public DeleteBlogTypeHandler(IBlogTypeReadRepository blogTypeReadRepository, IBlogTypeWriteRepository blogTypeWriteRepository)
        {
            _blogTypeReadRepository = blogTypeReadRepository;
            _blogTypeWriteRepository = blogTypeWriteRepository;
        }
        public async Task<DeleteBlogTypeResponse> Handle(DeleteBlogTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.BlogType blogType = await _blogTypeReadRepository.GetByIdAsync(request.Id);
            if (blogType is null)
                return new DeleteBlogTypeResponse()
                {
                    Message = "Blog Tipi bulunamadı.",
                    Success = false,
                };

            blogType.IsDeleted = true;
            var result = await _blogTypeWriteRepository.SaveAsync();
            if(result<=0)
                return new DeleteBlogTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new DeleteBlogTypeResponse()
            {
                Message = $"{request.Id} id Blog tipi silindi",
                Success = true
            };
        }
    }
}
