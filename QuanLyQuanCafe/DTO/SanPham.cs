using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class SanPham
    {
        private int maSP;
        private string tenSP;
        private int idDanhMuc;
        private string danhMuc;
        private string donViTinh;
        private float giaBan;
        public SanPham(int maSP, string tenSP, int idDanhMuc, string danhMuc, string donViTinh, float giaBan)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.IdDanhMuc = idDanhMuc;
            this.DanhMuc = danhMuc;
            this.DonViTinh = donViTinh;
            this.GiaBan = giaBan;
        }
        public SanPham(DataRow Row)
        {
            this.MaSP = (int)Row["masp"];
            this.TenSP = Row["tensp"].ToString();
            this.IdDanhMuc = (int)Row["iddanhmuc"];
            this.DanhMuc = Row["danhmuc"].ToString();
            this.DonViTinh = Row["donvitinh"].ToString();
            this.GiaBan = (float)Convert.ToDouble(Row["giaban"]);
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

        public int MaSP
        {
            get { return maSP; }

            set { maSP = value; }
        }

        public string TenSP
        {
            get { return tenSP; }

            set { tenSP = value; }
        }

        public string DonViTinh
        {
            get { return donViTinh; }

            set { donViTinh = value; }
        }

        public float GiaBan
        {
            get { return giaBan; }

            set { giaBan = value; }
        }
    }
}
