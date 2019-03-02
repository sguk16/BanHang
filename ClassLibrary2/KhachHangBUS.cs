using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class KhachHangBUS
    {
        public static List<KhachHang> ListKH()
        {
            return KhachHangDAO.GetAllKhachHang();
        }
        public static KhachHang GetKhachHang(String id)
        {
            return new KhachHang(ExecuteQuery.getOne(id, "KhachHang"));
        }
        public static int AddKhachHang(KhachHang kh)
        {
            return KhachHangDAO.AddKhachHang(kh);
        }
        public static int EditKhachHang(KhachHang kh)
        {
            return KhachHangDAO.EditKhachHang(kh);
        }
    }
}
