using AutoMapper;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent;
using RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog;
using RealEstateWebApi.Application.Features.Commands.BlogType.CreateBlogType;
using RealEstateWebApi.Application.Features.Commands.Client.CreateClient;
using RealEstateWebApi.Application.Features.Commands.Company.CreateCompany;
using RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedProperty.CreateCustomerOwnedProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.CreateCustomerSearchProperty;
using RealEstateWebApi.Application.Features.Commands.DeedStatus.CreateDeedStatus;
using RealEstateWebApi.Application.Features.Commands.Entry.CreateEntry;
using RealEstateWebApi.Application.Features.Commands.EntrySubType.CreateEntrySubType;
using RealEstateWebApi.Application.Features.Commands.EntryType.CreateEntryType;
using RealEstateWebApi.Application.Features.Commands.Front.CreateFront;
using RealEstateWebApi.Application.Features.Commands.HeatingType.CreateHeatingType;
using RealEstateWebApi.Application.Features.Commands.InternetType.CreateInternetType;
using RealEstateWebApi.Application.Features.Commands.JobTitle.CreateJobTitle;
using RealEstateWebApi.Application.Features.Commands.Property.CreateProperty;
using RealEstateWebApi.Application.Features.Commands.PropertyStatus.CreatePropertyStatus;
using RealEstateWebApi.Application.Features.Commands.PropertyType.CreatePropertyType;
using RealEstateWebApi.Application.Features.Commands.Reminder.CreateReminder;
using RealEstateWebApi.Application.Features.Commands.UserOperationClaim.CreateUserOperationClaim;
using RealEstateWebApi.Application.Features.Commands.UsingStatus.CreateUsingStatus;
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
            CreateMap<CreateFrontRequest, Front>();
            CreateMap<CreateHeatingTypeRequest, HeatingType>();
            CreateMap<CreateInternetTypeRequest, InternetType>();
            CreateMap<CreatePropertyStatusRequest, PropertyStatus>();
            CreateMap<CreatePropertyTypeRequest, PropertyType>();
            CreateMap<CreateUsingStatusRequest, UsingStatus>();
            CreateMap<CreateCustomerRequest,Customer>().ForMember(dest=>dest.FullName,opt=>opt.MapFrom(x=>$"{x.FirstName} {x.LastName}"));
            CreateMap<CreateCustomerSearchPropertyRequest, CustomerSearchProperty>();
            CreateMap<CreateCustomerOwnedPropertyRequest, CustomerOwnedProperty>();
            CreateMap<CreateCustomerSearchPropertyRequest, ShortProperty>();
            CreateMap<CreateCustomerOwnedPropertyRequest, ShortProperty>();
            CreateMap<CreateEntryRequest,Entry>();
            CreateMap<CreateEntryTypeRequest, EntryType>();
            CreateMap<CreateEntrySubTypeRequest, EntrySubType>();
            CreateMap<CreateReminderRequest, Reminder>();

            CreateMap<CreatePropertyRequest, Property>();

            CreateMap<User, UserDto>();



        }

    }
}
