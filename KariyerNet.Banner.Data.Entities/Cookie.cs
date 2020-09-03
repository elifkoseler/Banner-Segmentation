using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KariyerNet.Banner.Data.Entities
{
    [BsonDiscriminator("Cookie")]
    public class Cookie
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string ClientId { get; set; }
        public DateTime CreateTime { get; set; }
        public List<Object> UserInfo { get; set; } //{Age:32,DriverLicence:B,Cinsiyet:E}


    }
}
