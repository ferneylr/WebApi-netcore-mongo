using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Models
{
    public class Identificacion
    {
        [BsonElement("numero")]
        public string Numero { get; set; }


        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        [BsonElement("fecha_expedicion")]
        public DateTime FechaExpedicion { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        [BsonElement("lugar_expedicion")]
        public DateTime LugarExpedicion { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get; set; }
    }
}
