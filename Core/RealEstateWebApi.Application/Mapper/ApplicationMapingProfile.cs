using AutoMapper;
using RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent;
using RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog;
using RealEstateWebApi.Application.Features.Commands.BlogType.CreateBlogType;
using RealEstateWebApi.Application.Features.Commands.Client.CreateClient;
using RealEstateWebApi.Application.Features.Commands.Company.CreateCompany;
using RealEstateWebApi.Application.Features.Commands.DeedStatus.CreateDeedStatus;
using RealEstateWebApi.Application.Features.Commands.JobTitle.CreateJobTitle;
using RealEstateWebApi.Application.Features.Commands.UserOperationClaim.CreateUserOperationClaim;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Domain.Entities.Identity;

namespace RealEstateWebApi.Application.Utilities.Mapper
{
    public class ApplicationMapingProfile : Profile
    {
        public ApplicationMapingProfile()
        {
            CreateMap<CreateAgentRequest,Agent>().ForMember(dest => dest.Id,opt=>opt.MapFrom(x=>x.UserId));
            CreateMap<CreateBlogRequest,Blog>();
            CreateMap<CreateBlogTypeRequest,BlogType>();
            CreateMap<CreateClientRequest,Client>();
            CreateMap<CreateCompanyRequest, Company>();
            CreateMap<CreateJobTitleRequest,JobTitle>();
            CreateMap<CreateDeedStatusRequest,DeedStatus>();
            CreateMap<CreateUserOperationClaimRequest,UserOperationClaim>();

        }

    }
}
