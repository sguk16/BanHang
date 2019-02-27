using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CTHDBUS
    {
        public static List<ChiTietHoaDon> ListCTHD()
        {
            return CTHDDAO.GetAllCTHD();
        }
    }
}
