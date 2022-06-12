using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RealEstateWebApi.Application.Utilities.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration));
            services.AddAutoMapper(typeof(ApplicationMapingProfile));
        }
    }
}
