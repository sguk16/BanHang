using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class GetConnect
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-G6PP4N5";
            string database = "banhang";
            string username = "sa";
            string password = "123";

            return DBConnect.GetDBConnection(datasource, database, username, password);
        }
    }
}
