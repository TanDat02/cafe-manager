using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace ThanhToan
{
    public partial class GiaoDienThanhToan : Form
    {
        public GiaoDienThanhToan()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=PC;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select PhieuTamTinh.ngayban,Menu.tensp, ChiTietTamTinh.soluong, Menu.giaban, ChiTietTamTinh.thanhtien from PhieuTamTinh, Menu, ChiTietTamTinh where PhieuTamTinh.sohoadon = ChiTietTamTinh.sohoadon AND Menu.masp = ChiTietTamTinh.masp; ";
            SqlCommand coom = new SqlCommand(sql, cnn);
            coom.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(coom);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            frmthongke.DataSource = dt;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PhieuTamTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntong = new System.Windows.Forms.Button();
            this.btnthang = new System.Windows.Forms.Button();
            this.btntuan = new System.Windows.Forms.Button();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btntongdoanhthu = new System.Windows.Forms.Button();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.frmthongke = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTamTinhBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // PhieuTamTinhBindingSource
            // 
            this.PhieuTamTinhBindingSource.DataMember = "PhieuTamTinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vùng quản lí";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntong);
            this.panel1.Controls.Add(this.btnthang);
            this.panel1.Controls.Add(this.btntuan);
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 115);
            this.panel1.TabIndex = 1;
            // 
            // btntong
            // 
            this.btntong.Image = global::ThanhToan.Properties.Resources.icon_doanh_thu;
            this.btntong.Location = new System.Drawing.Point(862, 38);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(133, 46);
            this.btntong.TabIndex = 2;
            this.btntong.Text = "Tổng doanh thu";
            this.btntong.UseVisualStyleBackColor = true;
            // 
            // btnthang
            // 
            this.btnthang.Image = global::ThanhToan.Properties.Resources.icon_doanh_thu;
            this.btnthang.Location = new System.Drawing.Point(695, 38);
            this.btnthang.Name = "btnthang";
            this.btnthang.Size = new System.Drawing.Size(137, 46);
            this.btnthang.TabIndex = 1;
            this.btnthang.Text = "Doanh thu tháng";
            this.btnthang.UseVisualStyleBackColor = true;
            // 
            // btntuan
            // 
            this.btntuan.Image = global::ThanhToan.Properties.Resources.icon_doanh_thu;
            this.btntuan.Location = new System.Drawing.Point(527, 38);
            this.btntuan.Name = "btntuan";
            this.btntuan.Size = new System.Drawing.Size(129, 46);
            this.btntuan.TabIndex = 0;
            this.btntuan.Text = "Doanh thu ngày";
            this.btntuan.UseVisualStyleBackColor = true;
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.Location = new System.Drawing.Point(455, 154);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(134, 17);
            this.lblDoanhthu.TabIndex = 3;
            this.lblDoanhthu.Text = "DOANH THU NGÀY";
            // 
            // btnIn
            // 
            this.btnIn.Image = global::ThanhToan.Properties.Resources.Print_Button_printer_5122;
            this.btnIn.Location = new System.Drawing.Point(3, 480);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 46);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ThanhToan.Properties.Resources.tải_xuống__1_;
            this.button2.Location = new System.Drawing.Point(144, 479);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntongdoanhthu
            // 
            this.btntongdoanhthu.Location = new System.Drawing.Point(698, 481);
            this.btntongdoanhthu.Name = "btntongdoanhthu";
            this.btntongdoanhthu.Size = new System.Drawing.Size(174, 25);
            this.btntongdoanhthu.TabIndex = 10;
            this.btntongdoanhthu.Text = "Tổng doanh thu :";
            this.btntongdoanhthu.UseVisualStyleBackColor = true;
            this.btntongdoanhthu.Click += new System.EventHandler(this.btntongdoanhthu_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(878, 481);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(202, 22);
            this.txttongtien.TabIndex = 11;
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
            this.frmthongke.Location = new System.Drawing.Point(3, 175);
            this.frmthongke.Margin = new System.Windows.Forms.Padding(4);
            this.frmthongke.Name = "frmthongke";
            this.frmthongke.RowHeadersWidth = 51;
            this.frmthongke.Size = new System.Drawing.Size(1077, 292);
            this.frmthongke.TabIndex = 12;
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
            // GiaoDienThanhToan
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 569);
            this.Controls.Add(this.frmthongke);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.btntongdoanhthu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblDoanhthu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GiaoDienThanhToan";
            this.Text = "Doanh Thu Ngày";
            this.Load += new System.EventHandler(this.GiaoDienThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTamTinhBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmthongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GiaoDienThanhToan_Load(object sender, EventArgs e)
        {
             //TODO: This line of code loads data into the 'DataSet1.PhieuTamTinh' table. You can move, or remove it, as needed.
           // this.PhieuTamTinhTableAdapter.Fill(this.DataSet1.PhieuTamTinh);
            ketnoicsdl();
            //this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formthongke f1 = new formthongke();
            f1.Show();
            this.Hide();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            PrintDocument p2 = new PrintDocument();

            p2.DocumentName = "In Hoa Don";
            dlg.Document = p2;
            dlg.AllowSelection = true;
            dlg.AllowSomePages = true;

            if (dlg.ShowDialog() == DialogResult.OK)
                p2.Print();
        }

        private void btntongdoanhthu_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection drc = frmthongke.Rows;
            int intTongCong = 0;
            foreach (DataGridViewRow dr in drc)
            {
                intTongCong += Convert.ToInt32(dr.Cells[4].Value);
            }
            txttongtien.Text = intTongCong.ToString();
        }

        private void frmthongke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.frmthongke.Rows[e.RowIndex];
                //Dua du lieu vao
                txttongtien.Text = row.Cells[4].Value.ToString();

            }
            //khong cho phep sua truong
            txttongtien.Enabled = false;
            //Tinh tong tien
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            //this.PhieuTamTinhTableAdapter.Fill(this.DataSet1.PhieuTamTinh);
            //this.reportViewer1.RefreshReport();
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
