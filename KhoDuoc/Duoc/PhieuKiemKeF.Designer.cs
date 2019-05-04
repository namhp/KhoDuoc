namespace KhoDuoc
{
    partial class PhieuKiemKeF
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
            this.khoDuocDataSet = new KhoDuoc.KhoDuocDataSet();
            this.chiTietKiemKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietKiemKeTableAdapter = new KhoDuoc.KhoDuocDataSetTableAdapters.chiTietKiemKeTableAdapter();
            this.phieuKiemKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuKiemKeTableAdapter = new KhoDuoc.KhoDuocDataSetTableAdapters.phieuKiemKeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phieuKiemKeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
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
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykiemkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietKiemKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemKeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // khoDuocDataSet
            // 
            this.khoDuocDataSet.DataSetName = "KhoDuocDataSet";
            this.khoDuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietKiemKeBindingSource
            // 
            this.chiTietKiemKeBindingSource.DataMember = "chiTietKiemKe";
            this.chiTietKiemKeBindingSource.DataSource = this.khoDuocDataSet;
            // 
            // chiTietKiemKeTableAdapter
            // 
            this.chiTietKiemKeTableAdapter.ClearBeforeFill = true;
            // 
            // phieuKiemKeBindingSource
            // 
            this.phieuKiemKeBindingSource.DataMember = "phieuKiemKe";
            this.phieuKiemKeBindingSource.DataSource = this.khoDuocDataSet;
            // 
            // phieuKiemKeTableAdapter
            // 
            this.phieuKiemKeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sophieuDataGridViewTextBoxColumn,
            this.manvDataGridViewTextBoxColumn,
            this.ngaykiemkeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phieuKiemKeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // phieuKiemKeBindingSource1
            // 
            this.phieuKiemKeBindingSource1.DataMember = "phieuKiemKe";
            this.phieuKiemKeBindingSource1.DataSource = this.khoDuocDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(442, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 85;
            this.button6.Text = "Chi tiết lĩnh";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Số phiếu";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(442, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 78;
            this.button5.Text = "Làm mới";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 77;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 76;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sophieuDataGridViewTextBoxColumn
            // 
            this.sophieuDataGridViewTextBoxColumn.DataPropertyName = "sophieu";
            this.sophieuDataGridViewTextBoxColumn.HeaderText = "Số phiếu";
            this.sophieuDataGridViewTextBoxColumn.Name = "sophieuDataGridViewTextBoxColumn";
            this.sophieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.sophieuDataGridViewTextBoxColumn.Width = 120;
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            this.manvDataGridViewTextBoxColumn.ReadOnly = true;
            this.manvDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngaykiemkeDataGridViewTextBoxColumn
            // 
            this.ngaykiemkeDataGridViewTextBoxColumn.DataPropertyName = "ngaykiemke";
            this.ngaykiemkeDataGridViewTextBoxColumn.HeaderText = "Ngày kiểm kê";
            this.ngaykiemkeDataGridViewTextBoxColumn.Name = "ngaykiemkeDataGridViewTextBoxColumn";
            this.ngaykiemkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaykiemkeDataGridViewTextBoxColumn.Width = 150;
            // 
            // PhieuKiemKeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 355);
            this.Controls.Add(this.button6);
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
            this.Name = "PhieuKiemKeF";
            this.Text = "Quản lý kiểm kê";
            this.Load += new System.EventHandler(this.PhieuKiemKeF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietKiemKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuKiemKeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KhoDuocDataSet khoDuocDataSet;
        private System.Windows.Forms.BindingSource chiTietKiemKeBindingSource;
        private KhoDuocDataSetTableAdapters.chiTietKiemKeTableAdapter chiTietKiemKeTableAdapter;
        private System.Windows.Forms.BindingSource phieuKiemKeBindingSource;
        private KhoDuocDataSetTableAdapters.phieuKiemKeTableAdapter phieuKiemKeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource phieuKiemKeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykiemkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
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
    }
}