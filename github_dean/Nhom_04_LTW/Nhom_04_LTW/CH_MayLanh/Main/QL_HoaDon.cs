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
    public partial class QL_HoaDon : UserControl
    {
        BindingSource list = new BindingSource();
        public QL_HoaDon()
        {
            InitializeComponent();
            Grc_TABLE.DataSource = list;
            gridControl1.DataSource = list;
        }


        private void Binding()
        {
            try
            {
                cbo_MAHD.DataBindings.Add(new Binding("Text", Grc_TABLE.DataSource, "MAHDN", true, DataSourceUpdateMode.Never));
                cbo_MAHDXuat.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "MAHDNX", true, DataSourceUpdateMode.Never));

            }
            catch { }
        }




        private void QL_HoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
            LOAD_CBO();
            loadHDXuat();
            Binding();
            btnRefesh();
        }

        //NHAP
        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == groupControl2.CustomHeaderButtons[0])//LUU
            {

                btn_Save();
                LOAD_CBO();
                loaddata();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[1])//XOA
            {
                
                btn_delete();
                LOAD_CBO();
                loaddata();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[2])//FRESH
            {
                btnRefesh();
                LOAD_CBO();
                loaddata();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[3])//CLOSE
            {
                this.Hide();
            }
            
        }

        bool ktraID()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MAHD.Text == gridView1.GetRowCellValue(i, MAHDN).ToString())                   //asdasdadddddddddddddddddd
                {
                    return true;
                }
            }
            return false;
        }
        void btn_Update()
        {
            {
                if (ktraID() == false)
                {
                    string str = "SET DATEFORMAT DMY  INSERT INTO HOADONNHAP VALUES ('" + cbo_MAHD.Text + "',N'" + cbo_MANCC.Text + "',N'" + txt_TONGTIEN.Text + "',N'" + date_ngaynhap.Text + "') ";//=====================================================
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                }
                else
                {
                    string str = "SET DATEFORMAT DMY update HOADONNHAP set MAHDN = '" + cbo_MAHD.Text  + "',MANCC=N'" + cbo_MANCC.Text + "',TONGTIEN=N'" + txt_TONGTIEN.Text + "',NGAYNHAP=N'" + date_ngaynhap.Text + "' where MAHDN = '" + cbo_MAHD.Text + "'";
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Cập nhật thành công");
                    loaddata();
                }
            }
        }

        void btn_delete()
        {
            
            string str = "  delete HOADONNHAP where MAHDN='"+ cbo_MAHD.Text+ "'";
            if (KetNoi.Instance.KiemTra(str))
            {
                MessageBox.Show("Xóa thành công hóa đơn " + cbo_MAHD.Text, "Thông báo");
                loaddata();
            }
            else
            {
                MessageBox.Show("Không thể xóa hóa đơn vì đã tồn tại chi tiết hóa đơn");
            }
            
        }

        bool ktranull()
        {
            if (string.IsNullOrEmpty(cbo_MAHD.Text) || string.IsNullOrEmpty(cbo_MANCC.Text)  || string.IsNullOrEmpty(txt_TONGTIEN.Text) )
            {
                return true;
            }
            return false;
        }

        

        void btn_Save()
        {
            if (ktranull())
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin");
            }
            else
            {
                btn_Update();
            }
            
            
            loaddata();
        }

        void btnRefesh()
        {
            cbo_MAHD.Text = null;
            txt_TONGTIEN.Text = null;
            cbo_MANCC.Text = null;
            date_ngaynhap.Text = null;
        }



        private void loaddata()
        {
            
            string str = "select * from HOADONNHAP";
            list.DataSource = KetNoi.Instance.excuteQuery(str);

        }

        void LOAD_CBO()
        {
            LOAD_MAHD();
            LOAD_MANCC();
        }

        private void LOAD_MAHD()
        {
            
            cbo_MAHD.Properties.Items.Clear();
            string str = "select * from HOADONNHAP";
            DataTable data = KetNoi.Instance.excuteQuery(str);
            foreach(DataRow item in data.Rows){
                cbo_MAHD.Properties.Items.Add(item["MAHDN"]);
            }
        }

        

        private void LOAD_MANCC()
        {
            
            cbo_MANCC.Properties.Items.Clear();
            string str = "select * from NHACUNGCAP";
            DataTable data = KetNoi.Instance.excuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                cbo_MANCC.Properties.Items.Add(item["MANCC"]);
            }
            
        }



        void loadText()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MAHD.Text == gridView1.GetRowCellValue(i, MAHDN).ToString())                   //asdasdadddddddddddddddddd
                {
                    cbo_MANCC.Text = gridView1.GetRowCellValue(i, MANCC).ToString();
                    txt_TONGTIEN.Text = gridView1.GetRowCellValue(i, TONGTIEN).ToString();
                    date_ngaynhap.Text = gridView1.GetRowCellValue(i, NGAYNHAP).ToString();

                }


            }
        }




        

        private void cbo_MAHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadText();
        }

        private void cbo_MAHD_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MAHD.Text != gridView1.GetRowCellValue(i, MAHDN).ToString())                   //asdasdadddddddddddddddddd
                {
                    cbo_MANCC.Text = null;
                    date_ngaynhap.Text = null;
                    txt_TONGTIEN.Text = null;
                }
            }
        }

        // HOA DON XUAT
        //XUAT
        //CMT O DAY
        //O DAY
        //O DAY
        //O DAY
        //O DAY


        void loadHDXuat()
        {
            loaddata1();
            LOAD_CBO1();
        }

        

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == groupControl1.CustomHeaderButtons[0])
            {
                btn_Save1();
                LOAD_CBO1();
            }
            if (e.Button == groupControl1.CustomHeaderButtons[1])
            {
                btn_delete1();
                LOAD_CBO1();
            }
            if (e.Button == groupControl1.CustomHeaderButtons[2])
            {
                btnRefesh1();
                LOAD_CBO1();
            }
            if (e.Button == groupControl1.CustomHeaderButtons[3])
            {
                this.Hide();
            }

        }

        bool ktraID1()
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (cbo_MAHDXuat.Text == gridView2.GetRowCellValue(i, MAHDX).ToString())                   //asdasdadddddddddddddddddd
                {
                    return true;
                }
            }
            return false;
        }
        void btn_Update1()
        {
            {
                if (ktraID1() == false)
                {
                    string str = "SET DATEFORMAT DMY  INSERT INTO HOADONXUAT VALUES ('" + cbo_MAHDXuat.Text + "',N'" + cbo_MAKH.Text + "',N'" + txt_TienXuat.Text + "',N'" + date_NgayXuat.Text + "') ";//=====================================================
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Thêm thành công");
                    loaddata1();
                }
                else
                {
                    string str = "SET DATEFORMAT DMY update HOADONXUAT set MAHDX = '" + cbo_MAHDXuat.Text + "',MAKH=N'" + cbo_MAKH.Text +  "',TONGTIEN=N'" + txt_TienXuat.Text + "',NGAYNHAP=N'" + date_NgayXuat.Text + "' where MAHDN = '" + cbo_MAHDXuat.Text + "'";
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Cập nhật thành công");
                    loaddata1();
                }
            }
        }

        void btn_delete1()
        {

            string str = "delete from HOADONXUAT where MAHDX='" + cbo_MAHDXuat.Text + "'";
            if (KetNoi.Instance.KiemTra(str))
            {
                loaddata1();
                btnRefesh1();
            }
            else
            {
                MessageBox.Show("Không thể xóa hóa đơn vì đã tồn tại chi tiết hóa đơn");
            }
            
        }

        bool ktranull1()
        {
            if (string.IsNullOrEmpty(cbo_MAHDXuat.Text) || string.IsNullOrEmpty(cbo_MAKH.Text) || string.IsNullOrEmpty(txt_TienXuat.Text))
            {
                return true;
            }
            return false;
        }

        void btn_Save1()
        {
            if (ktranull1())
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin");
            }
            else
            {
                btn_Update1();
            }


            loaddata1();
        }

        void btnRefesh1()
        {
            cbo_MAHDXuat.Text = null;
            txt_TienXuat.Text = null;
            cbo_MAKH.Text = null;
            date_NgayXuat.Text = null;
        }



        private void loaddata1()
        {

            string str = "select * from HOADONXUAT";
            gridControl1.DataSource = KetNoi.Instance.excuteQuery(str);

        }

        void LOAD_CBO1()
        {
            LOAD_MAHD1();
            LOAD_MANCC1();
        }

        private void LOAD_MAHD1()
        {

            cbo_MAHDXuat.Properties.Items.Clear();
            string str = "select * from HOADONXUAT";
            DataTable data = KetNoi.Instance.excuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                cbo_MAHDXuat.Properties.Items.Add(item["MAHDX"]);
            }
        }

        

        private void LOAD_MANCC1()
        {

            cbo_MAKH.Properties.Items.Clear();
            string str = "select * from KHACHHANG";
            DataTable data = KetNoi.Instance.excuteQuery(str);
            foreach (DataRow item in data.Rows)
            {
                cbo_MAKH.Properties.Items.Add(item["MAKH"]);
            }

        }



        void loadText1()
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (cbo_MAHDXuat.Text == gridView2.GetRowCellValue(i, MAHDX).ToString())                   //asdasdadddddddddddddddddd
                {
                    cbo_MAKH.Text = gridView2.GetRowCellValue(i, MAKH).ToString();
                    txt_TienXuat.Text = gridView2.GetRowCellValue(i, TONGTIENXUAT).ToString();
                    date_NgayXuat.Text = gridView2.GetRowCellValue(i, NGAYXUAT).ToString();

                }


            }
        }






        private void cbo_MAHDX_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadText1();
        }

        private void cbo_MAHDX_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (cbo_MAHDXuat.Text != gridView2.GetRowCellValue(i, MAHDX).ToString())                   //asdasdadddddddddddddddddd
                {
                    cbo_MAKH.Text = null;
                    date_NgayXuat.Text = null;
                    txt_TienXuat.Text = null;
                }
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
