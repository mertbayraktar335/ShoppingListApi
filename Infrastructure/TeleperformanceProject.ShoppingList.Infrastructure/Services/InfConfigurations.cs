using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeleperformanceProject.ShoppingList.Application.Tokens;

namespace TeleperformanceProject.ShoppingList.Infrastructure.Services
{
    public static class InfConfigurations
    {
        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("PostgreDef");
            var connectionString2 = configuration.GetConnectionString("PostgreAdmin");
            services.AddScoped<ITokenHandler, TokensHandler>();
            return services;
        }

    }
}
