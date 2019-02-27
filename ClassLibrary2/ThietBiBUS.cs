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
        public static String[] Loaitb()
        {
            return ThietBiDAO.LoaiTB();
        }
    }
}
