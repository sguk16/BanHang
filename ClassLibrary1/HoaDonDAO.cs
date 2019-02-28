using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class HoaDonDAO
    {
        public static List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> result = new List<HoaDon>();
            List<String[]> data = ExecuteQuery.getAll("HoaDon");
            for(int i=0;i<data.Count();i++)
                result.Add(new HoaDon(data[i]));
            return result;
        }
        public static HoaDon GetThietBi(String id)
        {
            return new HoaDon(ExecuteQuery.getOne(id, "HoaDon"));
        }
        public static int AddHoaDon(HoaDon hd)
        {
            return ExecuteQuery.AddRows(hd.ToString(), "HoaDon");
        }
        public static int EditHoaDon(HoaDon hd)
        {
            int result = 0;
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            String format = "yyyy-MM-dd HH:mm:ss";
            String sql = "UPDATE HoaDon \n" +
                "SET idkhachhang='" + hd.Makh + "',ngay=" + hd.Ngaylap.ToString(format) + ",tongtien=" + hd.Thanhtien + ",diachigiao='" + hd.Diachigiao + "',giaohang="+hd.Giaohang +"\n" +
                "WHERE id='" + hd.Mahd + "'";
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
        public static int DeleteHoaDon(HoaDon hd)
        {
            return ExecuteQuery.DeleteRows(hd.Mahd, "HoaDon");
        }
    }
}
