using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Repositories
{
    public class MongoSettings: IMongoSettings
    {
        public string Server { get; set; }

        public string Database { get; set; }
       

    }

    public interface IMongoSettings
    {
        public string Server { get; set; }

        public string Database { get; set; }
    }
}
