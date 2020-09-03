using MongoDB.Driver;
using System;

namespace KariyerNet.Banner.Data.Contract
{
    public interface IMongoBookDBContext
    {
        public IMongoCollection<Book> GetCollection<Book>(string name);
    }
}
