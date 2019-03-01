using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FKhachHang : Form
    {
        public FKhachHang()
        {
            InitializeComponent();
        }

        private void txbSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
            if (e.KeyChar == (char)13)
                btnLuu.PerformClick();
        }

        private void txbTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)8 || Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
            if (e.KeyChar == (char)13)
                btnLuu.PerformClick();
        }

        private void txbDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLuu.PerformClick();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
        private bool Check()
        {
            return true;
        }
    }
}
