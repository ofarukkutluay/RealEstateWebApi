using AutoMapper;
using RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent;
using RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog;
using RealEstateWebApi.Application.Features.Commands.BlogType.CreateBlogType;
using RealEstateWebApi.Application.Features.Commands.Client.CreateClient;
using RealEstateWebApi.Application.Features.Commands.Company.CreateCompany;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Application.Utilities.Mapper
{
    public class ApplicationMapingProfile : Profile
    {
        public ApplicationMapingProfile()
        {
            CreateMap<CreateAgentRequest,Agent>();
            CreateMap<CreateBlogRequest,Blog>();
            CreateMap<CreateBlogTypeRequest,BlogType>();
            CreateMap<CreateClientRequest,Client>();
            CreateMap<CreateCompanyRequest, Company>();

        }

    }
}
