using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QBuildDesktop.BO
{
    public class Item
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("COMPONENT_NAME")]
        public string ComponentName { get; set; }
        [BsonElement("PARENT_NAME")]
        public string ParentName { get; set; }
        [BsonElement("QUANTITY")]
        public string Quantity { get; set; }
        public Part PartData { get; set; }
    }
}
