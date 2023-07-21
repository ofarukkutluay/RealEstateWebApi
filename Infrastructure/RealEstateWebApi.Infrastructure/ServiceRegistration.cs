using Microsoft.Extensions.DependencyInjection;
using RealEstateWebApi.Application.Abstractions.Scraping;
using RealEstateWebApi.Application.Abstractions.Security;
using RealEstateWebApi.Application.Abstractions.Services;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Abstractions.Token;
using RealEstateWebApi.Infrastructure.Mapper;
using RealEstateWebApi.Infrastructure.Services;
using RealEstateWebApi.Infrastructure.Services.Scraping;
using RealEstateWebApi.Infrastructure.Services.Security;
using RealEstateWebApi.Infrastructure.Services.Storage;
using RealEstateWebApi.Infrastructure.Services.Token;
using ListingWebsiteScrapingLibrary;

namespace RealEstateWebApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IStorageService, StorageService>();
            services.AddScoped<ITokenHandler, JwtHandler>();
            services.AddSingleton<IMailService,MailService>();
            services.AddScoped<ITemporaryPassService, TemporaryPassService>();
            services.AddScoped<IShScrapingService, ShScrapingService>();
            services.AddAutoMapper(typeof(InfrastructureMapingProfile));
            services.AddScoped<ShScraping>();
        }
        public static void AddStorage<T>(this IServiceCollection services) where T : Storage, IStorage
        {
            services.AddScoped<IStorage, T>();
        }

    }
}