using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.Data.SqlClient;


namespace Main
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        

        public FrmMain()
        {
            InitializeComponent();
        }
        
        

        private void nav_Nhanvien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QL_NhanVien n = new QL_NhanVien();
            Adduser(n);
        }

        

        private void nav_Khachhang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QL_KH n = new QL_KH();
            Adduser(n);
        }

        private void nav_NCC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QL_NCC n = new QL_NCC();
            Adduser(n);
        }

        private void nav_hoadon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QL_HoaDon n = new QL_HoaDon();
            Adduser(n);
        }

       
        private void navTaotk_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HT_TaoTK add = new HT_TaoTK();
            Adduser(add);
        }

        private void Adduser(Control cr)
        {
            cr.Dock = DockStyle.Fill;
            pn_main.Controls.Clear();
            pn_main.Controls.Add(cr);
        }

        private void navDoimk_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HT_DoiMK add = new HT_DoiMK();
            Adduser(add);
        }

        private void nav_Hangtonkho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HH_HangTonkho add = new HH_HangTonkho();
            Adduser(add);
            
        }

        private void nav_Nhaphang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HH_NhapHang add = new HH_NhapHang();
            Adduser(add);
        }

        private void nav_Banhang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HH_BanHang add = new HH_BanHang();
            Adduser(add);
        }

        private void nav_Hangloi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HH_Hangloi add = new HH_Hangloi();
            Adduser(add);
        }

        private void nav_Taichinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QL_TAICHINH add = new QL_TAICHINH();
            Adduser(add);
        }
    }
}