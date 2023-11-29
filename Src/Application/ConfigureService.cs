using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ConfigureService
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            //configure auto mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //validator
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //CQRS = Mediator
            //collection add => service provider get =>DI
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //pipeline
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachedQueryBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        }
    }
}
