using System;
using System.Collections.Generic;
using System.Text;
using KariyerNet.Banner.Client.DTO;

namespace KariyerNet.Banner.Business.Contract
{
    public interface IClientService
    {
        bool Add(AddClientRequest request) 
        { 
            return request.Name == null ? false : true;  //dışarıdan name boş gelirse false dolu gelirse true dön
        }

    }
}
