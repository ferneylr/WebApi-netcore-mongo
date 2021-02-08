using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Models
{
    public class Persona
    {
        

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("schema_version")]
        public string SchemaVersion { get; set; }

        [BsonElement("document_version")]
        public int DocumentVersion { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        [BsonElement("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        [BsonElement("fecha_ultima_modificacion")]
        public DateTime FechaUltimaModificacion { get; set; }

        [BsonElement("codigo_interno")]
        public string CodigoInterno { get; set; }

        [BsonElement("primer_nombre")]
        public string PrimerNombre { get; set; }

        [BsonElement("segundo_nombre")]
        public string SegundoNombre { get; set; }

        [BsonElement("primer_apellido")]
        public string PrimerApellido { get; set; }

        [BsonElement("segundo_apellido")]
        public string SegundoApellido { get; set; }

        [BsonElement("identificacion")]
        public Identificacion Identificacion { get; set; }

        [BsonElement("estado_civil")]
        public string EstadoCivil { get; set; }

        [BsonElement("sexo")]
        public string Sexo { get; set; }

        [BsonElement("correo_electronico")]
        public CorreoElectronico CorreoElectronico { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        [BsonElement("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [BsonElement("core_eps")]
        public List<CoreEps> CoreEps { get; set; }

        public Persona()
        {
            this.Identificacion = new Identificacion();
            this.CorreoElectronico = new CorreoElectronico();
            this.CoreEps = new List<CoreEps>();
        }
    }
}
