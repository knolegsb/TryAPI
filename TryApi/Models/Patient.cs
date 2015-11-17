using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryApi.Models
{
    public class Patient
    {
        [BsonElement("-id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ailment> Ailment { get; set; }
        public ICollection<Medication> Medication { get; set; }
    }

    public class Medication
    {
        public string Name { get; set; }
        public int Doses { get; set; }
    }

    public class Ailment
    {
        public string Name { get; set; }
    }
}