using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanDAO();
                return BanDAO.instance;
            }
            private set { BanDAO.instance = value; }
        }
        public static int TableWidth = 65;
        public static int TableHeight = 65;
        private BanDAO() { }
        public List<Ban> LoadDanhSachBan()
        {
            List<Ban> danhSachBan = new List<Ban>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows) //Lấy từng hàng trong bảng bàn
            {
                Ban ban = new Ban(item);
                danhSachBan.Add(ban);
            }
            return danhSachBan;
        }   
    }
}
