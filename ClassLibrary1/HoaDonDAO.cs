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
    }
}
