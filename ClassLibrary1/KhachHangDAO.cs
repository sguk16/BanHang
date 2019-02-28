using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class KhachHangDAO
    {
        public static List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> result = new List<KhachHang>();
            List<String[]> data = ExecuteQuery.getAll("KhachHang");
            for(int i=0;i<data.Count();i++)
                result.Add(new KhachHang(data[i]));
            return result;
        }
        public static KhachHang GetKhachHang(String id)
        {
            return new KhachHang(ExecuteQuery.getOne(id, "KhachHang"));
        }
        public static int AddKhachHang(KhachHang kh)
        {
            return ExecuteQuery.AddRows(kh.ToString(), "KhachHang");
        }
        public static int EditKhachHang(KhachHang kh)
        {
            int result = 0;
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            String sql = "UPDATE KhachHang \n" +
                "SET ten='" + kh.Tenkh + "',diachi='" + kh.Diachi + "',sdt=" + kh.Sdt + "'\n" +
                "WHERE id='" + kh.Makh + "'";
            Console.WriteLine(sql);
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
        public static int DeleteKhachHang(KhachHang kh)
        {
            return ExecuteQuery.DeleteRows(kh.Makh, "KhachHang");
        }
    }
}
