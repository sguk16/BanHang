using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ThietBiBUS
    {
        public static List<ThietBi> ListTB()
        {
            return ThietBiDAO.GetAllThietBi();
        }
        public static ThietBi GetThietBi(String id)
        {
            return ThietBiDAO.GetThietBi(id);
        }
        public static String[] Loaitb()
        {
            return ThietBiDAO.LoaiTB();
        }
        public static int AddThietBi(ThietBi tb)
        {
            return ThietBiDAO.AddThietBi(tb);
        }
        public static int EditThietBi(ThietBi tb)
        {
            return ThietBiDAO.EditThietBi(tb);
        }
    }
}
