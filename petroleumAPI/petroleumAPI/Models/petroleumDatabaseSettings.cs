using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petroleumAPI.Models
{
    public class petroleumDatabaseSettings : IpetroleumDatabaseSettings
    {
        public string petroleumCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IpetroleumDatabaseSettings
    {
        string petroleumCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
