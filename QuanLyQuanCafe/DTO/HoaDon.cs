using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDon
    {
        public HoaDon(int soHoaDon, DateTime ngayBan, DateTime ngayThanhToan, int trangThai)
        {
            this.SoHoaDon = soHoaDon;
            this.NgayBan = ngayBan;
            this.NgayThanhToan = ngayThanhToan;
            this.TrangThai = trangThai;
            //  this.TongTien = tongTien;
        }
        public HoaDon(DataRow row)
        {
            this.SoHoaDon = (int)row["sohoadon"];
            // this.idBan = (int)row["idban"];          
            this.NgayBan = (DateTime?)row["ngayban"];//Datetime? là cho phép null
            var ngayThanhToanTemp = row["ngaythanhtoan"];
            if (NgayThanhToan.ToString() != "")
                this.NgayThanhToan = (DateTime?)ngayThanhToanTemp;
            this.TrangThai = (int)row["trangthai"];
        }
        private int soHoaDon;

        public int SoHoaDon
        {
            get { return soHoaDon; }

            set { soHoaDon = value; }
        }

        public DateTime? NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }

        public int TrangThai
        {
            get { return trangThai; }

            set { trangThai = value; }
        }

        public DateTime? NgayThanhToan
        {
            get { return ngayThanhToan; }

            set { ngayThanhToan = value; }
        }
        private DateTime? ngayThanhToan;
        private DateTime? ngayBan;
        private int trangThai;
    }
}
