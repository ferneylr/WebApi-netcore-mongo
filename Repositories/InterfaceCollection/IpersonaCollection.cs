using ApiMongo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ApiMongo.Models.Persona;

namespace ApiMongo.Repositories
{
   public  interface IpersonaCollection
    {
        Task InsertPersona(Persona persona);

        Task UpdatePersona(Persona persona);

        Task DeletePersona(string id);

        Task<List<Persona>> GetAllPersona();

        Task<Persona> GetPersonaById(string id);

    }
}
