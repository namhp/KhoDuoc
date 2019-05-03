using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoDuoc
{
    public partial class PhieuLinhF : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F1276L2\NAMEXPRESS;Initial Catalog=KhoDuoc;Integrated Security=True");

        public PhieuLinhF()
        {
            InitializeComponent();
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from phieuLinh";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update phieuLinh set manvc='" + textBox2.Text + "', ngayc='"+textBox3.Text+"', trangthai='"+textBox4.Text+"' where sophieu='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Cập nhật thành công");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from phieuLinh where sophieu='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Xóa thành công");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from phieuLinh where sophieu ='" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CapNhatChiTietLinhF f = new CapNhatChiTietLinhF();
            f.Show();
        }
        private void PhieuLinhF_Load(object sender, EventArgs e)
        {
            disp_data();

        }
    }
}
