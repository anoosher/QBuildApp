using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace QBuildDesktop.BO
{
    public class Part
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("NAME")]
        public string Name { get; set; }
        [BsonElement("TYPE")]
        public string Type { get; set; }
        [BsonElement("ITEM")]
        public string Item { get; set; }
        [BsonElement("PART_NUMBER")]
        public string PartNo { get; set; }
        [BsonElement("TITLE")]
        public string Title { get; set; }
        [BsonElement("MATERIAL")]
        public string Material { get; set; }
        public string ComponentName { get; set; }
        public string Quantity { get; set; }
    }
}