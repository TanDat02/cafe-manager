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
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class FormDangNhap : Form
    {
        public static string tenNv;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        //Khai bao doi tuong Connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");


        public class Luu
        {
            static public string User;
            static public string Quyen;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool btnDangNhap = false;
            SqlDataReader rdr = null;
            try
            {
                conn.Open();//Mo ket noi sql
                SqlCommand cmd = new SqlCommand("select * from Account", conn);//Tao doi tuong sqlCommand de select tat ca du lieu bang Account
                rdr = cmd.ExecuteReader();//Lay du lieu tu cau lenh select
                while (rdr.Read())//Thuc hien vong lap de duyet du lieu
                {
                    if ((txtTenDN.Text.Trim() == rdr["Username"].ToString().Trim()) &&
                        txtMatKhau.Text.Trim() == rdr["Password"].ToString().Trim())//Neu ten dang nhap va mat khau trung voi csdl thì
                    {
                        btnDangNhap = true;//Button DangNhap=true
                        Luu.Quyen = rdr["quyen"].ToString().Trim();
                        foreach (NhanVien item in NhanVienDAO.Instance.layDanhsachnhanvien())
                        {
                            if (item.Username.Trim() == txtTenDN.Text.Trim())
                            {
                                tenNv = item.TenNV;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)//Neu qua trinh mo va thuc hien lenh sai thi bao loi
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                return;
            }
            finally//Dong ca ket noi
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            if(txtTenDN.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (btnDangNhap == false)//Neu button DangNhap=false thi bao loi
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
            else//Nguoc lai hien form QuanLyNhaTro
            {
                Luu.User = txtTenDN.Text;
                GiaoDienChinh gdc = new GiaoDienChinh();
                gdc.Show();
                this.Hide();
            }
        }

    }
}
