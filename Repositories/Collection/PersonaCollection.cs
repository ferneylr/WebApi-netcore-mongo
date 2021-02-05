using ApiMongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Repositories
{
    public class PersonaCollection : IpersonaCollection
    {
       
        private IMongoCollection<Persona> Collection;

        public PersonaCollection(IMongoSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            Collection = database.GetCollection<Persona>("persona");
        }

        public async Task DeletePersona(string id)
        {
            var filter = Builders<Persona>.Filter.Eq(s => s.Id, id);
            await Collection.DeleteOneAsync(filter);
        }

        public async Task<List<Persona>> GetAllPersona()
        {
            return await Collection.FindAsync(d => true).Result.ToListAsync();
        }

        public async Task<Persona> GetPersonaById(string id)
        {
            return await Collection.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
        }

        public async Task InsertPersona(Persona persona)
        {
            try
            {
                await Collection.InsertOneAsync(persona);
            }
            catch
            {
                throw;
            }
        }

        public async Task UpdatePersona(Persona persona)
        {
            var filter = Builders<Persona>.Filter.Eq(i => i.Id, persona.Id);
            await Collection.ReplaceOneAsync(filter, persona);
        }
    }
}
