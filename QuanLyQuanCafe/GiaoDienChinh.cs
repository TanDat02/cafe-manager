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

namespace QuanLyQuanCafe
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
            lblTen.Text = FormDangNhap.Luu.User;
            LoadTable();
        }

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() {Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name;

                switch(item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Green;
                        break;
                }

                flbTable.Controls.Add(btn);
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Hide();
        }

        private void btnTKSP_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.Luu.Quyen == "admin")
            {
                ThongKeSP tksp = new ThongKeSP();
                tksp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ ADMIN mới sử dụng được chức năng!!!");
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.Luu.Quyen == "admin")
            {
                QuanLyNhanVien nv = new QuanLyNhanVien();
                nv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ ADMIN mới sử dụng được chức năng này!!!");
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            QuanLyBan qlban = new QuanLyBan();
            qlban.Show();
            this.Hide();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.Luu.Quyen == "admin")
            {
                GTNgay dt = new GTNgay();
                dt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ ADMIN mới sử dụng được chức năng này!!!"); 
            }
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.Luu.Quyen == "admin")
            {
                QuanLyMenu menu = new QuanLyMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ ADMIN mới sử dụng được chức năng này!!!");
            }
        }
    }
}
