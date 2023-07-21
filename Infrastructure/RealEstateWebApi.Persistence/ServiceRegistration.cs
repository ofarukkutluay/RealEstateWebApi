using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Persistence.Contexts;
using RealEstateWebApi.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<RealEstateWebApiDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            //services.AddDbContext<RealEstateWebApiDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("PostgreSQL"))); 
            
            services.AddDbContext<LocalDbContext>(options => options.UseInMemoryDatabase("LocalDb"));
            services.AddScoped<ILocalDbContext>(provider => provider.GetService<LocalDbContext>());

            services.AddScoped<IAgentReadRepository,AgentReadRepository>();
            services.AddScoped<IAgentWriteRepository,AgentWriteRepository>();
            services.AddScoped<IBlogReadRepository,BlogReadRepository>();
            services.AddScoped<IBlogWriteRepository,BlogWriteRepository>();
            services.AddScoped<IBlogTypeReadRepository,BlogTypeReadRepository>();
            services.AddScoped<IBlogTypeWriteRepository,BlogTypeWriteRepository>();
            services.AddScoped<ICityReadRepository,CityReadRepository>();
            services.AddScoped<ICityWriteRepository,CityWriteRepository>();
            services.AddScoped<IClientReadRepository,ClientReadRepository>();
            services.AddScoped<IClientWriteRepository,ClientWriteRepository>();
            services.AddScoped<ICompanyReadRepository,CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository,CompanyWriteRepository>();
            services.AddScoped<IDeedStatusReadRepository,DeedStatusReadRepository>();
            services.AddScoped<IDeedStatusWriteRepository,DeedStatusWriteRepository>();
            services.AddScoped<IDistrictReadRepository,DistrictReadRepository>();
            services.AddScoped<IDistrictWriteRepository,DistrictWriteRepository>();
            services.AddScoped<IFileReadRepository,FileReadRepository>();
            services.AddScoped<IFileWriteRepository,FileWriteRepository>();
            services.AddScoped<IFrontReadRepository,FrontReadRepository>();
            services.AddScoped<IFrontWriteRepository,FrontWriteRepository>();
            services.AddScoped<IHeatingTypeReadRepository,HeatingTypeReadRepository>();
            services.AddScoped<IHeatingTypeWriteRepository,HeatingTypeWriteRepository>();
            services.AddScoped<IInternetTypeReadRepository,InternetTypeReadRepository>();
            services.AddScoped<IInternetTypeWriteRepository,InternetTypeWriteRepository>();
            services.AddScoped<IJobTitleReadRepository,JobTitleReadRepository>();
            services.AddScoped<IJobTitleWriteRepository,JobTitleWriteRepository>();
            services.AddScoped<IMessageReadRepository,MessageReadRepository>();
            services.AddScoped<IMessageWriteRepository,MessageWriteRepository>();
            services.AddScoped<INeighborhoodReadRepository,NeighborhoodReadRepository>();
            services.AddScoped<INeighborhoodWriteRepository,NeighborhoodWriteRepository>();
            services.AddScoped<IOperationClaimReadRepository,OperationClaimReadRepository>();
            services.AddScoped<IOperationClaimWriteRepository,OperationClaimWriteRepository>();
            services.AddScoped<IPropertyReadRepository,PropertyReadRepository>();
            services.AddScoped<IPropertyWriteRepository,PropertyWriteRepository>();
            services.AddScoped<IPropertyPhotoReadRepository,PropertyPhotoReadRepository>();
            services.AddScoped<IPropertyPhotoWriteRepository,PropertyPhotoWriteRepository>();
            services.AddScoped<IPropertyStatusReadRepository,PropertyStatusReadRepository>();
            services.AddScoped<IPropertyStatusWriteRepository,PropertyStatusWriteRepository>();
            services.AddScoped<IPropertyTypeReadRepository,PropertyTypeReadRepository>();
            services.AddScoped<IPropertyTypeWriteRepository,PropertyTypeWriteRepository>();
            services.AddScoped<IStreetReadRepository,StreetReadRepository>();
            services.AddScoped<IStreetWriteRepository,StreetWriteRepository>();
            services.AddScoped<IUserReadRepository,UserReadRepository>();
            services.AddScoped<IUserWriteRepository,UserWriteRepository>();
            services.AddScoped<IUsingStatusReadRepository,UsingStatusReadRepository>();
            services.AddScoped<IUsingStatusWriteRepository,UsingStatusWriteRepository>();
            services.AddScoped<IUserOperationClaimReadRepository,UserOperationClaimReadRepository>();
            services.AddScoped<IUserOperationClaimWriteRepository,UserOperationClaimWriteRepository>();
            services.AddScoped<IUserLoginReadRepository,UserLoginReadRepository>();
            services.AddScoped<IUserLoginWriteRepository,UserLoginWriteRepository>();
            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
            services.AddScoped<ICustomerOwnedPropertyReadRepository,CustomerOwnedPropertyReadRepository>();
            services.AddScoped<ICustomerOwnedPropertyWriteRepository,CustomerOwnedPropertyWriteRepository>();
            services.AddScoped<ICustomerSearchPropertyReadRepository, CustomerSearchPropertyReadRepository>();
            services.AddScoped<ICustomerSearchPropertyWriteRepository,CustomerSearchPropertyWriteRepository>();
            services.AddScoped<IEntryReadRepository,EntryReadRepository>();
            services.AddScoped<IEntryWriteRepository,EntryWriteRepository>();
            services.AddScoped<IEntryTypeReadRepository,EntryTypeReadRepository>();
            services.AddScoped<IEntryTypeWriteRepository,EntryTypeWriteRepository>();
            services.AddScoped<IEntrySubTypeReadRepository,EntrySubTypeReadRepository>();
            services.AddScoped<IEntrySubTypeWriteRepository,EntrySubTypeWriteRepository>();
            services.AddScoped<IPropertyListingPhotoReadRepository, PropertyListingPhotoReadRepository>();
            services.AddScoped<IPropertyListingPhotoWriteRepository, PropertyListingPhotoWriteRepository>();
            services.AddScoped<IPropertyListingDetailReadRepository,PropertyListingDetailReadRepository>();
            services.AddScoped<IPropertyListingDetailWriteRepository,PropertyListingDetailWriteRepository>();
            services.AddScoped<IReminderReadRepository, ReminderReadRepository>();
            services.AddScoped<IReminderWriteRepository, ReminderWriteRepository>();
        }
    }
}
