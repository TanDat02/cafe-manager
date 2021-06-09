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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsnv.DataSource = dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txttennv.Text==""||txtgioitinh.Text==""||txtdiachi.Text==""||txtsdt.Text==""||txtchucvu.Text==""||txttk.Text==""||txtmk.Text==""){
                MessageBox.Show("Chưa nhập đầy đủ thông tin!!!");
            }
            else
            {
                string sqlINSERT = "INSERT INTO NhanVien(tennv, ngaysinh, gioitinh, chucvu, diachi, sdt, Username, Password) VALUES (@tennv, @ngaysinh, @gioitinh, @chucvu, @diachi, @sdt, @Username, @Password)";
                string sql = @"INSERT INTO Account(Username,Password) 
                                    VALUES(@Username, @Password)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("tennv", txttennv.Text);
                cmd.Parameters.AddWithValue("ngaysinh", dtngaysinh.Value);
                cmd.Parameters.AddWithValue("gioitinh", txtgioitinh.Text);
                cmd.Parameters.AddWithValue("chucvu", txtchucvu.Text);
                cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
                cmd.Parameters.AddWithValue("sdt", txtsdt.Text);
                cmd.Parameters.AddWithValue("Username", txttk.Text);
                cmd.Parameters.AddWithValue("Password", txtmk.Text);

                insertTK();
                cmd.ExecuteNonQuery();
                HienThi();
                MessageBox.Show("Thêm thành công!");
                txttk.Text = "";
            }
        }

        private void insertTK()
        {
            string quyen = "staff";
            string sql = @"INSERT INTO Account(Username,Password, quyen) 
                                VALUES(@Username, @Password, @quyen)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", txttk.Text);
            cmd.Parameters.AddWithValue("@Password", txtmk.Text);
            cmd.Parameters.AddWithValue("@quyen", quyen);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txttennv.Text != "" || txtgioitinh.Text != "" || txtdiachi.Text != "" || txtsdt.Text != "" || txtchucvu.Text != "" || txttk.Text != "" || txtmk.Text != "")
           
            {
                updateTK();
                bool result = UpdateNV();
                if (result)
                {
                    MessageBox.Show("Sửa thành công");
                }
                HienThi();
            }
        }

        public bool UpdateNV()
        {
            string sqlEDIT = "UPDATE NhanVien SET tennv= @tennv, ngaysinh= @ngaysinh, gioitinh= @gioitinh, chucvu= @chucvu, diachi= @diachi, sdt= @sdt WHERE manv = @manv";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("manv", txtma.Text);
            cmd.Parameters.AddWithValue("tennv", txttennv.Text);
            cmd.Parameters.AddWithValue("ngaysinh", dtngaysinh.Value);
            cmd.Parameters.AddWithValue("gioitinh", txtgioitinh.Text);
            cmd.Parameters.AddWithValue("chucvu", txtchucvu.Text);
            cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
            cmd.Parameters.AddWithValue("sdt", txtsdt.Text);
            int result = cmd.ExecuteNonQuery();
            return (result >= 1);
        }

        private void updateTK()
        {
            string sqlEDIT = "UPDATE Account SET Username=@Username, Password= @Password WHERE  Username=@Username";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@Username", txttk.Text);
            cmd.Parameters.AddWithValue("@Password", txtmk.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bthxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                bool result = DeleteNV();
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                }
                HienThi();
            }
        }
        public bool DeleteNV()
        {
            string sqlDELETE = "DELETE FROM NhanVien WHERE manv= @manv";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@manv", txtma.Text);
            int result = cmd.ExecuteNonQuery();
            return (result >= 1);
        }
        private void deleteTK()
        {
            string sqlDELETE = "DELETE FROM Account WHERE Username= @user";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@user", txttk.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            GiaoDienChinh gdc = new GiaoDienChinh();
            gdc.Show();
            this.Hide();
        }
    }
}
