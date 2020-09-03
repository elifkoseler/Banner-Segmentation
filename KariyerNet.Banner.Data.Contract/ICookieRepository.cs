using KariyerNet.Banner.Data.Entities;

namespace KariyerNet.Banner.Data.Contract
{
    public interface ICookieRepository : IMongoRepository<Client>
    {
        Cookie GetByPublicId(string publicId);
    }
}
