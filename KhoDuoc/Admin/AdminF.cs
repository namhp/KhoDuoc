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
    public partial class AdminF : Form
    {
        public AdminF()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CRUDTaiKhoan f1 = new CRUDTaiKhoan();
            f1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CRUDThuoc f2 = new CRUDThuoc();
            f2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CRUDNV f3 = new CRUDNV();
            f3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CRUDNCC f4 = new CRUDNCC();
            f4.Show();
        }
    }
}
