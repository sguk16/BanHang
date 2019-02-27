using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class CTHDDAO
    {
        public static List<ChiTietHoaDon> GetAllCTHD()
        {
            List<ChiTietHoaDon> result = new List<ChiTietHoaDon>();
            List<String[]> data = ExecuteQuery.getAll("CTHoaDon");
            for(int i=0;i<data.Count();i++)
                result.Add(new ChiTietHoaDon(data[i]));
            return result;
        }
    }
}
