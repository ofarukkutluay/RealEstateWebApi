using System;
using AutoMapper;

namespace RealEstateWebApi.Infrastructure.Mapper
{
    public class InfrastructureMapingProfile : Profile
    {
        public InfrastructureMapingProfile()
        {
            CreateMap<ListingWebsiteScrapingLibrary.PropertyListingDetail, Domain.Entities.PropertyListingDetail>().ForMember(des=>des.Id,opt=>opt.MapFrom(x=>uint.Parse(x.Id)));
        }
    }
}

