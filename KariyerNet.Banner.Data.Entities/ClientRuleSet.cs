using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KariyerNet.Banner.Data.Entities
{
    [BsonDiscriminator("ClientRuleSet")]

    public class ClientRuleSet
    {
        public ObjectId Id { get; set; }
        public string ClientId { get; set; }
        public List<Object> Rule { get; set; }
        public Action action { get; set; } //intherit?
    }
}
