using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HelParkUser.API.Models
{
    public class Test
    {
        [BsonId]
        public ObjectId _Id { get; set; }

        public string Name  { get; set; }

        public int Age  { get; set; }
    }
}
