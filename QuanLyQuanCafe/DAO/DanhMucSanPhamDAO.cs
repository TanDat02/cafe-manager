using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class DanhMucSanPhamDAO
    {
        private static DanhMucSanPhamDAO instance;

        public static DanhMucSanPhamDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhMucSanPhamDAO();
                return DanhMucSanPhamDAO.instance;
            }

            set { DanhMucSanPhamDAO.instance = value; }
        }
        public DanhMucSanPhamDAO() { }
        //Làm thêm thành tiền vào chi tiết tạm tính, sổ iddanhmuc vs danh mục ra, làm phân quyên

        public List<DanhMucSanPham> LayDanhSachIDDanhMuc()
        {
            List<DanhMucSanPham> danhsachiddanhmuc = new List<DanhMucSanPham>();
            string query = "SELECT * From DanhMucSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DanhMucSanPham danhmuc = new DanhMucSanPham(item);
                danhsachiddanhmuc.Add(danhmuc);
            }
            return danhsachiddanhmuc;
        }
        public List<DanhMucSanPham> LayDanhSachDanhMucTheoIdDanhMuc()
        {
            List<DanhMucSanPham> danhsachdanhmuc = new List<DanhMucSanPham>();
            string query = "SELECT * From DanhMucSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DanhMucSanPham sanpham = new DanhMucSanPham(item);
                danhsachdanhmuc.Add(sanpham);
            }
            return danhsachdanhmuc;
        }

        public List<DanhMucSanPham> LayDanhSachDanhMuc()
        {
            List<DanhMucSanPham> danhsachdanhmuc = new List<DanhMucSanPham>();
            string query = "SELECT * From DanhMucSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DanhMucSanPham danhmuc = new DanhMucSanPham(item);
                danhsachdanhmuc.Add(danhmuc);
            }
            return danhsachdanhmuc;
        }
    }
}
