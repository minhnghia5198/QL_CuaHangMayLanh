using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main
{
    public partial class FrmLogin : Form        //Data Source=DESKTOP-9KUAGON\SQLEXPRESS;Initial Catalog=Login;Persist Security Info=True;User ID=sa
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9KUAGON\SQLEXPRESS;Initial Catalog=Login;Persist Security Info=True;User ID=sa;Password=sa2012");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_DN_Click(object sender, EventArgs e)
        {

            string user = txtUser.Text.Trim();//get dữ liệu từ textbox tài khoản
            string pass = txtPass.Text;//get dữ liệu từ textbox mật khẩu
            if (user == string.Empty)//kiểm tra tài khoản có được nhập chưa
            {
                MessageBox.Show("Hãy nhập tài khoản ");
            }
            else
            {
                if (pass == string.Empty)
                    MessageBox.Show("Hãy nhập Password");
                else
                {
                    try
                    {

                        //kết nối SQL 

                        //đưa tài khoản ,mật khẩu xuống SQL
                        //string src = "SELECT MAND, MATKHAU FROM NGUOIDUNG WHERE MAND='" + user + "'and MATKHAU='" + pass + "'";
                        //DataTable DATA = KetNoi.Instance.excuteQuery(src);

                        //if (DATA.Rows.Count > 0)
                        //{
                        //    MessageBox.Show("Đăng Nhập thành công", "Thông báo");
                        //    FrmMain frmMain = new FrmMain();
                        //    frmMain.Show();
                        //    this.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo");
                        //}
                        DANGNHAP();



                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!!!!!!!!");
                    }
                }
            }

            void DANGNHAP()
            {
                string MATKHAU = "";
                string src = "SELECT MATKHAU FROM NGUOIDUNG WHERE MAND='" + user+"'";
                DataTable DATA = KetNoi.Instance.excuteQuery(src);
                foreach(DataRow ITEM in DATA.Rows)
                {
                    MATKHAU = ITEM["MATKHAU"].ToString();
                }
                if (MATKHAU==pass)
                {
                    MessageBox.Show("Đăng Nhập thành công", "Thông báo");
                    this.Hide();
                    FrmMain frmMain = new FrmMain();
                    frmMain.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo");
                }
            }
        }
    }
}
