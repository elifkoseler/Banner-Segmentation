using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace KariyerNet.Banner.Data.Entities
{
    [BsonDiscriminator("Client")]
    public class Client
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string PublicKey { get; set; }
        public string Name { get; set; } //dışarıdan alacağız
        public bool Active { get; set; }
    }
}
