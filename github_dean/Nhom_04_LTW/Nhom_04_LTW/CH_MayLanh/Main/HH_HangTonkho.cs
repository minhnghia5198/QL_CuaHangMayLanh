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
    public partial class HH_HangTonkho : UserControl
    {
        BindingSource list = new BindingSource();
        public HH_HangTonkho()
        {
            InitializeComponent();
            Grc_TABLE.DataSource = list;
        }

        private void Binding()
        {
            try
            {
                //cbo_MaHH.DataBindings.Add(new Binding("Text", Grc_TABLE.DataSource, "MAHH", true, DataSourceUpdateMode.Never));

            }
            catch { }
        }




        private void HH_HangTonKho_Load(object sender, EventArgs e)
        {
            loaddata();
            LOAD_CBO();
            Binding();
            btnRefesh();
        }

        //NHAP
        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == groupControl2.CustomHeaderButtons[0])
            {
                btn_Update();
                LOAD_CBO();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[1])
            {
                btnRefesh();
                LOAD_CBO();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[2])
            {
                btn_delete();
                LOAD_CBO();
            }
            if (e.Button == groupControl2.CustomHeaderButtons[3])
            {
                this.Hide();
            }

        }

        bool ktraID()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (cbo_MaHH.Text == gridView1.GetRowCellValue(i, MAHH).ToString())                   //asdasdadddddddddddddddddd
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
                    string str = "INSERT INTO HANGHOA VALUES ('" + cbo_MaHH.Text + "',N'" + txt_tenHH.Text + "',N'" + txt_soluong.Text + "',N'" + txt_dongia.Text + "',N'" + cbo_MANCC.Text +"') ";//=====================================================
                    KetNoi.Instance.excuteQuery(str);
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                }
                else
                {
                    string str = "update HANGHOA set TENHANGHOA=N'" + txt_tenHH.Text + "',DONGIA=" + txt_dongia.Text + ",MANCC=N'" + cbo_MANCC.Text + "' where MAHANGHOA = '" + cbo_MaHH.Text + "'";
                    KetNoi.Instance.excuteNonQuery(str);
                    MessageBox.Show("Cập nhật thành công");
                    loaddata();
                }
            }
        }

        void btn_delete()
        {

            string str = "delete from HANGHOA where MAHANGHOA='" + cbo_MaHH.Text + "'";
            KetNoi.Instance.excuteQuery(str);
            loaddata();
            btnRefesh();
        }
        

        

        void btnRefesh()
        {
            cbo_MaHH.Text = null;
            txt_dongia.Text = null;
            cbo_MANCC.Text = null;
            cbo_MaHH.Text = null;
            txt_tenHH.Text = null;
            txt_soluong.Text = null;
        }



        private void loaddata()
        {

            try
            {
                string str = "select * from HANGHOA";
                list.DataSource = KetNoi.Instance.excuteQuery(str);
            }
            catch
            {

            }

        }

        void LOAD_CBO()
        {
            LOAD_MAHH();
            LOAD_MANCC();
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
                if (cbo_MaHH.Text == gridView1.GetRowCellValue(i,MAHH).ToString())                   //asdasdadddddddddddddddddd
                {
                    
                    cbo_MANCC.Text = gridView1.GetRowCellValue(i, MANCC).ToString();
                    txt_dongia.Text = gridView1.GetRowCellValue(i, DONGIA).ToString();
                    txt_tenHH.Text = gridView1.GetRowCellValue(i, TENHH).ToString();
                    txt_soluong.Text = gridView1.GetRowCellValue(i, SOLUONG).ToString();
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
                if (cbo_MaHH.Text != gridView1.GetRowCellValue(i, MAHH).ToString())                   //asdasdadddddddddddddddddd
                {
                    txt_dongia.Text = null;
                    cbo_MANCC.Text = null;
                    txt_tenHH.Text = null;
                    txt_soluong.Text = null;

                }
            }
        }


        private void Grp_KHOHANG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Grc_TABLE_Click(object sender, EventArgs e)
        {

        }
    }
}
