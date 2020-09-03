using KariyerNet.Banner.Data.Context;
using KariyerNet.Banner.Data.Contract;
using KariyerNet.Banner.Data.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Linq;

namespace KariyerNet.Banner.Data
{
    public class CookieRepository : MongoRepository<Client, MongoContext>, ICookieRepository
        //neden client alıyoruz cookiereponun içinde?
    {
        public Cookie GetByPublicId(string publicId)
        {
            return _dbCollection.AsQueryable().
                 Where(q => q.Id == publicId).FirstOrDefault(); //cookienin objectIdsi mi publicId yoksa clientin objectidsi cookienin clientidsi mi ???
        }

       
    }
}
