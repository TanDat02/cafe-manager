using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return HoaDonDAO.instance;
            }

            set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO() { }
        //Nếu thành công thì lấy được id hóa đơn 
        //còn thất bại thì trả về -1
        public int LaySoHoaDonTheoIDBan(int maban)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from PhieuTamTinh where maban = " + maban + " and trangthai = 0");
            if (data.Rows.Count > 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[0]);
                return hoadon.SoHoaDon;
            }
            return -1;
        }
        public void ThanhToan(int id, float tongTien)
        {
            string query = "UPDATE dbo.PhieuTamTinh set ngaythanhtoan = GETDATE(), trangthai = 1, tongtien= " + tongTien + " Where sohoadon = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void ThemHoaDon(int maban, int manv)
        {
            string query = "exec USP_ThemHoaDon @maban , @manv";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maban, manv });
        }
        public int LayIDHoaDonMax()
        {
            try
            {
                //Khi trả về là lấy được sohoadon lớn nhất đang có
                return (int)DataProvider.Instance.ExecuteScalar("Select MAX(sohoadon) from dbo.PhieuTamTinh");// nếu chưa co bàn nào thì sẽ lỗi do đó mình phải dung try cat
            }
            catch
            {
                return 1;
            }
        }
    }
}
