using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class Ban
    {
        public Ban(int maban, string tenBan, string trangThai)
        {
            this.Maban = maban;
            this.TenBan = tenBan;
            this.TrangThai = trangThai;
        }
        public Ban(DataRow row)
        {
            this.Maban = (int)row["maban"];
            this.tenBan = row["tenban"].ToString();
            this.trangThai = row["trangthai"].ToString();
        }
        private string tenBan;

        private int maban;

        public string TrangThai
        {
            get { return trangThai; }

            set { trangThai = value; }
        }

        public int Maban
        {
            get { return maban; }

            set { maban = value; }
        }

        public string TenBan
        {
            get { return tenBan; }

            set { tenBan = value; }
        }

        private string trangThai;
    }
}
