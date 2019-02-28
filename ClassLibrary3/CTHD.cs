using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private String mahd, matb;
        private int soluong;
        public override string ToString()
        {
            return "\'" + mahd + "\',\'" + matb + "\','" + soluong + "\'";
        }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Matb { get => matb; set => matb = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public ChiTietHoaDon(String mahd, String matb, int soluong)
        {
            this.mahd = mahd;
            this.matb = matb;
            this.soluong = soluong;
        }
        public ChiTietHoaDon(String[] data)
        {
            this.mahd = data[0];
            this.matb = data[1];
            this.soluong = int.Parse(data[2]);
        }
    }
}
