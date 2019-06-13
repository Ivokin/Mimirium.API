using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mimirium.API.Models
{
    public class Company
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public int Vat { get; set; }
    }
}
