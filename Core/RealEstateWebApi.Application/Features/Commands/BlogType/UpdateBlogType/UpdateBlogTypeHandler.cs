using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.BlogType.UpdateBlogType
{
    public class UpdateBlogTypeHandler : IRequestHandler<UpdateBlogTypeRequest, UpdateBlogTypeResponse>
    {
        private readonly IBlogTypeReadRepository _blogTypeReadRepository;
        private readonly IBlogTypeWriteRepository _blogTypeWriteRepository;

        public UpdateBlogTypeHandler(IBlogTypeReadRepository blogTypeReadRepository, IBlogTypeWriteRepository blogTypeWriteRepository)
        {
            _blogTypeReadRepository = blogTypeReadRepository;
            _blogTypeWriteRepository = blogTypeWriteRepository;
        }

        public async Task<UpdateBlogTypeResponse> Handle(UpdateBlogTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.BlogType blogType = await _blogTypeReadRepository.GetByIdAsync(request.Id);
            if(blogType is null)
                return new UpdateBlogTypeResponse()
                {
                    Message = "Blog Tipi bulunamadı.",
                    Success = false,
                };
            blogType.Title = request.Title;
            blogType.ClientId = request.ClientId;
            blogType.IsActive = request.IsActive;
            var result = await _blogTypeWriteRepository.SaveAsync();
            if(result <= 0)
                return new UpdateBlogTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new UpdateBlogTypeResponse()
            {
                Message = $"{request.Id} id Blog tipi güncellendi",
                Success = true
            };
        }
    }
}
