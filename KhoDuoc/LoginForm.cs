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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F1276L2\NAMEXPRESS;Initial Catalog=KhoDuoc;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from taiKhoan where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                //for(int i =0; i < dt.Rows.Count; i++)
                //{
                //    if (dt.Rows[i]["type"].ToString() == cmbItemValue)
                //    {
                MessageBox.Show("Đăng nhập thành công");
                if (comboBox1.SelectedIndex == 0)
                        {

                            AdminF f = new AdminF();
                            f.Show();
                            this.Hide();
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            DuocF ff = new DuocF();
                            ff.Show();
                            this.Hide();
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            ChucNangF fff = new ChucNangF();
                            fff.Show();
                            this.Hide();
                        }
                    //}
                //}
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng, xin nhập lại");
            }
            con.Close();

        }
    }
}
