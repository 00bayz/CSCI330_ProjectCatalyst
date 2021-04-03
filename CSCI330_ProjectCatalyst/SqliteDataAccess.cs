using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI330_ProjectCatalyst
{
    class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "default")
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
