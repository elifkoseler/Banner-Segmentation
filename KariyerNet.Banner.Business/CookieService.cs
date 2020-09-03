using KariyerNet.Banner.Business.Contract;
using KariyerNet.Banner.Data.Contract;
using System;
using Microsoft.Extensions.DependencyInjection;
using KariyerNet.Banner.Data.Entities;

namespace KariyerNet.Banner.Business
{
    public class CookieService : BaseService, ICookieService
    {
        public CookieService(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        public Cookie GetByPublicId(string publicId)
        {
            return _serviceProvider.GetService<ICookieRepository>().GetByPublicId(publicId);
        }
    }

}
