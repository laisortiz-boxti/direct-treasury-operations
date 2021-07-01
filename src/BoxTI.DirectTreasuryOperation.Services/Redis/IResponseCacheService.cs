using System;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Services.Redis
{
    public interface IResponseCacheService
    {
        Task CacheResponseAsync(string cacheKey, object response, TimeSpan timeTimeLive);

        Task<string> GetCachedResponseAsync(string cacheKey);
    }
}