using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private String mahd,makh,diachigiao;
        DateTime ngaylap;
        private int thanhtien,giaohang;
        public override string ToString()
        {
            DateTime time = DateTime.Now;
            String format = "yyyy-MM-dd HH:mm:ss";
            return "\'" + mahd + "\',\'" + makh + "\','" + ngaylap.ToString(format) + "\','" + thanhtien + "\','" + diachigiao + "\','" + giaohang +"\'";
        }
        public string Mahd { get => mahd; set => mahd = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Diachigiao { get => diachigiao; set => diachigiao = value; }
        public int Giaohang { get => giaohang; set => giaohang = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public HoaDon(String mahd, DateTime ngaylap, String makh, String diachigiao, int thanhtien,int giaohang)
        {
            this.mahd = mahd;
            this.ngaylap = ngaylap;
            this.makh = makh;
            this.diachigiao = diachigiao;
            this.thanhtien = thanhtien;
            this.giaohang = giaohang;
        }
        public HoaDon(String[] data)
        {
            this.mahd = data[0];
            this.ngaylap = DateTime.Parse(data[1]);
            this.makh = data[2];
            this.diachigiao = data[3];
            this.thanhtien = int.Parse(data[4]);
            this.giaohang = int.Parse(data[4]);
        }
    }
}
