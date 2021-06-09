using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class ThucDon
    {
        public ThucDon(string tenSP, string danhMuc, string donViTinh, int soLuong, float giaBan, float thanhTien)
        {
            this.TenSP = tenSP;
            this.DanhMuc = danhMuc;
            this.DonViTinh = donViTinh;
            this.SoLuong = soLuong;
            this.GiaBan = giaBan;
            this.ThanhTien = thanhTien;
        }
        public ThucDon(DataRow Row)
        {
            this.TenSP = Row["tensp"].ToString();
            this.DanhMuc = Row["danhmuc"].ToString();
            this.DonViTinh = Row["donvitinh"].ToString();
            this.SoLuong = (int)Row["soluong"];
            this.GiaBan = (float)Convert.ToDouble(Row["giaban"]);
            this.ThanhTien = (float)Convert.ToDouble(Row["thanhtien"]);
        }
        private string tenSP;
        private string danhMuc;
        private string donViTinh;
        private int soLuong;
        private float giaBan;
        private float thanhTien;

        public string TenSP
        {
            get { return tenSP; }

            set { tenSP = value; }
        }

        public string DanhMuc
        {
            get { return danhMuc; }

            set { danhMuc = value; }
        }

        public string DonViTinh
        {
            get { return donViTinh; }

            set { donViTinh = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }

            set { soLuong = value; }
        }

        public float GiaBan
        {
            get { return giaBan; }

            set { giaBan = value; }
        }

        public float ThanhTien
        {
            get { return thanhTien; }

            set { thanhTien = value; }
        }
    }
}
