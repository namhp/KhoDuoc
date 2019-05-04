using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoDuoc
{
    public partial class DuocF : Form
    {
        public DuocF()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PhieuNhapF f1 = new PhieuNhapF();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuLinhF f2 = new PhieuLinhF();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhieuXuatF f3 = new PhieuXuatF();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PhieuKiemKeF f4 = new PhieuKiemKeF();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DanhSachThuocF f5 = new DanhSachThuocF();
            f5.Show();
        }
    }
}
