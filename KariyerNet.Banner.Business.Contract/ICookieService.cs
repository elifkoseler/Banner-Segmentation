using System;
using KariyerNet.Banner.Data.Entities;

namespace KariyerNet.Banner.Business.Contract
{
    public interface ICookieService
    {
        Cookie GetByPublicId(string publicId);
    }
}
