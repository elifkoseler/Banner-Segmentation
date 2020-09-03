using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KariyerNet.Banner.Business.Contract;
using KariyerNet.Banner.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KariyerNet.Banner.API.Controllers
{
    [Route("api/[controller]")]
    public class CookieController : Controller
    {
        IServiceProvider _serviceProvider;

        public CookieController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Cookie Get(string publicId)
        {
            return _serviceProvider.GetService<ICookieService>().GetByPublicId(publicId);
        }
    }
}
