using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
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
    }
}
