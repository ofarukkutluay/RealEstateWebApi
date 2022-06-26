using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.BlogType.CreateBlogType
{
    public class CreateBlogTypeHandler : IRequestHandler<CreateBlogTypeRequest, CreateBlogTypeResponse>
    {
        private readonly IBlogTypeWriteRepository _blogTypeWriteRepository;
        private readonly IBlogTypeReadRepository _blogTypeReadRepository;
        private readonly IMapper _mapper;
        public CreateBlogTypeHandler(IBlogTypeWriteRepository blogTypeWriteRepository, IMapper mapper, IBlogTypeReadRepository blogTypeReadRepository)
        {
            _blogTypeWriteRepository = blogTypeWriteRepository;
            _mapper = mapper;
            _blogTypeReadRepository = blogTypeReadRepository;
        }

        public async Task<CreateBlogTypeResponse> Handle(CreateBlogTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.BlogType blogType = await _blogTypeReadRepository.GetSingleAsync(e => e.Title.ToLower() == request.Title.ToLower());
            if (blogType != null)
                return new CreateBlogTypeResponse()
                {
                    Message = "Benzer Blog tipi mevcut!",
                    Success = false
                };
            blogType = _mapper.Map<Domain.Entities.BlogType>(request);
            var result = await _blogTypeWriteRepository.AddAndSaveAsync(blogType);
            if (result == null)
                return new CreateBlogTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı.",
                    Success = false
                };

            return new CreateBlogTypeResponse()
            {
                Success = true,
                Message = $"{result.Id} id ile kayıt eklendi"
            };
        }
    }
}
