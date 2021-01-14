using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace petroleumAPI.Models
{
    public class Campos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Campo { get; set; }

        public int Producao_oleo_m3  { get; set; }

        public string mes { get; set; }

        public int Ano { get; set; }
    }
}

