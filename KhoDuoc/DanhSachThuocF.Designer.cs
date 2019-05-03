namespace KhoDuoc
{
    partial class DanhSachThuocF
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
            this.khoDuocDataSet = new KhoDuoc.KhoDuocDataSet();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuocTableAdapter = new KhoDuoc.KhoDuocDataSetTableAdapters.thuocTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mathuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndhlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdkgpdkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noisxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathuocDataGridViewTextBoxColumn,
            this.tenthuocDataGridViewTextBoxColumn,
            this.ndhlDataGridViewTextBoxColumn,
            this.sdkgpdkDataGridViewTextBoxColumn,
            this.noisxDataGridViewTextBoxColumn,
            this.dvtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thuocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // khoDuocDataSet
            // 
            this.khoDuocDataSet.DataSetName = "KhoDuocDataSet";
            this.khoDuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataMember = "thuoc";
            this.thuocBindingSource.DataSource = this.khoDuocDataSet;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(134, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(134, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 55;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Location = new System.Drawing.Point(428, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 57;
            this.button5.Text = "Làm mới";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(428, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 56;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mathuocDataGridViewTextBoxColumn
            // 
            this.mathuocDataGridViewTextBoxColumn.DataPropertyName = "mathuoc";
            this.mathuocDataGridViewTextBoxColumn.HeaderText = "Mã thuốc";
            this.mathuocDataGridViewTextBoxColumn.Name = "mathuocDataGridViewTextBoxColumn";
            this.mathuocDataGridViewTextBoxColumn.ReadOnly = true;
            this.mathuocDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenthuocDataGridViewTextBoxColumn
            // 
            this.tenthuocDataGridViewTextBoxColumn.DataPropertyName = "tenthuoc";
            this.tenthuocDataGridViewTextBoxColumn.HeaderText = "Tên thuốc";
            this.tenthuocDataGridViewTextBoxColumn.Name = "tenthuocDataGridViewTextBoxColumn";
            this.tenthuocDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenthuocDataGridViewTextBoxColumn.Width = 120;
            // 
            // ndhlDataGridViewTextBoxColumn
            // 
            this.ndhlDataGridViewTextBoxColumn.DataPropertyName = "ndhl";
            this.ndhlDataGridViewTextBoxColumn.HeaderText = "Nồng độ, hàm lượng";
            this.ndhlDataGridViewTextBoxColumn.Name = "ndhlDataGridViewTextBoxColumn";
            this.ndhlDataGridViewTextBoxColumn.ReadOnly = true;
            this.ndhlDataGridViewTextBoxColumn.Width = 130;
            // 
            // sdkgpdkDataGridViewTextBoxColumn
            // 
            this.sdkgpdkDataGridViewTextBoxColumn.DataPropertyName = "sdkgpdk";
            this.sdkgpdkDataGridViewTextBoxColumn.HeaderText = "Số đăng ký";
            this.sdkgpdkDataGridViewTextBoxColumn.Name = "sdkgpdkDataGridViewTextBoxColumn";
            this.sdkgpdkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noisxDataGridViewTextBoxColumn
            // 
            this.noisxDataGridViewTextBoxColumn.DataPropertyName = "noisx";
            this.noisxDataGridViewTextBoxColumn.HeaderText = "Nơi sản xuất";
            this.noisxDataGridViewTextBoxColumn.Name = "noisxDataGridViewTextBoxColumn";
            this.noisxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvtDataGridViewTextBoxColumn
            // 
            this.dvtDataGridViewTextBoxColumn.DataPropertyName = "dvt";
            this.dvtDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dvtDataGridViewTextBoxColumn.Name = "dvtDataGridViewTextBoxColumn";
            this.dvtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DanhSachThuocF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 350);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachThuocF";
            this.Text = "DanhSachThuocF";
            this.Load += new System.EventHandler(this.DanhSachThuocF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KhoDuocDataSet khoDuocDataSet;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private KhoDuocDataSetTableAdapters.thuocTableAdapter thuocTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndhlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdkgpdkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noisxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}