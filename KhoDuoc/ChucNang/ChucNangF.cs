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
    public partial class ChucNangF : Form
    {
        public ChucNangF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuiPhieuLinhF f = new GuiPhieuLinhF();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachThuocF ff = new GuiPhieuLinhF();
            ff.Show();
        }
    }
}
