using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System.Globalization;
using System.Threading;

namespace QuanLyQuanCafe
{
    public partial class QuanLyBan : Form
    {
        public QuanLyBan()
        {
            InitializeComponent();
            txtTennhanvien.Text = FormDangNhap.tenNv;
            LoadTable();
            LoadDanhMuc();
            NhanVienDAO nv = new NhanVienDAO();
        }

        private void QuanLyBan_Load(object sender, EventArgs e)
        {
            
        }
        void LoadTable()
        {
            flpBan.Controls.Clear();

            List<Ban> danhSachBan = BanDAO.Instance.LoadDanhSachBan();

            foreach (Ban item in danhSachBan)
            {
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;//Khi click vào 1 bàn nào đó thì sẽ show hóa đơn ra
                btn.Tag = item;//Lưu bàn vào

                switch (item.TrangThai)//Thay đổi màu theo trạng thái
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpBan.Controls.Add(btn);
            }
        }
        void LoadDanhMuc()
        {
            List<DanhMucSanPham> danhsachdanhmuc = DanhMucSanPhamDAO.Instance.LayDanhSachDanhMuc();
            cbbDanhmuc.DataSource = danhsachdanhmuc;
            //Khi đã lấy được tất cả danh sách các trường nhưng chỉ muốn nó hiển thị trường trường danh mục
            cbbDanhmuc.DisplayMember = "danhmuc";
        }
        void LoadDanhSachSanPhamTuDanhMuc(int id)
        {
            List<SanPham> danhsachsanpham = SanPhamDAO.Instance.LayDanhSachSanPhamTheoDanhMuc(id);
            cbbSanpham.DataSource = danhsachsanpham;
            cbbSanpham.DisplayMember = "tensp";
        }

        void HienThiHoaDon(int id)
        {
            lvHoaDon.Items.Clear();
            // List<ChiTietHoaDon> listchitiethoadon = ChiTietHoaDonDAO.Instance.LayDanhSachChiTietHoaDonTheoIdBan(id);
            List<ThucDon> listchitiethoadon = ThucDonDAO.Instance.LayDanhSachThucDonTheoBan(id);
            //Có listchitiethoadon rồi thì ta thêm vào listview
            float tongTien = 0;
            foreach (ThucDon item in listchitiethoadon)
            {
                ListViewItem listItem = new ListViewItem(item.TenSP.ToString());//Để thêm các cột tiếp theo thì t thêm kiểu subItem vì nó là các cột phía sau của cột chính IdTamTinh
                listItem.SubItems.Add(item.DanhMuc.ToString());
                listItem.SubItems.Add(item.DonViTinh.ToString());
                listItem.SubItems.Add(item.SoLuong.ToString());
                listItem.SubItems.Add(item.GiaBan.ToString());
                listItem.SubItems.Add(item.ThanhTien.ToString());
                tongTien += item.ThanhTien;
                lvHoaDon.Items.Add(listItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            // Thread.CurrentThread.CurrentCulture = culture;//Chuyển luồng đang chạy thành culture ở trên 
            txtTongTien.Text = tongTien.ToString("c", culture);
        }
        void btn_Click(object sender, EventArgs e)
        {
            int MaBan = ((sender as Button).Tag as Ban).Maban;//Để hiển thị thì cần biết id của bàn nào nên phải khai báo
            lvHoaDon.Tag = (sender as Button).Tag;
            //Khi click vào bàn thì sẽ lưu cái bàn zô
            HienThiHoaDon(MaBan);//sao khi mở lại thì nó lên 1 lần 4 sp lỗi r // thôi k đc thôi bạn ơi để chút mình thêm cái trạng thái hóa đơn r thử lại xem sao
        }

        private void cbbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox combo = sender as ComboBox;

            if (combo.SelectedItem == null)
                return;

            DanhMucSanPham selected = combo.SelectedItem as DanhMucSanPham;

            id = selected.IdDanhMuc;
            LoadDanhSachSanPhamTuDanhMuc(id);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (FormDangNhap.Luu.Quyen == "staff")
            {
                //Muốn thêm thì phải qua bên Hoadon thêm cái hóa đơn mới vào
                Ban ban = lvHoaDon.Tag as Ban;
                //Lấy idhoadon hiện tại
                if (ban != null)
                {
                    int sohoadon = HoaDonDAO.Instance.LaySoHoaDonTheoIDBan(ban.Maban);
                    int masp = (cbbSanpham.SelectedItem as SanPham).MaSP;
                    int soluong = (int)nmThemMon.Value;
                    float giaban = SanPhamDAO.Instance.LayGiaBanTheoIdSP(masp);
                    float thanhtien = soluong * giaban;
                    //Nếu trường hợp chưa có hóa đơn nào thì phải thêm hóa đơn mới
                    if (sohoadon == -1)
                    {
                        if (txtTennhanvien.SelectedText != null)
                        {
                            HoaDonDAO.Instance.ThemHoaDon(ban.Maban, Convert.ToInt32(NhanVienDAO.Instance.layDanhsachnhanvien().Where(p => p.TenNV.CompareTo(txtTennhanvien.Text) == 0).Select(p => p.MaNV).SingleOrDefault()));
                            ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(HoaDonDAO.Instance.LayIDHoaDonMax(), masp, soluong, thanhtien);
                        }

                    }

                    else//ngoài ra thêm vào hóa đơn cũ
                    {
                        ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(sohoadon, masp, soluong, thanhtien);
                    }
                    HienThiHoaDon(ban.Maban);//Cập nhật lại thông tin bàn(cả hóa đơn và tổng tiền)
                    LoadTable();
                }
                else
                    MessageBox.Show("Bạn chưa chọn bàn. Vui lòng chọn bàn cần đặt món!");
            }
            else
            {
                MessageBox.Show("Chỉ Nhân viên mới sử dụng được chức năng này!!!");
            }
           
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            Ban ban = lvHoaDon.Tag as Ban;
            int idBan = ban.Maban;
            int sohoadon = HoaDonDAO.Instance.LaySoHoaDonTheoIDBan(ban.Maban);
            Double tongTien = Convert.ToDouble(txtTongTien.Text.Split(',')[0].Replace(".", ""));
            if (sohoadon != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\nTổng tiền = {1}  ", ban.TenBan, tongTien), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    HoaDonDAO.Instance.ThanhToan(sohoadon, (float)tongTien);
                    HienThiHoaDon(ban.Maban);
                    LoadTable();
                }
            }

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            GiaoDienChinh gdc = new GiaoDienChinh();
            gdc.Show();
            this.Hide();
        }
    }
}
