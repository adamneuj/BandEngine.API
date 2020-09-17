using BandEngine.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandEngine.API.Data
{
    public class BandEngineDbContext
    {
        private readonly IMongoDatabase _db;

        public BandEngineDbContext(IMongoClient client, string dbName)
        {
            _db = client.GetDatabase(dbName);
        }

        public IMongoCollection<User> Users => _db.GetCollection<User>("users");
    }
}
