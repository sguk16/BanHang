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
    }
}
