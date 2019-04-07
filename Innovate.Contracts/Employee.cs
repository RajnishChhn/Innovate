using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovate.Contracts
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Bson.Serialization.IdGenerators;
    public class Employee
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public long Contact { get; set; }
        public Status Status { get; set; }
        public string Location { get; set; }
        public string Message { get; set; }
        public bool IsAdditionalActionRequired { get; set; }
    }
}
