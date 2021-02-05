using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Models
{
    public class CoreEps
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("entidad")]
        public string Entidad { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        [BsonElement("fecha_ingreso")]
        public DateTime FechaIngreso { get; set; }

        [BsonElement("estado_afiliacion")]
        public string EstadoAfiliacion { get; set; }
    }
}
