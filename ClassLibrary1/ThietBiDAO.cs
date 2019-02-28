using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class ThietBiDAO
    {
        public static List<ThietBi> GetAllThietBi()
        {
            List<ThietBi> result = new List<ThietBi>();
            List<String[]> data = ExecuteQuery.getAll("ThietBi");
            for(int i=0;i<data.Count();i++)
                result.Add(new ThietBi(data[i]));
            return result;
        }
        public static ThietBi GetThietBi(String id)
        {
            return new ThietBi(ExecuteQuery.getOne(id, "ThietBi"));
        }
        // Get thiết bị theo loại thiết bị
        public static List<ThietBi> GetThietBiTheoLoai(String loai)
        {
            List<ThietBi> result = new List<ThietBi>();
            List<String[]> data = ExecuteQuery.getAll("ThietBi WHERE loai=\'" + loai + "\'");
            for (int i = 0; i < data.Count(); i++)
                result.Add(new ThietBi(data[i]));
            return result;
        }
        //Get các loại thiết bị
        public static String[] LoaiTB()
        {
            return ExecuteQuery.getLoaiTB();
        }
        //Thêm thiết bị
        public static int AddThietBi(ThietBi tb)
        {
            return ExecuteQuery.AddRows(tb.ToString(), "ThietBi");
        }
        //Sửa thiết bị
        public static int EditThietBi(ThietBi tb)
        {
            int result = 0;
            SqlConnection conn = GetConnect.GetDBConnection();
            conn.Open();
            String sql = "UPDATE ThietBi \n" +
                "SET ten='" +tb.Tentb+"',gia="+tb.Dongia+",soluong="+tb.SL+",loai='"+tb.Loaitb+"'\n"+
                "WHERE id='" + tb.Matb+"'";
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
        //Xóa thiết bị
        public static int DeleteThietBi(ThietBi tb)
        {
            return ExecuteQuery.DeleteRows(tb.Matb, "ThietBi");
        }
    }
}
