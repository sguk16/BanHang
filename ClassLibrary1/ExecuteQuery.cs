using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ExecuteQuery
    {
        public static List<String[]> getAll(String table)
        {
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            List<String[]> result = new List<String[]>();
            String sql = "SELECT * FROM " + table;
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String[] tmp = new String[10];
                        for(int i=0;i<reader.FieldCount;i++)
                        {
                            tmp[i] = reader[i].ToString();
                        }
                        result.Add(tmp);
                    }
                };
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return result;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
