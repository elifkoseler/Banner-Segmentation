using System;
using System.Collections.Generic;
using System.Text;
using KariyerNet.Banner.Business.Contract;
using KariyerNet.Banner.Client.DTO;

namespace KariyerNet.Banner.Business
{
    public class ClientService : BaseService, IClientService
    {
        public ClientService(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
        public bool Add(AddClientRequest request)
        {
            return _serviceProvider.GetService<IClientService>.Add(request);
        }
    }
}
