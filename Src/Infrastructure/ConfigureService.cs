using Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfigureService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
        {
            //connection string sql server
            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            ////connection string redis
            //services.AddSingleton<IConnectionMultiplexer>(opt =>
            //{
            //    var options = ConfigurationOptions.Parse(configuration.GetConnectionString("Redis") ?? string.Empty, true);
            //    return ConnectionMultiplexer.Connect(options);
            //});
            ////Identity
            //services.AddIdentityService(configuration);
            //services.AddScoped<ITokenService, TokenService>();
            ////DI
            //services.AddScoped<IBasketRepository, BasketRepository>();
            //services.AddScoped<IUnitOWork, UnitOWork>();
            return services;
        }
    }
}
