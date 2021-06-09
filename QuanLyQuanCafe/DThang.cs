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

namespace QuanLyQuanCafe
{
    public partial class DThang : Form
    {
        public DThang()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
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

        private void DThang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btnthang_Click(object sender, EventArgs e)
        {
            DThang dt = new DThang();
            this.Show();
            dt.Hide();
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            GTTongdoanhthu dt = new GTTongdoanhthu();
            dt.Show();
            this.Hide();
        }

        private void btntuan_Click(object sender, EventArgs e)
        {
            GTNgay gt = new GTNgay();
            gt.Show();
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.Show();
            this.Hide();
        }

        private void btnIn_Click_1(object sender, EventArgs e)
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
    }
}
