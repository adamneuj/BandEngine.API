using BandEngine.API.Data;
using BandEngine.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandEngine.API.Services
{
    public class UserService
    {
        private readonly BandEngineDbContext _db;

        public UserService(BandEngineDbContext db)
        {
            _db = db;
        }

        public async Task<User> GetUserAsync(string id)
        {
            return await _db.Users.Find(u => u.Id == id).FirstAsync();
        }

        public async Task<bool> RegisterUserAsync(User user)
        {
            try
            {
                await _db.Users.InsertOneAsync(user);
                return true;
            }
            catch(AggregateException e)
            {
                return false;
            }

        }
    }
}
