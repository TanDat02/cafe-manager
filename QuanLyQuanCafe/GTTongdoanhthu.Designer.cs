namespace QuanLyQuanCafe
{
    partial class GTTongdoanhthu
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView frmthongke;
        private System.Windows.Forms.Button btntongdoanhthu;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txttongtuan;
        private System.Windows.Forms.TextBox txttongthang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource PhieuTamTinhBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PhieuTamTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frmthongke = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntongdoanhthu = new System.Windows.Forms.Button();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txttongtuan = new System.Windows.Forms.TextBox();
            this.txttongthang = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTamTinhBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // PhieuTamTinhBindingSource
            // 
            this.PhieuTamTinhBindingSource.DataMember = "PhieuTamTinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vùng quản lí";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 72);
            this.panel1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(859, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Tổng doanh thu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(721, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Doanh thu tháng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Doanh thu ngày";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TỔNG DOANH THU";
            // 
            // frmthongke
            // 
            this.frmthongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.frmthongke.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.frmthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmthongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.frmthongke.Location = new System.Drawing.Point(1, 129);
            this.frmthongke.Name = "frmthongke";
            this.frmthongke.RowHeadersWidth = 51;
            this.frmthongke.Size = new System.Drawing.Size(1021, 353);
            this.frmthongke.TabIndex = 13;
            this.frmthongke.CellBorderStyleChanged += new System.EventHandler(this.frmthongke_CellBorderStyleChanged);
            this.frmthongke.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frmthongke_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ngayban";
            this.Column1.HeaderText = "Ngày bán";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tensp";
            this.Column2.HeaderText = "Tên món";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soluong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "giaban";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thanhtien";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btntongdoanhthu
            // 
            this.btntongdoanhthu.Location = new System.Drawing.Point(680, 505);
            this.btntongdoanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.btntongdoanhthu.Name = "btntongdoanhthu";
            this.btntongdoanhthu.Size = new System.Drawing.Size(130, 20);
            this.btntongdoanhthu.TabIndex = 14;
            this.btntongdoanhthu.Text = "Tổng doanh thu :";
            this.btntongdoanhthu.UseVisualStyleBackColor = true;
            this.btntongdoanhthu.Click += new System.EventHandler(this.btntongdoanhthu_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(842, 507);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(128, 20);
            this.txttongtien.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 20);
            this.button2.TabIndex = 16;
            this.button2.Text = "Tổng doanh thu ngày :";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 502);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 20);
            this.button5.TabIndex = 17;
            this.button5.Text = "Tổng doanh thu tháng :";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txttongtuan
            // 
            this.txttongtuan.Location = new System.Drawing.Point(148, 502);
            this.txttongtuan.Margin = new System.Windows.Forms.Padding(2);
            this.txttongtuan.Name = "txttongtuan";
            this.txttongtuan.Size = new System.Drawing.Size(128, 20);
            this.txttongtuan.TabIndex = 18;
            // 
            // txttongthang
            // 
            this.txttongthang.Location = new System.Drawing.Point(504, 505);
            this.txttongthang.Margin = new System.Windows.Forms.Padding(2);
            this.txttongthang.Name = "txttongthang";
            this.txttongthang.Size = new System.Drawing.Size(128, 20);
            this.txttongthang.TabIndex = 19;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(902, 552);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 31);
            this.button6.TabIndex = 22;
            this.button6.Text = "Quay lại";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(807, 552);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(81, 31);
            this.btnIn.TabIndex = 21;
            this.btnIn.Text = "In ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // GTTongdoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 596);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txttongthang);
            this.Controls.Add(this.txttongtuan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.btntongdoanhthu);
            this.Controls.Add(this.frmthongke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GTTongdoanhthu";
            this.Text = "Tổng Doanh Thu";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTamTinhBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmthongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}