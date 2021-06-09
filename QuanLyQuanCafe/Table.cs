using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe
{
    public class Table
    {
        public Table(string name, string trangthai)
        {
            this.Name = name;
            this.Trangthai = trangthai;
        }

        public Table(DataRow row)
        {
            this.Name = row["tenban"].ToString();
            this.Trangthai = row["trangthai"].ToString();
        }

        private string trangthai;

        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
