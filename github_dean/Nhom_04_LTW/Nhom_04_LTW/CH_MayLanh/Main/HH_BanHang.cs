using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class HH_BanHang : UserControl
    {
        public HH_BanHang()
        {
            InitializeComponent();
        }

        private string MaTuDong()
        {

            string query = "select * from HOADONXUAT";
            dataGridView1.DataSource = KetNoi.Instance.excuteQuery(query);



            string ma = "HDBH";
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
                        ktm = ma + (i + 1).ToString();
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
                    ktm = ma + (i + 1).ToString();
                else
                    ktm = ma + (i + 1).ToString();
                return ktm;
            }
            return ma;
        }

        void LOADCOMBOBOX()
        {
            //LOAD KHÁCH HÀNG
            cbo_Makh.Properties.Items.Clear();
            string s = "select * from KHACHHANG";
            DataTable data = KetNoi.Instance.excuteQuery(s);
            foreach (DataRow item in data.Rows)
            {
                cbo_Makh.Properties.Items.Add(item["MAKH"]);
                
            }

            //LOAD MÃ HÓA ĐƠN BÁN HÀNG
            cbo_HDBH.Properties.Items.Clear();
            string HDB = "select * from HOADONXUAT";
            DataTable data1 = KetNoi.Instance.excuteQuery(HDB);
            foreach (DataRow item in data1.Rows)
            {
                cbo_HDBH.Properties.Items.Add(item["MAHDX"]);
            }

            //LOAD MÃ HÀNG HÓA
            cbo_MaHH.Properties.Items.Clear();
            string str = "select * from HANGHOA";
            DataTable data2 = KetNoi.Instance.excuteQuery(str);
            foreach (DataRow item in data2.Rows)
            {
                cbo_MaHH.Properties.Items.Add(item["MAHANGHOA"]);
            }
        }

        void TaoMoiHDX()
        {
            string query = "insert into HOADONXUAT(MAHDX,MAKH,TONGTIEN,NGAY) VALUES ('"+txt_HDBH.Text+"','"+cbo_Makh.Text+"',0,'"+dateTimePicker1.Text+"')";
            KetNoi.Instance.excuteNonQuery(query);
            LOADCOMBOBOX();
        }

        void TaoCTBH()
        {
            string query = "insert into CTHDX(MAHDX,MaHangHoa,SOLUONG,DONGIA,THANHTIEN) VALUES('"+cbo_HDBH.Text+"', '"+cbo_MaHH.Text+"', "+txt_Soluong.Text+", "+txt_Dongia.Text+", "+txt_Tien.Text+")";//-------------------------------------------
            if (KetNoi.Instance.KiemTra(query))
            {
                //KetNoi.Instance.excuteNonQuery(query);
            }
            else
            {
                query = "UPDATE CTHDX SET SOLUONG = SOLUONG + " + txt_Soluong.Text + ",THANHTIEN = THANHTIEN + " + txt_Tien.Text + " WHERE MAHDX = '" + cbo_HDBH.Text + "' AND MaHangHoa = '" + cbo_MaHH.Text + "' ";
                //MessageBox.Show("MẶT HÀNG ĐÃ TỒN TẠI TRONG ĐƠN HÀNG","THÔNG BÁO");
                

                    if (KetNoi.Instance.KiemTra(query))
                    {
                        if (MessageBox.Show("MẶT HÀNG ĐÃ TỒN TẠI TRONG ĐƠN HÀNG bạn muốn cập nhật số lượng!!", "THÔNG BÁO", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            MessageBox.Show("Cập nhật số lượng thành công", "THÔNG BÁO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mặt hàng trong kho không đủ", "THÔNG BÁO");
                    }
                
            }
            
        }

        void LOADCTHDBH()//load chi tiết hóa đơn bán hnagf
        {
            string query = "SELECT * FROM CTHDX WHERE MAHDX='"+cbo_HDBH.Text+"'";//-------------------------------------------
            Grc_TABLE.DataSource = KetNoi.Instance.excuteQuery(query);
        }

        void LOADdatagrid()
        {
            string a = "select * from HOADONXUAT";
            dataGridView1.DataSource = KetNoi.Instance.excuteQuery(a);

        }

        // Form load 

        private void HH_BanHang_Load(object sender, EventArgs e)
        {
            LOADCOMBOBOX();
            txt_HDBH.Text = MaTuDong();
            LOADCTHDBH();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_Makh.Text))
            {
                MessageBox.Show("Bạn phải nhập Khách Hàng","Thông Báo");
            }
            else
            {
                TaoMoiHDX(); 
                MessageBox.Show("Bạn đã tạo mới thành công Hóa Đơn:" + txt_HDBH.Text, "Thông Báo");
                txt_HDBH.Text = MaTuDong();
                cbo_Makh.Text = null;
                textEdit1.Text = null;
            }
            

        }

        private void cbo_Makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LOAD KHÁCH HÀNG
            cbo_Makh.Properties.Items.Clear();
            string s = "select * from KHACHHANG WHERE MAKH ='"+cbo_Makh.Text+"'";
            DataTable data = KetNoi.Instance.excuteQuery(s);
            foreach (DataRow item in data.Rows)
            {
                textEdit1.Text = (item["TENKH"]).ToString();
            }
            LOADCOMBOBOX();
            
        }

        bool Ktratrangthai()
        {
            string rt = "null";
            string str = "select Trangthai from HOADONXUAT where MAHDX='" + cbo_HDBH.Text + "'";
            DataTable data = KetNoi.Instance.excuteQuery(str);

            foreach (DataRow item in data.Rows)
            {
                rt = item["Trangthai"].ToString();
            }

            if (rt != "Hoàn Thành")
            {
                return true;
            }
            return false;
        }

        private void cbo_HDBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOADCTHDBH();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (Ktratrangthai())
            {
                TaoCTBH();
                LOADCOMBOBOX();
                LOADCTHDBH();
                btnXN.Enabled = true;
                btn_fresh.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Trạng Thái đã hoàn thành Không thể Thao tác", "THÔNG BÁO!!!");
            }
            
        }

        private void cbo_MaHH_SelectedValueChanged(object sender, EventArgs e)
        {
            string str = "";
            string dongia = "";
            string query = "select * from HANGHOA where MAHANGHOA = '" + cbo_MaHH.Text + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                str = (item["TENHANGHOA"]).ToString();
                dongia = (item["DONGIA"]).ToString();
            }
            int dongiaban = int.Parse(dongia);
            txt_TenHH.Text = str;
            txt_Dongia.Text = (dongiaban +dongiaban*0.4).ToString();

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

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            if (Ktratrangthai())
            {
                if (MessageBox.Show("Bạn có muốn làm mới Hóa Đơn Bán Hàng \n Tất cả dữ liệu sẽ bị xóa!!", "Thông báo!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string query = "delete from CTHDX where MAHDX = '" + cbo_HDBH.Text + "'";
                    KetNoi.Instance.excuteNonQuery(query);
                }
                LOADCTHDBH();
            }
            else
            {
                MessageBox.Show("Trạng Thái đã hoàn thành Không thể Thao tác", "THÔNG BÁO!!!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Ktratrangthai())
            {
                try
                {
                    string query = "  UPDATE HOADONXUAT SET TONGTIEN = ( SELECT SUM(THANHTIEN) FROM CTHDX WHERE MAHDX = '" + cbo_HDBH.Text + "') where MAHDX = '" + cbo_HDBH.Text + "' ";
                    KetNoi.Instance.excuteQuery(query);
                    //CAP NHAT SO LUONG
                    MessageBox.Show("HOAN TAT NHAP HANG");
                    query = "UPDATE HOADONXUAT SET TRANGTHAI = 'Hoàn Thành' WHERE MAHDX='"+cbo_HDBH.Text+"'";
                    KetNoi.Instance.excuteNonQuery(query);
                }
                catch
                {
                    MessageBox.Show("THANH TOÁN THAT BAI");
                }
                LOADCTHDBH();
                LOADdatagrid();
            }
            else
            {
                MessageBox.Show("Trạng Thái đã hoàn thành Không thể Thao tác", "THÔNG BÁO!!!");
            }
            
            
        }

        private void cbo_MaHH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
