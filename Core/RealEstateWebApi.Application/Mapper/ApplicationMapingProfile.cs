using AutoMapper;
using RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent;
using RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Application.Utilities.Mapper
{
    public class ApplicationMapingProfile : Profile
    {
        public ApplicationMapingProfile()
        {
            CreateMap<CreateAgentRequest,Agent>();
            CreateMap<CreateBlogRequest,Blog>();
        }

    }
}
