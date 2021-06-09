using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
   public class NhanVien
    {
        private int maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string chucVu;
        private string diaChi;
        private string sdt;
        private string username;
        private string password;
        public NhanVien(int maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string chucVu, string diaChi, string sdt, string username, string password)
        {
            this.MaNV = maNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.ChucVu = chucVu;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Username = username;
            this.Password = password;
        }
        public NhanVien()
        { }
        public NhanVien(DataRow Row)
        {
            this.MaNV = (int)Row["manv"];
            this.TenNV = Row["tennv"].ToString();
            this.NgaySinh = (DateTime)Row["ngaysinh"];
            this.GioiTinh = Row["gioitinh"].ToString();
            this.ChucVu = Row["chucvu"].ToString();
            this.DiaChi = Row["diachi"].ToString();
            this.Sdt = Row["sdt"].ToString();
            this.Username = Row["Username"].ToString();
            this.Password = Row["Password"].ToString();
        }

        public int MaNV
        {
            get { return maNV; }

            set { maNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }

            set { tenNV = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }

            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }

            set { gioiTinh = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }

            set { chucVu = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }

            set { diaChi = value; }
        }

        public string Sdt
        {
            get { return sdt; }

            set { sdt = value; }
        }

        public string Username
        {
            get { return username; }

            set { username = value; }
        }

        public string Password
        {
            get { return password; }

            set { password = value; }
        }
    }
}
