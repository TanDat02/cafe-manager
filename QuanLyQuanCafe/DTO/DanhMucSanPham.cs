using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class DanhMucSanPham
    {
        private int idDanhMuc;
        private string danhMuc;
        public DanhMucSanPham(int idDanhMuc, string danhMuc)
        {
            this.IdDanhMuc = idDanhMuc;
            this.DanhMuc = danhMuc;
        }
        public DanhMucSanPham(DataRow Row)
        {
            this.IdDanhMuc = (int)Row["iddanhmuc"];
            this.DanhMuc = Row["danhmuc"].ToString();
        }
        public DanhMucSanPham()
        {

        }
        public int IdDanhMuc
        {
            get { return idDanhMuc; }

            set { idDanhMuc = value; }
        }

        public string DanhMuc
        {
            get { return danhMuc; }

            set { danhMuc = value; }
        }
    }
}
