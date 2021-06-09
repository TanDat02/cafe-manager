using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class ThongKeSP : Form
    {
        public ThongKeSP()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GiaoDienChinh gdc = new GiaoDienChinh();
            gdc.Show();
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string query2 = "Select masp, soluong From ChiTietTamTinh Where sohoadon=@sohoadon";

            DataProvider.Instance.DeleteDSTK();
            if(rdbNgay.Checked == true)
            {
                string shortDate = dateTimePicker1.Value.ToShortDateString();
                string query1 = "EXEC USP_GetSohoadonByDate @date";

                DataTable datasohd = DataProvider.Instance.ExecuteQueryDay(query1, shortDate);
                
                DataTable datasoluongSP = null;
                DataTable datatenSP = null;

                List<Table1> tableList = TableDAO.Instance.LoadTableSohoadon(datasohd);//Tạo list sohoadon
                foreach (Table1 item in tableList)
                {
                    datasoluongSP = DataProvider.Instance.ExecuteQuery2(query2, item.Sohoadon);//Lấy table sản phẩm theo sohoadon
                    for (int i = 0; i < datasoluongSP.Rows.Count; i++)
                    {
                        int ii = 0;
                        string masp = datasoluongSP.Rows[i][ii].ToString();
                        datatenSP = DataProvider.Instance.ExecuteQuery3(masp);
                        string tensp = datatenSP.Rows[0][0].ToString();

                        string soluong = datasoluongSP.Rows[i][ii+1].ToString();
                        DataProvider.Instance.InsertTKSP(tensp, soluong);//Insert giá trị từng dòng của table sản phẩm vào csdl
                    }
                }

                dgvSanPham.DataSource = DataProvider.Instance.SumSanPham();//Tính tổng sản phẩm và hiện lên datagridview
            }
            else if( rdbThang.Checked == true)
            {
                string month = nudThang1.Value.ToString();
                string year = nudNam1.Value.ToString();

                DataTable datasohd = DataProvider.Instance.ExecuteQueryMonth(month, year);

                DataTable datasoluongSP = null;
                DataTable datatenSP = null;

                List<Table1> tableList = TableDAO.Instance.LoadTableSohoadon(datasohd);//Tạo list sohoadon
                foreach (Table1 item in tableList)
                {
                    datasoluongSP = DataProvider.Instance.ExecuteQuery2(query2, item.Sohoadon);//Lấy table sản phẩm theo sohoadon
                    for (int i = 0; i < datasoluongSP.Rows.Count; i++)
                    {
                        int ii = 0;
                        string masp = datasoluongSP.Rows[i][ii].ToString();
                        datatenSP = DataProvider.Instance.ExecuteQuery3(masp);
                        string tensp = datatenSP.Rows[0][0].ToString();

                        string soluong = datasoluongSP.Rows[i][ii + 1].ToString();
                        DataProvider.Instance.InsertTKSP(tensp, soluong);//Insert giá trị từng dòng của table sản phẩm vào csdl
                    }
                }

                dgvSanPham.DataSource = DataProvider.Instance.SumSanPham();//Tính tổng sản phẩm và hiện lên datagridview
            }
            else
            {
                string year = nudNam2.Value.ToString();

                DataTable datasohd = DataProvider.Instance.ExecuteQueryYear(year);

                DataTable datasoluongSP = null;
                DataTable datatenSP = null;

                List<Table1> tableList = TableDAO.Instance.LoadTableSohoadon(datasohd);//Tạo list sohoadon
                foreach (Table1 item in tableList)
                {
                    datasoluongSP = DataProvider.Instance.ExecuteQuery2(query2, item.Sohoadon);//Lấy table sản phẩm theo sohoadon
                    for (int i = 0; i < datasoluongSP.Rows.Count; i++)
                    {
                        int ii = 0;
                        string masp = datasoluongSP.Rows[i][ii].ToString();
                        datatenSP = DataProvider.Instance.ExecuteQuery3(masp);
                        string tensp = datatenSP.Rows[0][0].ToString();

                        string soluong = datasoluongSP.Rows[i][ii + 1].ToString();
                        DataProvider.Instance.InsertTKSP(tensp, soluong);//Insert giá trị từng dòng của table sản phẩm vào csdl
                    }
                }

                dgvSanPham.DataSource = DataProvider.Instance.SumSanPham();//Tính tổng sản phẩm và hiện lên datagridview
            }
        }

    }
}
