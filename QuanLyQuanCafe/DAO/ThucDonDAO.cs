using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class ThucDonDAO
    {
        private static ThucDonDAO instance;

        public static ThucDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThucDonDAO();
                return ThucDonDAO.instance;
            }

            set { ThucDonDAO.instance = value; }
        }
        public ThucDonDAO() { }

        public List<ThucDon> LayDanhSachThucDonTheoBan(int id)
        {
            List<ThucDon> listThucDon = new List<ThucDon>();
            string query = "SELECT m.tensp, m.danhmuc, m.donvitinh, c.soluong,m.giaban,(m.giaban*c.soluong) as thanhtien From dbo.Menu as m, dbo.ChiTietTamTinh as c, dbo.PhieuTamTinh as p Where c.sohoadon = p.sohoadon and c.masp = m.masp and trangthai =0 and p.trangthai=0 and p.maban = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThucDon thucdon = new ThucDon(item);
                listThucDon.Add(thucdon);
            }
            return listThucDon;
        }
    }
}
