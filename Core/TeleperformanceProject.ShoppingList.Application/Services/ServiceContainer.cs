using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeleperformanceProject.ShoppingList.Application.Mapping;

namespace TeleperformanceProject.ShoppingList.Application.Services
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("PostgreDef");
            var connectionString2 = configuration.GetConnectionString("PostgreAdmin");
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddMediatR(typeof(ServiceContainer));
            services.AddSingleton<HttpContextAccessor>();
            return services;
        }
    }
}
