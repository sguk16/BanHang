using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO
{
    public class ThietBi
    {
        private String matb, tentb,loaitb;
        private int sl, dongia;
        public override string ToString()
        {
            return "\'"+matb+ "\',\'"+ tentb + "\'," + dongia + "," + sl + ",'"+ loaitb + "\'";
        }
        public ThietBi(string matb, string tentb, string loaitb, int sl, int dongia)
        {
            this.matb = matb;
            this.tentb = tentb;
            this.loaitb = loaitb;
            this.sl = sl;
            this.dongia = dongia;
        }
        public ThietBi(String[] data)
        {
            this.matb = data[0];
            this.tentb = data[1];
            this.loaitb = data[2];
            this.sl = int.Parse(data[3]);
            this.dongia = int.Parse(data[4]);
        }

        public int SL { get => sl; set => sl = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Matb { get => matb; set => matb = value; }
        public string Tentb { get => tentb; set => tentb = value; }
        public string Loaitb { get => loaitb; set => loaitb = value; }
    }
}
