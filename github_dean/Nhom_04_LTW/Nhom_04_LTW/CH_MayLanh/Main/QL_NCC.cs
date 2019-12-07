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
    public partial class QL_NCC : UserControl
    {
        BindingSource list = new BindingSource();
        public QL_NCC()
        {
            InitializeComponent();
            Grc_TABLE.DataSource = list;
        }

        private void QL_NCC_Load(object sender, EventArgs e)
        {
            loaddata();
            load_CboMaNCC();
            Binding();
            btnRefesh();
        }

        private void Grp_Nhanvien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Binding()
        {
            try
            {
                cbo_MaNCC.DataBindings.Add(new Binding("Text", Grc_TABLE.DataSource, "MANCC", true, DataSourceUpdateMode.Never));


            }
            catch { }
        }
        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            
            if (e.Button == groupControl2.CustomHeaderButtons[0])
            {
                btn_Update();
                load_CboMaNCC();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[1])
            {
                btnRefesh();
                load_CboMaNCC();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[2])
            {
                btn_delete();
                load_CboMaNCC();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[3])
            {
                this.Hide();
            }
        }

        int ktranull()
        {
            if (string.IsNullOrEmpty(cbo_MaNCC.Text) || string.IsNullOrEmpty(txt_Diachi.Text) || string.IsNullOrEmpty(txt_TenNCC.Text) )
            {
                return 0;
            }
            return 1;
        }


        bool ktraID()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MaNCC.Text == gridView1.GetRowCellValue(i, MANCC).ToString())                   //asdasdadddddddddddddddddd
                {
                    return true;
                }
            }
            return false;
        }
        void btn_Update()
        {
            if (ktranull() == 0)
            {
                MessageBox.Show("Nhập chưa đủ thông tin");
            }
            if (ktranull() == 1)
            {
                if (ktraID() == false)
                {
                    string str = "INSERT INTO NHACUNGCAP VALUES ('" + cbo_MaNCC.Text + "',N'" + txt_TenNCC.Text + "',N'" + txt_Diachi.Text + "') ";
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                }
                else
                {
                    string str = "update NHACUNGCAP set MANCC = '" + cbo_MaNCC.Text + "',TENNCC=N'" + txt_TenNCC.Text + "',DIACHI=N'" + txt_Diachi.Text + "' where MANCC = '" + cbo_MaNCC.Text + "'";
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Cập nhật thành công");
                    loaddata();
                }
                    
                    
                
                   
                    
               
            }
        }

        void btn_delete()
        {
            try
            {
                
                string str = "delete from NHACUNGCAP where MANCC='" + cbo_MaNCC.Text + "'";
                KetNoi.Instance.excuteQuery(str);
                MessageBox.Show("Xóa thành công");
                loaddata();
                btnRefesh();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        void btn_Save()
        {
            
        }

        void btnRefesh()
        {
            cbo_MaNCC.Text = null;
            txt_TenNCC.Text = null;
            txt_Diachi.Text = null;
        }

        

        private void loaddata()
        {
            
            string str = "select * from NHACUNGCAP";
            Grc_TABLE.DataSource = KetNoi.Instance.excuteQuery(str);

        }

        private void load_CboMaNCC()
        {
           
            cbo_MaNCC.Properties.Items.Clear();
            string s = "select * from NHACUNGCAP";
            DataTable data = KetNoi.Instance.excuteQuery(s);
            foreach(DataRow item in data.Rows)
            {
                cbo_MaNCC.Properties.Items.Add(item["MANCC"]);
            }
            
        }



        void loadText()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MaNCC.Text == gridView1.GetRowCellValue(i, MANCC).ToString())                   //asdasdadddddddddddddddddd
                {
                    txt_TenNCC.Text = gridView1.GetRowCellValue(i, TENNCC).ToString();
                    txt_Diachi.Text = gridView1.GetRowCellValue(i, DIACHI).ToString();

                }


            }
        }

        
        

        private void cbo_MaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadText();
        }

        private void cbo_MaNCC_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MaNCC.Text != gridView1.GetRowCellValue(i, MANCC).ToString())                   //asdasdadddddddddddddddddd
                {
                    txt_TenNCC.Text = null;
                    txt_Diachi.Text = null;
                }
            }
        }
    }

}
