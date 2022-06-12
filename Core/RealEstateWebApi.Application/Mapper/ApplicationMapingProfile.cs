using AutoMapper;
using RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Utilities.Mapper
{
    public class ApplicationMapingProfile : Profile
    {
        public ApplicationMapingProfile()
        {
            CreateMap<CreateAgentRequest,Agent>();
        }

    }
}
