namespace QuanLyQuanCafe
{
    partial class DThang
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
            this.PhieuTamTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntong = new System.Windows.Forms.Button();
            this.btnthang = new System.Windows.Forms.Button();
            this.btntuan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.frmthongke = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntongdoanhthu = new System.Windows.Forms.Button();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btntong);
            this.panel1.Controls.Add(this.btnthang);
            this.panel1.Controls.Add(this.btntuan);
            this.panel1.Location = new System.Drawing.Point(-2, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 85);
            this.panel1.TabIndex = 2;
            // 
            // btntong
            // 
            this.btntong.BackColor = System.Drawing.SystemColors.Control;
            this.btntong.Location = new System.Drawing.Point(775, 2);
            this.btntong.Margin = new System.Windows.Forms.Padding(2);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(82, 62);
            this.btntong.TabIndex = 2;
            this.btntong.Text = "Tổng doanh thu";
            this.btntong.UseVisualStyleBackColor = false;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnthang
            // 
            this.btnthang.BackColor = System.Drawing.Color.Blue;
            this.btnthang.Location = new System.Drawing.Point(641, 2);
            this.btnthang.Margin = new System.Windows.Forms.Padding(2);
            this.btnthang.Name = "btnthang";
            this.btnthang.Size = new System.Drawing.Size(82, 62);
            this.btnthang.TabIndex = 1;
            this.btnthang.Text = "Doanh thu tháng";
            this.btnthang.UseVisualStyleBackColor = false;
            this.btnthang.Click += new System.EventHandler(this.btnthang_Click);
            // 
            // btntuan
            // 
            this.btntuan.Location = new System.Drawing.Point(518, 0);
            this.btntuan.Margin = new System.Windows.Forms.Padding(2);
            this.btntuan.Name = "btntuan";
            this.btntuan.Size = new System.Drawing.Size(88, 64);
            this.btntuan.TabIndex = 0;
            this.btntuan.Text = "Doanh thu ngày";
            this.btntuan.UseVisualStyleBackColor = true;
            this.btntuan.Click += new System.EventHandler(this.btntuan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vùng quản lí";
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.Location = new System.Drawing.Point(392, 110);
            this.lblDoanhthu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(113, 13);
            this.lblDoanhthu.TabIndex = 4;
            this.lblDoanhthu.Text = "DOANH THU THÁNG";
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
            this.frmthongke.Location = new System.Drawing.Point(1, 127);
            this.frmthongke.Name = "frmthongke";
            this.frmthongke.RowHeadersWidth = 51;
            this.frmthongke.Size = new System.Drawing.Size(968, 237);
            this.frmthongke.TabIndex = 13;
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
            this.btntongdoanhthu.Location = new System.Drawing.Point(592, 369);
            this.btntongdoanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.btntongdoanhthu.Name = "btntongdoanhthu";
            this.btntongdoanhthu.Size = new System.Drawing.Size(130, 20);
            this.btntongdoanhthu.TabIndex = 17;
            this.btntongdoanhthu.Text = "Tổng doanh thu :";
            this.btntongdoanhthu.UseVisualStyleBackColor = true;
            this.btntongdoanhthu.Click += new System.EventHandler(this.btntongdoanhthu_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(755, 370);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(215, 20);
            this.txttongtien.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1, 378);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 45);
            this.btnIn.TabIndex = 15;
            this.btnIn.Text = "In ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click_1);
            // 
            // DThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 456);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.btntongdoanhthu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.frmthongke);
            this.Controls.Add(this.lblDoanhthu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DThang";
            this.Text = "Doanh Thu Tháng";
            this.Load += new System.EventHandler(this.DThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTamTinhBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmthongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnthang;
        private System.Windows.Forms.Button btntuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoanhthu;
        private System.Windows.Forms.DataGridView frmthongke;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btntongdoanhthu;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.BindingSource PhieuTamTinhBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}