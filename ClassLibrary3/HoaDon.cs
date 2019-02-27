using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private String mahd, ngaylap,makh,diachigiao,sdt;
        private bool giaohang;
        private int thanhtien;
        private ChiTietHoaDon cthd;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Diachigiao { get => diachigiao; set => diachigiao = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public bool Giaohang { get => giaohang; set => giaohang = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public ChiTietHoaDon Cthd { get => cthd; set => cthd = value; }
    }
}
