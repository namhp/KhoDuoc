﻿using System;
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
    public partial class PhieuKiemKeF : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F1276L2\NAMEXPRESS;Initial Catalog=KhoDuoc;Integrated Security=True");

        public PhieuKiemKeF()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into phieuKiemKe values('" + textBox1.Text + "','" + textBox2.Text + "',,'" + textBox3.Text + "',,)";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            disp_data();
            MessageBox.Show("Thêm thành công");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from phieuKiemKe";
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
            cmd.CommandText = "update phieuKiemKe set manv='" + textBox2.Text + "',ngay='"+textBox3.Text+"' where sophieu='" + textBox1.Text + "'";
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
            cmd.CommandText = "delete from phieuKiemKe where sophieu='" + textBox1.Text + "'";
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
            cmd.CommandText = "select * from phieuKiemKe where sophieu ='" + textBox1.Text + "' ";
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
            ChiTietKiemKeF f = new ChiTietKiemKeF();
            f.Show();
        }

        private void PhieuKiemKeF_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
