using System;
using KariyerNet.Banner.Business;
using KariyerNet.Banner.Business.Contract;
using Microsoft.Extensions.DependencyInjection;


namespace KariyerNet.Banner.API.Bootstrapper
{
    public static class BusinessServiceExtension
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<ICookieService, CookieService>();

            return services;
        }
    }
}
