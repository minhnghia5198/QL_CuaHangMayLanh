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
    public partial class QL_NhanVien : System.Windows.Forms.UserControl
    {
        BindingSource list = new BindingSource();

        public QL_NhanVien()
        {
            InitializeComponent();
            Grc_TABLE.DataSource = list;
        }

        

        

        int ktranull()
        {
            if (string.IsNullOrEmpty(cbo_ID.Text)|| string.IsNullOrEmpty(Cbo_Phong.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_NAME.Text) || string.IsNullOrEmpty(txt_Num.Text) || string.IsNullOrEmpty(date_NgayLam.Text) || string.IsNullOrEmpty(date_NgaySinh.Text) || string.IsNullOrEmpty(cbo_GT.Text))
            {
                return 0;
            }
            return 1;
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            
            if (e.Button == groupControl2.CustomHeaderButtons[0])
            {
                btn_Update();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[1])
            {
                btnRefesh();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[2])
            {
                btn_delete();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[3])
            {
                this.Hide();
            }
        }

        bool ktraID1()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_ID.Text == gridView1.GetRowCellValue(i, ID).ToString())                   //asdasdadddddddddddddddddd
                {
                    return true;
                }
            }
            return false;
        }

        void BTN_SAVE()
        {
            {
                if (ktraID1() == false)
                {
                    string str = "set dateformat DMY INSERT INTO NHANVIEN VALUES ('" + cbo_ID.Text + "','" + Cbo_Phong.Text + "',N'" + txt_NAME.Text + "',N'" + cbo_GT.Text + "','" + date_NgayLam.Text + "','" + date_NgaySinh.Text + "','" + txt_Num.Text + "',N'" + txt_DiaChi.Text + "')";
                    KetNoi.Instance.excuteNonQuery(str);
                    MessageBox.Show("THÊM MỚI THÀNH CÔNG");
                    loaddata();
                }
                else
                {
                    string str = "set dateformat DMY update NHANVIEN set MANV = '" + cbo_ID.Text + "',MABP=N'" + Cbo_Phong.Text + "',TENNV=N'" + txt_NAME.Text + "',GIOITINH=N'" + cbo_GT.Text + "',NGAYVAOLAM=N'" + date_NgayLam.Text + "',NGAYSINH=N'" + date_NgaySinh.Text + "',DIENTHOAI=N'" + txt_Num.Text + "',DIACHI=N'" + txt_DiaChi.Text + "' where MANV = '" + cbo_ID.Text + "'";
                    KetNoi.Instance.excuteNonQuery(str);
                    MessageBox.Show("Cập nhật thành công");
                    loaddata();
                }
            }
        }

        void btn_Update()
        {
            if (ktranull() == 0)
            {
                MessageBox.Show("Nhập chưa đủ thông tin");
            }
            if (ktranull() == 1)
            {
                BTN_SAVE();
            }
        }
        
        void btn_delete()
        {
            
            string str = "delete from NHANVIEN where manv='"+cbo_ID.Text+"'";
            KetNoi.Instance.excuteNonQuery(str);
            loaddata();
            btnRefesh();
        }
        void btn_Save()
        {
           
            
        }

        void btnRefesh()
        {
            cbo_ID.Text = null;
            txt_NAME.Text = null;
            ngaysinh.Text = null;
            cbo_GT.Text = null;
            txt_Num.Text = null;
            Cbo_Phong.Text = null;
            date_NgayLam.Text = null;
            txt_DiaChi.Text = null;
            date_NgaySinh.Text = null;
        }

        private void QL_NV_Load(object sender, EventArgs e)
        {
            
            loaddata();
            load_CboMaNV();
            Load_CboGT();
            load_CboPB();
            Binding();
            btnRefesh();
        }

        private void loaddata()
        {
            string str = "select * from Nhanvien";
            list.DataSource = KetNoi.Instance.excuteQuery(str);

        }
        private void Binding()
        {
            try
            {
                cbo_ID.DataBindings.Add(new Binding("Text", Grc_TABLE.DataSource, "MANV", true, DataSourceUpdateMode.Never));


            }
            catch { }
        }

        private void load_CboMaNV()
        {
            
            cbo_ID.Properties.Items.Clear();
            string s = "select * from NHANVIEN";
            DataTable data = KetNoi.Instance.excuteQuery(s);
            
            foreach(DataRow item in data.Rows)
            {
                cbo_ID.Properties.Items.Add(item["MANV"]);
            }
        }

       

        void load_CboPB()
        {

            
            Cbo_Phong.Properties.Items.Clear();
            string s = "select * from BOPHAN";
            DataTable data = KetNoi.Instance.excuteQuery(s);

            foreach (DataRow item in data.Rows)
            {
                Cbo_Phong.Properties.Items.Add(item["MABP"]);
            }
        }

        void Load_CboGT()
        {
            cbo_GT.Properties.Items.Add("Nam");
            cbo_GT.Properties.Items.Add("Nữ");
        }

        
        
        void loadText()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_ID.Text == gridView1.GetRowCellValue(i, ID).ToString())                   //asdasdadddddddddddddddddd
                {
                    txt_NAME.Text = gridView1.GetRowCellValue(i, Name).ToString();
                    date_NgaySinh.Text = gridView1.GetRowCellValue(i, Birthday).ToString();
                    cbo_GT.Text = gridView1.GetRowCellValue(i, Sex).ToString();
                    txt_Num.Text = gridView1.GetRowCellValue(i, Number).ToString();
                    Cbo_Phong.Text = gridView1.GetRowCellValue(i, Room).ToString();
                    date_NgayLam.Text = gridView1.GetRowCellValue(i, NgayLam).ToString();
                    txt_DiaChi.Text = gridView1.GetRowCellValue(i, Address).ToString();
                }


            }
        }

        private void cbo_ID_EditValueChanged(object sender, EventArgs e)
        {

            loadText();
        }

        private void cbo_ID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_ID.Text != gridView1.GetRowCellValue(i, ID).ToString())                   //asdasdadddddddddddddddddd
                {
                    txt_NAME.Text = null;
                    cbo_GT.Text = null;
                    txt_Num.Text = null;
                    Cbo_Phong.Text = null;
                    date_NgayLam.Text = null;
                    txt_DiaChi.Text = null;

                }
            }
        }

        private void txt_Num_Leave(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt_Num.Text);
            }
            catch
            {
                MessageBox.Show("Số điện thoại phải là số!");
            }
        }

        private void Grc_TABLE_Click(object sender, EventArgs e)
        {
            loadText();
        }

        private void cbo_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
