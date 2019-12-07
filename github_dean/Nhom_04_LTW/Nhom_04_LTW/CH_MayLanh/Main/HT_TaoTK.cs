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
    public partial class HT_TaoTK : UserControl
    {
        public HT_TaoTK()
        {
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (txtPASS.Text == txtPASS1.Text)
            {
                string query = "INSERT INTO NGUOIDUNG(MAND, MATKHAU) VALUES ('" + txtUSER.Text + "','" + txtPASS.Text + "')";
                if (KetNoi.Instance.KiemTra(query))
                {
                    MessageBox.Show("Đã tạo mới tài khoản thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng");
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LOADCB()
        {
            string query = "select * from nhanvien";
            txtUSER.Properties.Items.Clear();
            DataTable data = KetNoi.Instance.excuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                txtUSER.Properties.Items.Add(item["MANV"]);
            }
        }

        private void HT_TaoTK_Load(object sender, EventArgs e)
        {
            LOADCB();
        }
    }
}
