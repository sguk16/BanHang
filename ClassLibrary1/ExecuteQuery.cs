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
        public static String[] getOne(String id, String table)
        {
            String[] result = { };
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            String sql = "SELECT * FROM " + table + "WHERE id =\'" + id +"\'";
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = new String[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result[i] = reader[i].ToString();
                    }
                }
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
        public static String[] getLoaiTB()
        {
            String[] result = {};
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            String sql = "SELECT loai FROM ThietBi GROUP BY loai";
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                List<String> tmp = new List<string>();
                while (reader.Read())
                    tmp.Add(reader[0].ToString());
                result = new string[tmp.Count];
                for (int i = 0; i < tmp.Count; i++)
                    result[i] = tmp[i];
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
        public static int AddRows(String obj,String table)
        {
            int result = 0;
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            String sql = "INSERT INTO " + table + " VALUES(" + obj + ")";
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
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
        public static int DeleteRows(String id,String table)
        {
            int result = 0;
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            String sql = "DELETE FROM " + table + " WHERE id='" + id +"'";
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
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
