using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Validators.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog
{
    public class CreateBlogHandler : IRequestHandler<CreateBlogRequest, CreateBlogResponse>
    {
        private readonly IBlogWriteRepository _blogWriteRepository;
        private readonly IMapper _mapper;

        public CreateBlogHandler(IBlogWriteRepository blogWriteRepository, IMapper mapper)
        {
            _blogWriteRepository = blogWriteRepository;
            _mapper = mapper;

        }

        public async Task<CreateBlogResponse> Handle(CreateBlogRequest request, CancellationToken cancellationToken)
        {

            CreateBlogValidator validator = new CreateBlogValidator();
            var validResult = await validator.ValidateAsync(request);
            if (!validResult.IsValid)
            {
                return new CreateBlogResponse()
                {
                    Message = validResult.ToString("\n"),
                    Success = false
                };
            }

            Domain.Entities.Blog blog = _mapper.Map<Domain.Entities.Blog>(request);
            var result = await _blogWriteRepository.AddAndSaveAsync(blog);
            if(result is null)
            {
                return new CreateBlogResponse()
                {
                    Message = "Dbye kayıt edilirken bir hata ile karşılaşıldı.",
                    Success = false
                };
            }
            return new CreateBlogResponse()
            {
                Message = $"{result.Id} id ile Blog eklendi",
                Success = true
            };
        }
    }
}
