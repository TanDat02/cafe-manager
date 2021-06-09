using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(int id, int soHoaDon, int idSP, int soLuong, float thanhTien)
        {
            this.Id = id;
            this.SoHoaDon = soHoaDon;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }
        public ChiTietHoaDon(DataRow Row)
        {
            //Từng kiểu lấy ra từ bảng trong database thì phải lấy đúng tên trường đó như cột idtamtinh trong database ghi sao trong này phải ghi y như v VD :Row["idtamtinh"]
            this.Id = (int)Row["id"];
            this.SoHoaDon = (int)Row["sohoadon"]; ;
            this.MaSP = (int)Row["masp"]; ;
            this.SoLuong = (int)Row["soluong"]; ;
            this.ThanhTien = (float)Convert.ToDouble(Row["thanhtien"].ToString());
        }

        private int id;
        private int soHoaDon;
        private int maSP;
        private int soLuong;
        private float thanhTien;

        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public int SoHoaDon
        {
            get { return soHoaDon; }

            set { soHoaDon = value; }
        }

        public int MaSP
        {
            get { return maSP; }

            set { maSP = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }

            set { soLuong = value; }
        }

        public float ThanhTien
        {
            get { return thanhTien; }

            set { thanhTien = value; }
        }
    }
}
