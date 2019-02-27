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
    }
}
