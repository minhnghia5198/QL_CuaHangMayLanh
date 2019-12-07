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
using DevExpress.XtraEditors;

namespace Main
{
    public partial class QL_KH : System.Windows.Forms.UserControl
    {
        BindingSource list = new BindingSource();

        public QL_KH()
        {
            InitializeComponent();
            Grc_TABLE.DataSource = list;
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == groupControl2.CustomHeaderButtons[0])
            {
                btn_Update();
                load_CboMaKH();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[1])
            {
                btnRefesh();
                load_CboMaKH();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[2])
            {
                btn_delete();
                load_CboMaKH();
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
                if (cbo_MaKH.Text == gridView1.GetRowCellValue(i, MAKH).ToString())                   //asdasdadddddddddddddddddd
                {
                    return true;
                }
            }
            return false;
        }

        void btn_Update()
        {
            {
                if (ktraID1() == false)
                {
                    string str = "INSERT INTO KHACHHANG VALUES ('" + cbo_MaKH.Text + "',N'" + txt_TenKH.Text + "',N'" + txt_DiaChi.Text + "') ";
                    KetNoi.Instance.excuteNonQuery(str);
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                }
                else
                {
                    string str = "update KHACHHANG set MAKH = '" + cbo_MaKH.Text + "',TENKH=N'" + txt_TenKH.Text + "',DIACHI=N'" + txt_DiaChi.Text + "' where MAKH = '" + cbo_MaKH.Text + "'";
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Cập nhật thành công");
                    loaddata();
                }
            }
        }

        void btn_delete()
        {
            
            string str = "delete from khachhang where makh='" + cbo_MaKH.Text + "'";
            KetNoi.Instance.excuteNonQuery(str);
            loaddata();
            btnRefesh();
        }
        void btn_Save()
        {
           
        }

        void btnRefesh()
        {
            cbo_MaKH.Text = null;
            txt_TenKH.Text = null;
            txt_DiaChi.Text = null;
        }

        private void QL__Load(object sender, EventArgs e)
        {

            loaddata();
            load_CboMaKH();
            Binding();
            btnRefesh();
            //addBlinding();
        }

        private void Binding()
        {
            try
            {
                cbo_MaKH.DataBindings.Add(new Binding("Text", Grc_TABLE.DataSource, "MAKH", true, DataSourceUpdateMode.Never));


            }
            catch { }
        }

        private void loaddata()
        {
            
            string str = "select * from KHACHHANG";
            list.DataSource = KetNoi.Instance.excuteQuery(str);

        }


        private void load_CboMaKH()
        {
            
            cbo_MaKH.Properties.Items.Clear();
            string s = "select * from KHACHHANG";
            DataTable data = KetNoi.Instance.excuteQuery(s);

            foreach (DataRow item in data.Rows)
            {
                cbo_MaKH.Properties.Items.Add(item["MAKH"]);
            }
            
        }

        

        void loadText()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MaKH.Text == gridView1.GetRowCellValue(i, MAKH).ToString())                   //asdasdadddddddddddddddddd
                {
                    txt_TenKH.Text = gridView1.GetRowCellValue(i, TENKH).ToString();
                    txt_DiaChi.Text = gridView1.GetRowCellValue(i, DIACHI).ToString();

                }


            }
        }
        
        
        private void cbo_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadText();
        }

        private void cbo_MaKH_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MaKH.Text != gridView1.GetRowCellValue(i, MAKH).ToString())                   //asdasdadddddddddddddddddd
                {
                    txt_TenKH.Text = null;
                    txt_DiaChi.Text = null;

                }
            }
        }
    }
}

