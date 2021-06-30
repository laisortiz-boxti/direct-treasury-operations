using Microsoft.Extensions.DependencyInjection;
using System;

namespace BoxTI.DirectTreasuryOperation.API.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            var assemblies = new[] { typeof(Startup).Assembly };
            services.AddAutoMapper((serviceProvider, mapperConfiguration) => mapperConfiguration.AddMaps(assemblies), assemblies);
        }
    }
}
