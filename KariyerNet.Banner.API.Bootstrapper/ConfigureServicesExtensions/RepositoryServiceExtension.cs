using KariyerNet.Banner.Data;
using KariyerNet.Banner.Data.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace KariyerNet.Banner.API.Bootstrapper
{
    public static class RepositoryServiceExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICookieRepository, CookieRepository>();

            return services;
        }
    }
}
