using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KariyerNet.Banner.Business.Contract;
using KariyerNet.Banner.Client.DTO;
using KariyerNet.Banner.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;


namespace KariyerNet.Banner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IServiceProvider _serviceProvider;

        public ClientController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public bool Add(AddClientRequest request)
        {
            return _serviceProvider.GetService<IClientService>.Add(request);
        }
    }
}
