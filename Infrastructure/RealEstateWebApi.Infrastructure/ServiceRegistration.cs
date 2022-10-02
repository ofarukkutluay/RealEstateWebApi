using Microsoft.Extensions.DependencyInjection;
using RealEstateWebApi.Application.Abstractions.Services;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Abstractions.Token;
using RealEstateWebApi.Infrastructure.Services;
using RealEstateWebApi.Infrastructure.Services.Storage;
using RealEstateWebApi.Infrastructure.Services.Token;

namespace RealEstateWebApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IStorageService, StorageService>();
            services.AddScoped<ITokenHandler, JwtHandler>();
            services.AddScoped<IMailService,MailService>();
        }
        public static void AddStorage<T>(this IServiceCollection services) where T : Storage, IStorage
        {
            services.AddScoped<IStorage, T>();
        }

    }
}