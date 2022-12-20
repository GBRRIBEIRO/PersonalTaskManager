using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Infra.EntityFramework.Configurations
{
    public class DbConfiguration
    {
        public string Path { get; set; }
        public string ConnectionString { get; set; }

        public DbConfiguration(string dbName)
        {
            Path = @"C:\Users\gabriel.ribeiro\Desktop\Database\DBS";
            ConnectionString = System.IO.Path.Combine(Path,dbName);
        }
    }
}
