using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main
{
    public partial class QL_TAICHINH : UserControl
    {
        public QL_TAICHINH()
        {
            InitializeComponent();
        }

        double TongNhap(int thang)
        {
            string str = "select * from HOADONNHAP where MONTH(NGAYNHAP) = "+thang;
            if (thang == 0)
            {
                str = "select * from HOADONNHAP";
            }
            //KetNoi.Instance.excuteQuery();
            string tong = "";
            double a = 0;
            DataTable data = KetNoi.Instance.excuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                tong = item["TONGTIEN"].ToString();
                a += int.Parse(tong);
                //cbo_MAHDXuat.Properties.Items.Add(item["MAHDX"]);
            }

            return a;
        }

        double TongXuat(int thang)
        {
            string str = "select * from HOADONXUAT where MONTH(NGAY) = " + thang;
            if(thang == 0)
            {
                str = "select * from HOADONXUAT";
            }
            //KetNoi.Instance.excuteQuery();
            string tong = "";
            double a = 0;
            DataTable data = KetNoi.Instance.excuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                tong = item["TONGTIEN"].ToString();
                a += int.Parse(tong);
                //cbo_MAHDXuat.Properties.Items.Add(item["MAHDX"]);
            }

            return a;
        }

        private void QL_TAICHINH_Load(object sender, EventArgs e)
        {
            loadCBO();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            int a = 0;
            try
            {
                a = int.Parse(cbo_Thang.Text);
            }
            catch
            {
            }

            txt_TongBan.Text = TongXuat(a).ToString();
            txt_TongNhap.Text = TongNhap(a).ToString();
            txt_Sum.Text = ( TongXuat(a)- TongNhap(a)).ToString();


        }

        void loadCBO()
        {
            cbo_Thang.Properties.Items.Add("Tất cả");
            for (int i = 1;i<=12; i++)
            {
                cbo_Thang.Properties.Items.Add(i);
            }
            
        }
    }
}
