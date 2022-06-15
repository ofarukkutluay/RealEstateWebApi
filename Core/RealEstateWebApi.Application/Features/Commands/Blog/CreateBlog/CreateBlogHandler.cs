using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Repositories;
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
           
            Domain.Entities.Blog blog = _mapper.Map<Domain.Entities.Blog>(request);

            await _blogWriteRepository.AddAndSaveAsync(blog);

            return new CreateBlogResponse()
            {
                Message = "Blog eklendi",
                Success = true
            };
        }
    }
}
