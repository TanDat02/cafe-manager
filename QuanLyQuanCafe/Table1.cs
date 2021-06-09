using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe
{
    public class Table1
    {
        public Table1(string sohoadon)
        {
            this.Sohoadon = sohoadon;
        }

        public Table1(DataRow row)
        {
            this.Sohoadon = row["sohoadon"].ToString();
        }

        private string sohoadon;

        public string Sohoadon
        {
            get { return sohoadon; }
            set { sohoadon = value; }
        }
    }
}
