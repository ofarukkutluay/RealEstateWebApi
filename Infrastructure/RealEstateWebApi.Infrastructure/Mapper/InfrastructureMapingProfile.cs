using System;
using AutoMapper;

namespace RealEstateWebApi.Infrastructure.Mapper
{
    public class InfrastructureMapingProfile : Profile
    {
        public InfrastructureMapingProfile()
        {
            CreateMap<ListingWebsiteScrapingLibrary.Models.v3.PropertyListing, Domain.Entities.OuterPropertyListing>();           
        }
    }
}

