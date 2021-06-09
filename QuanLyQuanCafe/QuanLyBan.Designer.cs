namespace QuanLyQuanCafe
{
    partial class QuanLyBan
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
            this.banBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nmThemMon = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbSanpham = new System.Windows.Forms.ComboBox();
            this.cbbDanhmuc = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmThemMon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // banBindingSource
            // 
            this.banBindingSource.DataMember = "Ban";
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.BackColor = System.Drawing.Color.Transparent;
            this.flpBan.Location = new System.Drawing.Point(9, 10);
            this.flpBan.Margin = new System.Windows.Forms.Padding(2);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(440, 400);
            this.flpBan.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtTennhanvien);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.nmThemMon);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.cbbSanpham);
            this.groupBox2.Controls.Add(this.cbbDanhmuc);
            this.groupBox2.Location = new System.Drawing.Point(453, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(471, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Enabled = false;
            this.txtTennhanvien.Location = new System.Drawing.Point(362, 35);
            this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(100, 20);
            this.txtTennhanvien.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Nhân viên bán hàng";
            // 
            // nmThemMon
            // 
            this.nmThemMon.Location = new System.Drawing.Point(314, 23);
            this.nmThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.nmThemMon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmThemMon.Name = "nmThemMon";
            this.nmThemMon.Size = new System.Drawing.Size(29, 20);
            this.nmThemMon.TabIndex = 9;
            this.nmThemMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(244, 10);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 42);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm món";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbSanpham
            // 
            this.cbbSanpham.FormattingEnabled = true;
            this.cbbSanpham.Location = new System.Drawing.Point(4, 32);
            this.cbbSanpham.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSanpham.Name = "cbbSanpham";
            this.cbbSanpham.Size = new System.Drawing.Size(236, 21);
            this.cbbSanpham.TabIndex = 8;
            // 
            // cbbDanhmuc
            // 
            this.cbbDanhmuc.FormattingEnabled = true;
            this.cbbDanhmuc.Location = new System.Drawing.Point(4, 8);
            this.cbbDanhmuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDanhmuc.Name = "cbbDanhmuc";
            this.cbbDanhmuc.Size = new System.Drawing.Size(236, 21);
            this.cbbDanhmuc.TabIndex = 7;
            this.cbbDanhmuc.SelectedIndexChanged += new System.EventHandler(this.cbbDanhmuc_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.btnThanhtoan);
            this.panel2.Location = new System.Drawing.Point(618, 366);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 54);
            this.panel2.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(21, 18);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(97, 24);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(134, 9);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(76, 42);
            this.btnThanhtoan.TabIndex = 11;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.Location = new System.Drawing.Point(453, 74);
            this.lvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(472, 288);
            this.lvHoaDon.TabIndex = 12;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Sản phẩm";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Danh Mục";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Vị Tính";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá Bán";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành Tiền";
            this.columnHeader6.Width = 86;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuaylai.Location = new System.Drawing.Point(838, 375);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(76, 42);
            this.btnQuaylai.TabIndex = 13;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // QuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.Inkedat3_LI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 510);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flpBan);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyBan";
            this.Text = "Quản lý Bàn";
            this.Load += new System.EventHandler(this.QuanLyBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmThemMon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbSanpham;
        private System.Windows.Forms.ComboBox cbbDanhmuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.ListView lvHoaDon;
      //  private QuanLyQuanCafeDataSet1 quanLyQuanCafeDataSet1;
        private System.Windows.Forms.BindingSource banBindingSource;
      //  private QuanLyQuanCafeDataSet1TableAdapters.BanTableAdapter banTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.NumericUpDown nmThemMon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.TextBox txtTennhanvien;
    }
}