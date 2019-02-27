using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private String makh, tenkh, diachi, sdt, ngaysinh;

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public KhachHang(String makh,String tenkh,String diachi,String sdt,String ngaysinh)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.ngaysinh = ngaysinh;
        }
        public KhachHang(String[] data)
        {
            this.makh = data[0];
            this.tenkh = data[1];
            this.diachi = data[2];
            this.sdt = data[3];
            this.ngaysinh = data[4];
        }
    }
}
