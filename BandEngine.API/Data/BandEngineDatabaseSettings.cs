using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandEngine.API.Data
{
    public interface IBandEngineDatabaseSettings
    {
        public string UsersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public class BandEngineDatabaseSettings : IBandEngineDatabaseSettings
    {
        public string UsersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
