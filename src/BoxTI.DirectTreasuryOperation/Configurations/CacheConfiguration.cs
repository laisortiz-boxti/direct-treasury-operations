using BoxTI.DirectTreasuryOperation.API.Cache;
using BoxTI.DirectTreasuryOperation.Services.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BoxTI.DirectTreasuryOperation.API.Configurations
{
    public static class CacheConfiguration
    {
        public static void AddCacheConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var redisCacheSettings = new RedisCacheSettings();
            configuration.GetSection(nameof(RedisCacheSettings)).Bind(redisCacheSettings);
            services.AddSingleton(redisCacheSettings);

            if (!redisCacheSettings.Enabled)
            {
                return;
            }

            services.AddStackExchangeRedisCache(options =>
                options.Configuration = redisCacheSettings.ConnectionString
            );
            services.AddSingleton<IResponseCacheService, ResponseCacheService>();
        }
    }
}
