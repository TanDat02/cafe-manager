using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAO();
                return NhanVienDAO.instance;
            }

            set { NhanVienDAO.instance = value; }
        }
        public NhanVienDAO() { }
        public List<NhanVien> layDanhsachnhanvien()
        {
            List<NhanVien> nhanvien = new List<NhanVien>();
            string query = "select * from NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dt in data.Rows)
            {
                NhanVien nv = new NhanVien(dt);
                nhanvien.Add(nv);
            }
            return nhanvien;
        }
    }
}
