﻿namespace KhoDuoc
{
    partial class ChiTietNhapF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chiTietNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoDuocDataSet = new KhoDuoc.KhoDuocDataSet();
            this.chiTietNhapTableAdapter = new KhoDuoc.KhoDuocDataSetTableAdapters.chiTietNhapTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sophieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sophieuDataGridViewTextBoxColumn,
            this.mathuocDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietNhapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // chiTietNhapBindingSource
            // 
            this.chiTietNhapBindingSource.DataMember = "chiTietNhap";
            this.chiTietNhapBindingSource.DataSource = this.khoDuocDataSet;
            // 
            // khoDuocDataSet
            // 
            this.khoDuocDataSet.DataSetName = "KhoDuocDataSet";
            this.khoDuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietNhapTableAdapter
            // 
            this.chiTietNhapTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Location = new System.Drawing.Point(399, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(308, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 102;
            this.label6.Text = "Đơn giá";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(399, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 101;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(133, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 100;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(133, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(308, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 98;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "Mã thuốc";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Số phiếu";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Location = new System.Drawing.Point(474, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 95;
            this.button5.Text = "Làm mới";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(369, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 94;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(264, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 93;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(150, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 92;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(47, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sophieuDataGridViewTextBoxColumn
            // 
            this.sophieuDataGridViewTextBoxColumn.DataPropertyName = "sophieu";
            this.sophieuDataGridViewTextBoxColumn.HeaderText = "Số phiếu";
            this.sophieuDataGridViewTextBoxColumn.Name = "sophieuDataGridViewTextBoxColumn";
            this.sophieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.sophieuDataGridViewTextBoxColumn.Width = 110;
            // 
            // mathuocDataGridViewTextBoxColumn
            // 
            this.mathuocDataGridViewTextBoxColumn.DataPropertyName = "mathuoc";
            this.mathuocDataGridViewTextBoxColumn.HeaderText = "Mã thuốc";
            this.mathuocDataGridViewTextBoxColumn.Name = "mathuocDataGridViewTextBoxColumn";
            this.mathuocDataGridViewTextBoxColumn.ReadOnly = true;
            this.mathuocDataGridViewTextBoxColumn.Width = 110;
            // 
            // slDataGridViewTextBoxColumn
            // 
            this.slDataGridViewTextBoxColumn.DataPropertyName = "sl";
            this.slDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            this.slDataGridViewTextBoxColumn.ReadOnly = true;
            this.slDataGridViewTextBoxColumn.Width = 110;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            this.dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            this.dongiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            this.dongiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dongiaDataGridViewTextBoxColumn.Width = 120;
            // 
            // ChiTietNhapF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 408);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChiTietNhapF";
            this.Text = "Chi tiết phiếu nhập";
            this.Load += new System.EventHandler(this.ChiTietNhapF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KhoDuocDataSet khoDuocDataSet;
        private System.Windows.Forms.BindingSource chiTietNhapBindingSource;
        private KhoDuocDataSetTableAdapters.chiTietNhapTableAdapter chiTietNhapTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
    }
}