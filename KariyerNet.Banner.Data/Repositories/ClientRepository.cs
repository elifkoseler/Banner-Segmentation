using System;
using System.Collections.Generic;
using System.Text;
using KariyerNet.Banner.Data.Context;
using KariyerNet.Banner.Data.Contract;
using KariyerNet.Banner.Data.Entities;

namespace KariyerNet.Banner.Data.Repositories
{
   public class ClientRepository : MongoRepository<Client, MongoContext>, IClientRepository
    {
       
    }
}
