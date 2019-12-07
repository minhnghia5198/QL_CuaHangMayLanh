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
    public partial class HH_NhapHang : UserControl
    {
        public HH_NhapHang()
        {
            InitializeComponent();
        }
        
        

        void loadData()
        {
            string str = "select * from CTHDN where MAHDN='" + cbo_hdn.Text + "'";
            Grc_TABLE.DataSource = KetNoi.Instance.excuteQuery(str);
            
        }

        bool Ktratrangthai()
        {
            string rt = "null";
            string str = "select Trangthai from HOADONNHAP where MAHDN='" + cbo_hdn.Text + "'";
            DataTable data = KetNoi.Instance.excuteQuery(str);

            foreach(DataRow item in data.Rows)
            {
                rt = item["Trangthai"].ToString();
            }

            if (rt != "Hoàn Thành")
            {
                return true;
            }
            return false;
        }

       


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Ktratrangthai())
            {
                string query = "insert into CTHDN(MAHDN,MAHH,SOLUONG,DONGIA,THANHTIEN) values('" + cbo_hdn.Text + "','" + cbo_MaHH.Text + "'," + txt_Soluong.Text + "," + txt_Dongia.Text + "," + txt_Tien.Text + ")";
                if (KetNoi.Instance.KiemTra(query))
                {
                    //KetNoi.Instance.excuteNonQuery(query);
                    loadData();
                }
                else
                {
                    MessageBox.Show("THÊM KHÔNG THÀNH CÔNG", "THÔNG BÁO!!!");
                }

            }
            else
            {
                MessageBox.Show("Trạng Thái đã hoàn thành Không thể Thao tác", "THÔNG BÁO!!!");
            }

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string chuyenTenThanhMaNCC()
        {
            string str = "";
            string query = "select * from nhacungcap where TENNCC = '"+cbo_MANCC.Text+"'";
            //KetNoi.Instance.excuteNonQuery(query);
            DataTable data = KetNoi.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                str =(item["MANCC"]).ToString();
            }
            return str;
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            
            TaoMaHDN();//tạo mã hóa đơn nhập
            MessageBox.Show("Đã tạo mới hóa đơn nhập :" + txt_HDN.Text);
            LoadDTGV();//load data gird view
            txt_HDN.Text = MaTuDong();
            loadMAHDN();// load mã hóa đơn nhập
            

        }

        void loadMAHDN()
        {
            cbo_hdn.Properties.Items.Clear();
            string s = "select * from HOADONNHAP";
            DataTable data = KetNoi.Instance.excuteQuery(s);
            foreach (DataRow item in data.Rows)
            {
                cbo_hdn.Properties.Items.Add(item["MAHDN"]);
            } 

        }

        



        void TaoMaHDN()
        {
            string a = chuyenTenThanhMaNCC().ToString(); 
            string query = "insert into HOADONNHAP(MAHDN,MANCC,TONGTIEN,NGAYNHAP) values('"+ txt_HDN.Text + "', '"+a+"', 0, '"+dateTimePicker1.Text+"')";
            KetNoi.Instance.excuteNonQuery(query);

            
        }

        
        private string MaTuDong()
        {
           
            string query = "select * from HoaDonNhap";
            dataGridView1.DataSource = KetNoi.Instance.excuteQuery(query);



            string ma = "HDN";
            int i = 0;
            try
            {

                while (dataGridView1.Rows[i].Cells[0].Value.ToString() != null)
                {
                    string ktm = null;
                    if (i < 9)
                        ktm = ma + "0" + (i + 1).ToString();
                    else
                        if (i < 99)
                        ktm = ma  + (i + 1).ToString();
                    else
                        ktm = ma + (i + 1).ToString();
                    if (string.Compare(ktm, dataGridView1.Rows[i].Cells[0].Value.ToString().Trim(), true) != 0)
                    {
                        //MessageBox.Show(ktm);
                        return ktm;
                    }
                    i++;
                }
            }
            catch
            {
                string ktm = null;
                if (i < 9)
                    ktm = ma + "0" + (i + 1).ToString();
                else
                    if (i < 99)
                    ktm = ma  + (i + 1).ToString();
                else
                    ktm = ma + (i + 1).ToString();
                return ktm;
            }
            return ma;
        }

        void ThemCTHD()
        {
            //string str = "insert into from CTHDN values ('"+txt_MaHD.Text+"','"+cbo_MaHH.Text+ "','" + cbo_MANCC.Text + "'," + txt_Soluong.Text + "," + txt_Dongia.Text + ",null)";
            //KetNoi.Instance.excuteQuery(str);
            //string update = "UPDATE CTHDN SET THANHTIEN = SOLUONG*DONGIA";
            //KetNoi.Instance.excuteQuery(update);

        }

        void ThemHDN()
        {
            try
            {
                string query = "  UPDATE HOADONNHAP SET TONGTIEN = ( SELECT SUM(THANHTIEN) FROM CTHDN WHERE MAHDN = '" + cbo_hdn.Text + "') where MAHDN = '" + cbo_hdn.Text + "' ";
                KetNoi.Instance.excuteQuery(query);
                MessageBox.Show("HOAN TAT NHAP HANG");
            }
            catch
            {
                MessageBox.Show("THEM THAT BAI");
            }
        }

        
        

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            
            if (Ktratrangthai())
            {
                string query = "update HOADONNHAP set trangthai = 'Hoàn Thành' where MAHDN = '" + cbo_hdn.Text + "'";
                KetNoi.Instance.excuteNonQuery(query);
                ThemHDN();
                LoadDTGV();
                MessageBox.Show("Them Thanh cong");
                
            }
            else
            {
                MessageBox.Show("Trạng Thái đã hoàn thành Không thể Thao tác", "THÔNG BÁO!!!");
            }
        }

        // load combo box
        
        private void load_CboMaNCC()
        {

            cbo_MANCC.Properties.Items.Clear();
            string s = "select * from NHACUNGCAP";
            DataTable data = KetNoi.Instance.excuteQuery(s);
            foreach (DataRow item in data.Rows)
            {
                cbo_MANCC.Properties.Items.Add(item["TENNCC"]);
            }

        }

        

        private void LOAD_MAHH()
        {

            cbo_MaHH.Properties.Items.Clear();
            string str = "select * from HANGHOA";
            DataTable data = KetNoi.Instance.excuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                cbo_MaHH.Properties.Items.Add(item["MAHANGHOA"]);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Grc_TABLE_Click(object sender, EventArgs e)
        {

        }

        private void HH_NhapHang_Load(object sender, EventArgs e)
        {
            txt_HDN.Text = MaTuDong();
            txt_HDN.Enabled = false;
            load_CboMaNCC();
            LOAD_MAHH();
            //loadData();
            LoadDTGV();
            loadMAHDN();
        }

        void LoadDTGV()
        {
            string query = "select * from HoaDonNhap";
            dataGridView1.DataSource = KetNoi.Instance.excuteQuery(query);
        }

        

        

        private void btn_XacNhan_Click_1(object sender, EventArgs e)
        {

        }

        private void cbo_hdn_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();

            //LOAD NCC

            string query = "select MANCC from HOADONNHAP where MAHDN='" + cbo_hdn.Text + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            string chuoi = "null";
            foreach (DataRow item in data.Rows)
            {
                chuoi = item["MANCC"].ToString();
            }

            //CHUYỂN MÃ NCC THÀNH TÊN
            string query1 = "select * from NHACUNGCAP where MANCC='" + chuoi + "'";
            DataTable data1 = KetNoi.Instance.excuteQuery(query1);
            foreach (DataRow item in data1.Rows)
            {
                chuoi = item["TENNCC"].ToString();
            }

            cbo_MANCC.Text = chuoi;
        }

        private void cbo_MaHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            string dongia = "";
            string query = "select * from HANGHOA where MAHANGHOA = '"+cbo_MaHH.Text+"'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                str = (item["TENHANGHOA"]).ToString();
                dongia = (item["DONGIA"]).ToString();
            }

            txt_TenHH.Text = str;
            txt_Dongia.Text = dongia;

        }

        private void txt_Soluong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt_Soluong.Text);
                int b = int.Parse(txt_Dongia.Text);
                txt_Tien.Text = (a * b).ToString();
            }
            catch
            {
                txt_Tien.Text = "0";
            }
        }

        private void cbo_MANCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Grp_NhapHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            if (Ktratrangthai())
            {
                if (MessageBox.Show("Bạn có muốn làm mới Hóa Đơn Bán Hàng \n Tất cả dữ liệu sẽ bị xóa!!", "Thông báo!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                
                    string query = "delete from CTHDN where MAHDN = '" + cbo_hdn.Text + "'";
                    KetNoi.Instance.excuteNonQuery(query);
                    MessageBox.Show("LÀM MỚI THÀNH CÔNG","THÔNG BÁO");
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Trạng Thái đã hoàn thành Không thể Thao tác", "THÔNG BÁO!!!");
            }

        }
    }
}
