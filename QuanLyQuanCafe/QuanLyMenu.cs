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
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class QuanLyMenu : Form
    {
        public QuanLyMenu()
        {
            InitializeComponent();
            //LoadIDDanhMuc();
            LoadDanhSachDanhMucTuIDDanhMuc();
        }
        private void QuanLyMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCafeDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.quanLyQuanCafeDataSet.Menu);
            hienThi();
        }

        public void hienThi()
        {

            dgrvDanhsachsp.DataSource = GetAllThucDon().Tables[0];//lấy thông tin sinh viên từ bảng đầu tiên vào datagridview
            dgrvDanhsachsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvDanhsachsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public DataSet GetAllThucDon()
        {
            DataSet data = new DataSet();//tạo đối tượng dataset để chứa dữ liệu từ database
            string sql = "SELECT * FROM Menu";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"))//sau khi dùng xong là hủy
            {
                connection.Open();
                SqlDataAdapter adater = new SqlDataAdapter(sql, connection);//tạo đối tượng sqldataadapter để làm cầu nối kết nối giũa dataset và database
                adater.Fill(data);//đổ dữ liệu vào dataset
                connection.Close();
            }
            return data;
        }
        private void pbThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống?", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void pbThem_Click(object sender, EventArgs e)
        {
            bool OK = true;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Menu", conn);//tạo dối tượng cmd đưa câu truy vấn vào
                rdr = cmd.ExecuteReader();//thực thi đối tượng cmd để tạo ra đối tượng rdr để bắt đầu đọc dũ liệu
                while (rdr.Read())
                {
                    if ((txtMasanpham.Text.Trim() == rdr["masp"].ToString().Trim()))
                        OK = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
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
            if (OK == false)
                MessageBox.Show("Sản phẩm này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (txtTensanpham.Text != "" && cbbiddanhmuc.Text != "" && cbbDanhmuc.Text != "" && cbbDonvitinh.Text != "" &&
                    txtGiaban.Text != "")
                {
                    conn.Open();
                    //thực hiện câu truy vấn để chèn dữ liệu vào
                    string sql = "INSERT INTO Menu VALUES(@tensp,@iddanhmuc,@danhmuc,@donvitinh,@giaban) ";
                    SqlCommand cmd = new SqlCommand(sql, conn);//tạo dối tượng cmd đưa câu truy vấn vào 
                    // cmd.Parameters.AddWithValue("idsp", txtTensanpham.Text);
                    cmd.Parameters.AddWithValue("tensp", txtTensanpham.Text);
                    cmd.Parameters.AddWithValue("iddanhmuc", cbbiddanhmuc.Text);
                    cmd.Parameters.AddWithValue("danhmuc", cbbDanhmuc.Text);
                    cmd.Parameters.AddWithValue("donvitinh", cbbDonvitinh.Text);
                    cmd.Parameters.AddWithValue("giaban", txtGiaban.Text);
                    cmd.ExecuteNonQuery();//thực thi đối tượng cmd nhưng không trả về kết quả
                    hienThi();
                    MessageBox.Show("Đã thêm sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                else

                    if (txtTensanpham.Text == "")
                    {
                        MessageBox.Show("Tên sản phẩm không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTensanpham.Focus();
                    }
                    else
                        if (cbbiddanhmuc.Text == "")
                        {
                            MessageBox.Show("ID danh mục không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbbiddanhmuc.Focus();
                        }
                        else
                            if (cbbDanhmuc.Text == "")
                            {
                                MessageBox.Show("Danh mục không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cbbDanhmuc.Focus();
                            }
                            else
                                if (cbbDonvitinh.Text == "")
                                {
                                    MessageBox.Show("Đơn vị tính không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    cbbDonvitinh.Focus();
                                }
                                else
                                    if (txtGiaban.Text == "")
                                    {
                                        MessageBox.Show("Giá bán không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtGiaban.Focus();
                                    }
            }
        }

        private void pbSua_Click(object sender, EventArgs e)
        {
            // using (@"Data Source=LAPTOP-OOMDE77C\DINHVANPHAP;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"))
            // {
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin Sản phẩm này!", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                bool OK = true;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
                SqlDataReader rdr = null;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Menu", conn);//tạo dối tượng cmd đưa câu truy vấn vào
                    rdr = cmd.ExecuteReader();//thực thi đối tượng cmd để tạo ra đối tượng rdr để bắt đầu đọc dũ liệu
                    while (rdr.Read())
                    {
                        if ((txtMasanpham.Text.Trim() == rdr["masp"].ToString().Trim()))
                            OK = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
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
                if (OK == true)
                    MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    conn.Open();
                    string sql = "UPDATE Menu SET tensp=@tensp,iddanhmuc=@iddanhmuc,danhmuc=@danhmuc,donvitinh=@donvitinh,giaban=@giaban WHERE masp=@masp";
                    SqlCommand cmd = new SqlCommand(sql, conn);//tạo dối tượng cmd đưa câu truy vấn vào
                    cmd.Parameters.AddWithValue("masp", txtMasanpham.Text);
                    cmd.Parameters.AddWithValue("tensp", txtTensanpham.Text);
                    cmd.Parameters.AddWithValue("iddanhmuc", cbbiddanhmuc.SelectedValue);
                    cmd.Parameters.AddWithValue("danhmuc", cbbDanhmuc.SelectedValue);
                    cmd.Parameters.AddWithValue("donvitinh", cbbDonvitinh.SelectedItem);
                    cmd.Parameters.AddWithValue("giaban", txtGiaban.Text);
                    cmd.ExecuteNonQuery();//thực thi đối tượng cmd nhưng không trả về kết quả
                    hienThi();
                    MessageBox.Show("Đã cập nhật thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    // }
                }
                if (txtTensanpham.Text == "")
                {
                    MessageBox.Show("Tên sản phẩm không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTensanpham.Focus();
                }
                else
                    if (cbbiddanhmuc.Text == "")
                    {
                        MessageBox.Show("ID danh mục không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbbiddanhmuc.Focus();
                    }
                    else
                        if (cbbDanhmuc.Text == "")
                        {
                            MessageBox.Show("Danh mục không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbbDanhmuc.Focus();
                        }
                        else
                            if (cbbDonvitinh.Text == "")
                            {
                                MessageBox.Show("Đơn vị tính không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cbbDonvitinh.Focus();
                            }
                            else
                                if (txtGiaban.Text == "")
                                {
                                    MessageBox.Show("Giá bán không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtGiaban.Focus();
                        }
            }
        }

        private void pbXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                bool OK = true;
                using (SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"))
                {
                    SqlDataReader rdr = null;
                    try
                    {
                        strcon.Open();//Mở kết nối
                        SqlCommand cmd = new SqlCommand("select * from Menu", strcon);//tạo dối tượng com đưa câu truy vấn vào
                        rdr = cmd.ExecuteReader();//thực thi đối tượng cmd để tạo ra đối tượng rdr để bắt đầu đọc dũ liệu
                        while (rdr.Read())//đọc dữ liệu kết quả trả về là từng dòng
                        {
                            if ((txtMasanpham.Text.Trim() == rdr["masp"].ToString().Trim()))
                                OK = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối CSDL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        if (rdr != null)
                        {
                            rdr.Close();
                        }
                        if (strcon != null)
                        {
                            strcon.Close();
                        }
                    }
                    if (OK == true)
                        MessageBox.Show("Sản phẩm này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                    {
                        strcon.Open();
                        string masp = txtMasanpham.Text;
                        //thực hiện câu truy vấn để xóa điều kiện mã SV = nội dung nhập vào từ textbox
                        string sql = "DELETE from Menu WHERE masp='" + masp + "'";
                        SqlCommand cmd = new SqlCommand(sql, strcon);//tạo dối tượng cmd đưa câu truy vấn vào
                        cmd.ExecuteNonQuery();//thực thi đối tượng cmd nhưng không trả về kết quả
                        hienThi();
                        MessageBox.Show("Đã xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        strcon.Close();
                    }
                }
            }
        }

        private void pbTimkiem_Click(object sender, EventArgs e)
        {
            bool OK = true;
            using (SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-PLUDMID\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"))
            {
                SqlDataReader dr = null;
                try
                {
                    strcon.Open();
                    string sql = "Select * from Menu";//Lấy dữ liệu từ bàng sinh viên
                    SqlCommand cmd = new SqlCommand(sql, strcon);//tạo dối tượng cmd đưa câu truy vấn vào
                    dr = cmd.ExecuteReader();//thực thi đối tượng cmd để tạo ra đối tượng rdr để bắt đầu đọc dũ liệu
                    while (dr.Read())
                    {
                        if ((txtMaSP.Text.Trim() == dr["masp"].ToString().Trim()))
                            OK = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    if (dr != null)
                    {
                        dr.Close();
                    }
                    if (strcon != null)
                    {
                        strcon.Close();
                    }
                }
                if (OK == true)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    strcon.Open();
                   // string tensp = txtTensanpham.Text;//gán nội dung trong textbox = tên sản phẩm
                    string masp = txtMaSP.Text;
                    //Lấy dữ liệu từ bảng bàn với điều kiện tên sản phẩm = nội dung nhập vào từ textbox
                    string sql = "select * from Menu WHERE masp='" + masp + "' ";
                    SqlCommand com = new SqlCommand(sql, strcon);//tạo dối tượng com đưa câu truy vấn vào 
                    com.CommandType = CommandType.Text;//thiết lập nội dung của com là câu lệnh truy vấn
                    //tạo sqldataadapter để thực hiện liên kết truy vấn từ database
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    //Tạo bảng mới để chứa dữ liệu
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    strcon.Close();
                    dgrvDanhsachsp.DataSource = dt;
                }
            }
        }
        void LoadDanhSachDanhMucTuIDDanhMuc()
        {
            List<DanhMucSanPham> danhsachdanhmuc = DanhMucSanPhamDAO.Instance.LayDanhSachDanhMucTheoIdDanhMuc();
            cbbiddanhmuc.DataSource = danhsachdanhmuc;
            cbbiddanhmuc.DisplayMember = "iddanhmuc";
            cbbiddanhmuc.ValueMember = "iddanhmuc";
            cbbDanhmuc.DataBindings.Add(new Binding("Text", cbbiddanhmuc.DataSource, "danhmuc"));
            cbbDanhmuc.DataSource = danhsachdanhmuc;
            cbbDanhmuc.DisplayMember = "danhmuc";
            cbbDanhmuc.ValueMember = "danhmuc";

        }

        private void dgrvDanhsachsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgv = dgrvDanhsachsp.Rows[e.RowIndex];
                txtMasanpham.Text = dgv.Cells[0].Value.ToString();
                txtTensanpham.Text = dgv.Cells[1].Value.ToString();
                cbbiddanhmuc.Text = dgv.Cells[2].Value.ToString();
                cbbDanhmuc.Text = dgv.Cells[3].Value.ToString();
                cbbDonvitinh.Text = dgv.Cells[4].Value.ToString();
                txtGiaban.Text = dgv.Cells[5].Value.ToString();
            }
        }

        private void pbXoatrong_Click(object sender, EventArgs e)
        {
            txtMasanpham.Text = "";
            txtTensanpham.Text = "";
            cbbiddanhmuc.Text = "";
            cbbDanhmuc.Text = "";
            cbbDonvitinh.Text = "";
            txtGiaban.Text = "";
        }

        private void pbQuaylai_Click(object sender, EventArgs e)
        {
            GiaoDienChinh gdc = new GiaoDienChinh();
            gdc.Show();
            this.Hide();
        }

        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                txtMaSP.Text = "Nhập mã sản phẩm";
                txtMaSP.ForeColor = Color.Gray;
            }
        }

        private void txtMaSP_Enter(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "Nhập mã sản phẩm")
            {
                txtMaSP.Text = "";
                txtMaSP.ForeColor = Color.Black;
            }
        }
    }
}
