using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private int thanhtien;
        private String makh,mahd;
        private float giamgia;
        private HashSet<ThietBi> sanpham;

        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Makh { get => makh; set => makh = value; }
        public float Giamgia { get => giamgia; set => giamgia = value; }
        public HashSet<ThietBi> Sanpham { get => sanpham; set => sanpham = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        
    }
}
