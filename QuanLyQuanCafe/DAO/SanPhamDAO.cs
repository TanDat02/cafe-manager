using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null) instance = new SanPhamDAO();
                return SanPhamDAO.instance;
            }

            set { SanPhamDAO.instance = value; }
        }
        public SanPhamDAO() { }

        public List<SanPham> LayDanhSachSanPhamTheoDanhMuc(int id)
        {
            List<SanPham> danhsachsanpham = new List<SanPham>();
            string query = "SELECT * From Menu where iddanhmuc = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sanpham = new SanPham(item);
                danhsachsanpham.Add(sanpham);
            }
            return danhsachsanpham;
        }
        //public List<SanPham> LayDanhSachDanhMucTheoIdDanhMuc(int id)
        //{
        //    List<SanPham> danhsachdanhmuc = new List<SanPham>();
        //    string query = "SELECT * From Menu where iddanhmuc = " + id;
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        SanPham sanpham = new SanPham(item);
        //        danhsachdanhmuc.Add(sanpham);
        //    }
        //    return danhsachdanhmuc;
        //}
        public float LayGiaBanTheoIdSP(int maSP)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Menu where masp = " + maSP);
            if (data.Rows.Count > 0)
            {
                SanPham sanpham = new SanPham(data.Rows[0]);
                return sanpham.GiaBan;
            }
            return -1;
        }
    }
}
