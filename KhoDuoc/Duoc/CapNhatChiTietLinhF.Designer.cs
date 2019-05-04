namespace KhoDuoc
{
    partial class CapNhatChiTietLinhF
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chiTietLinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoDuocDataSet = new KhoDuoc.KhoDuocDataSet();
            this.chiTietLinhTableAdapter = new KhoDuoc.KhoDuocDataSetTableAdapters.chiTietLinhTableAdapter();
            this.sophieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slycDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietLinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(157, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(157, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(157, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Số lượng phát";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Mã thuốc";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Số phiếu";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Location = new System.Drawing.Point(558, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 78;
            this.button5.Text = "Làm mới";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(558, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 77;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(456, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 76;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(456, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
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
            this.slycDataGridViewTextBoxColumn,
            this.slpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietLinhBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 200);
            this.dataGridView1.TabIndex = 73;
            // 
            // chiTietLinhBindingSource
            // 
            this.chiTietLinhBindingSource.DataMember = "chiTietLinh";
            this.chiTietLinhBindingSource.DataSource = this.khoDuocDataSet;
            // 
            // khoDuocDataSet
            // 
            this.khoDuocDataSet.DataSetName = "KhoDuocDataSet";
            this.khoDuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietLinhTableAdapter
            // 
            this.chiTietLinhTableAdapter.ClearBeforeFill = true;
            // 
            // sophieuDataGridViewTextBoxColumn
            // 
            this.sophieuDataGridViewTextBoxColumn.DataPropertyName = "sophieu";
            this.sophieuDataGridViewTextBoxColumn.HeaderText = "Số phiếu";
            this.sophieuDataGridViewTextBoxColumn.Name = "sophieuDataGridViewTextBoxColumn";
            this.sophieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mathuocDataGridViewTextBoxColumn
            // 
            this.mathuocDataGridViewTextBoxColumn.DataPropertyName = "mathuoc";
            this.mathuocDataGridViewTextBoxColumn.HeaderText = "Mã thuốc";
            this.mathuocDataGridViewTextBoxColumn.Name = "mathuocDataGridViewTextBoxColumn";
            this.mathuocDataGridViewTextBoxColumn.ReadOnly = true;
            this.mathuocDataGridViewTextBoxColumn.Width = 150;
            // 
            // slycDataGridViewTextBoxColumn
            // 
            this.slycDataGridViewTextBoxColumn.DataPropertyName = "slyc";
            this.slycDataGridViewTextBoxColumn.HeaderText = "Số lượng yêu cầu";
            this.slycDataGridViewTextBoxColumn.Name = "slycDataGridViewTextBoxColumn";
            this.slycDataGridViewTextBoxColumn.ReadOnly = true;
            this.slycDataGridViewTextBoxColumn.Width = 150;
            // 
            // slpDataGridViewTextBoxColumn
            // 
            this.slpDataGridViewTextBoxColumn.DataPropertyName = "slp";
            this.slpDataGridViewTextBoxColumn.HeaderText = "Số lượng phát";
            this.slpDataGridViewTextBoxColumn.Name = "slpDataGridViewTextBoxColumn";
            this.slpDataGridViewTextBoxColumn.ReadOnly = true;
            this.slpDataGridViewTextBoxColumn.Width = 150;
            // 
            // CapNhatChiTietLinhF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 376);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "CapNhatChiTietLinhF";
            this.Text = "CapNhatChiTietLinhF";
            this.Load += new System.EventHandler(this.CapNhatChiTietLinhF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietLinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoDuocDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private KhoDuocDataSet khoDuocDataSet;
        private System.Windows.Forms.BindingSource chiTietLinhBindingSource;
        private KhoDuocDataSetTableAdapters.chiTietLinhTableAdapter chiTietLinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slycDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slpDataGridViewTextBoxColumn;
    }
}