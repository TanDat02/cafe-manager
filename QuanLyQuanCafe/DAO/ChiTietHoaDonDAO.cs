using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietHoaDonDAO();
                return ChiTietHoaDonDAO.instance;
            }

            set { ChiTietHoaDonDAO.instance = value; }
        }
        public ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> LayDanhSachChiTietHoaDonTheoIdBan(int sohoadon)//sohoadon này là của bản PhieuTamTinh
        {
            List<ChiTietHoaDon> listchitiethoadon = new List<ChiTietHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * From dbo.ChiTietTamTinh where sohoadon = " + sohoadon);
            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon chitiet = new ChiTietHoaDon(item);
                listchitiethoadon.Add(chitiet);
            }
            return listchitiethoadon;
        }
        public void ThemChiTietHoaDon(int sohoadon, int masp, int soluong, float thanhtien)
        {
            // string query = "exc USP_ThemChiTietHoaDon @sohoadon , @idsp , @soluong";
            DataProvider.Instance.ExecuteNonQuery("exec USP_ThemChiTietHoaDon @sohoadon , @masp , @soluong , @thanhtien", new object[] { sohoadon, masp, soluong, thanhtien });
        }
    }
}
