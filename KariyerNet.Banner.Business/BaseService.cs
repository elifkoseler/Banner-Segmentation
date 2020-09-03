using KariyerNet.Banner.Business.Contract;
using System;

namespace KariyerNet.Banner.Business
{
    public class BaseService : IBaseService
    {
        protected readonly IServiceProvider _serviceProvider;

        public BaseService()
        {

        }

        public BaseService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}
