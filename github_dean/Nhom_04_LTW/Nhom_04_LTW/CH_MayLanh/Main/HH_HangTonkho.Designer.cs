namespace Main
{
    partial class HH_HangTonkho
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HH_HangTonkho));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.Grp_KHOHANG = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Grc_TABLE = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cbo_MaHH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_tenHH = new DevExpress.XtraEditors.TextEdit();
            this.txt_dongia = new DevExpress.XtraEditors.TextEdit();
            this.cbo_MANCC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_KHOHANG)).BeginInit();
            this.Grp_KHOHANG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grc_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_MaHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_MANCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_KHOHANG
            // 
            this.Grp_KHOHANG.Controls.Add(this.groupControl2);
            this.Grp_KHOHANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp_KHOHANG.Location = new System.Drawing.Point(0, 0);
            this.Grp_KHOHANG.Name = "Grp_KHOHANG";
            this.Grp_KHOHANG.Size = new System.Drawing.Size(988, 667);
            this.Grp_KHOHANG.TabIndex = 4;
            this.Grp_KHOHANG.Text = "KHO HÀNG";
            this.Grp_KHOHANG.Paint += new System.Windows.Forms.PaintEventHandler(this.Grp_KHOHANG_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Grc_TABLE);
            this.groupControl2.Controls.Add(this.groupBox1);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
            buttonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions4.Image")));
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, true, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Fresh", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thoát", true, buttonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 25);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(984, 640);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl2_CustomButtonClick);
            // 
            // Grc_TABLE
            // 
            this.Grc_TABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grc_TABLE.Location = new System.Drawing.Point(2, 148);
            this.Grc_TABLE.MainView = this.gridView1;
            this.Grc_TABLE.Name = "Grc_TABLE";
            this.Grc_TABLE.Size = new System.Drawing.Size(980, 490);
            this.Grc_TABLE.TabIndex = 4;
            this.Grc_TABLE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grc_TABLE.Click += new System.EventHandler(this.Grc_TABLE_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHH,
            this.TENHH,
            this.SOLUONG,
            this.DONGIA,
            this.MANCC});
            this.gridView1.GridControl = this.Grc_TABLE;
            this.gridView1.Name = "gridView1";
            // 
            // MAHH
            // 
            this.MAHH.Caption = "MÃ HÀNG HÓA";
            this.MAHH.FieldName = "MAHANGHOA";
            this.MAHH.MinWidth = 25;
            this.MAHH.Name = "MAHH";
            this.MAHH.Visible = true;
            this.MAHH.VisibleIndex = 0;
            this.MAHH.Width = 111;
            // 
            // TENHH
            // 
            this.TENHH.Caption = "TÊN HÀNG HÓA";
            this.TENHH.FieldName = "TENHANGHOA";
            this.TENHH.MinWidth = 25;
            this.TENHH.Name = "TENHH";
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
            this.TENHH.Width = 233;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Caption = "SỐ LƯỢNG";
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.MinWidth = 25;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 2;
            this.SOLUONG.Width = 218;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            this.DONGIA.Width = 130;
            // 
            // MANCC
            // 
            this.MANCC.Caption = "NHÀ CUNG CẤP";
            this.MANCC.FieldName = "MANCC";
            this.MANCC.MinWidth = 25;
            this.MANCC.Name = "MANCC";
            this.MANCC.Visible = true;
            this.MANCC.VisibleIndex = 4;
            this.MANCC.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.txt_soluong);
            this.layoutControl2.Controls.Add(this.cbo_MaHH);
            this.layoutControl2.Controls.Add(this.txt_tenHH);
            this.layoutControl2.Controls.Add(this.txt_dongia);
            this.layoutControl2.Controls.Add(this.cbo_MANCC);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 19);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(974, 93);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Enabled = false;
            this.txt_soluong.Location = new System.Drawing.Point(753, 12);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(209, 25);
            this.txt_soluong.TabIndex = 5;
            // 
            // cbo_MaHH
            // 
            this.cbo_MaHH.Location = new System.Drawing.Point(110, 12);
            this.cbo_MaHH.Name = "cbo_MaHH";
            this.cbo_MaHH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_MaHH.Size = new System.Drawing.Size(230, 22);
            this.cbo_MaHH.StyleController = this.layoutControl2;
            this.cbo_MaHH.TabIndex = 4;
            this.cbo_MaHH.SelectedIndexChanged += new System.EventHandler(this.cbo_MAHD_SelectedIndexChanged);
            this.cbo_MaHH.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbo_MAHD_EditValueChanging);
            // 
            // txt_tenHH
            // 
            this.txt_tenHH.Location = new System.Drawing.Point(442, 12);
            this.txt_tenHH.Name = "txt_tenHH";
            this.txt_tenHH.Size = new System.Drawing.Size(209, 22);
            this.txt_tenHH.StyleController = this.layoutControl2;
            this.txt_tenHH.TabIndex = 5;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(110, 41);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(230, 22);
            this.txt_dongia.StyleController = this.layoutControl2;
            this.txt_dongia.TabIndex = 11;
            // 
            // cbo_MANCC
            // 
            this.cbo_MANCC.Location = new System.Drawing.Point(442, 41);
            this.cbo_MANCC.Name = "cbo_MANCC";
            this.cbo_MANCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_MANCC.Size = new System.Drawing.Size(520, 22);
            this.cbo_MANCC.StyleController = this.layoutControl2;
            this.cbo_MANCC.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(974, 93);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbo_MaHH;
            this.layoutControlItem1.CustomizationFormText = "Mã NCC";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(332, 29);
            this.layoutControlItem1.Text = "Mã HÀNG HÓA";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_tenHH;
            this.layoutControlItem2.CustomizationFormText = "Tên NCC";
            this.layoutControlItem2.Location = new System.Drawing.Point(332, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(311, 29);
            this.layoutControlItem2.Text = "TÊN HÀNG HÓA";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_dongia;
            this.layoutControlItem8.CustomizationFormText = "Địa chỉ";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(332, 44);
            this.layoutControlItem8.Text = "ĐƠN GIA";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_soluong;
            this.layoutControlItem4.Location = new System.Drawing.Point(643, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(311, 29);
            this.layoutControlItem4.Text = "SỐ LƯỢNG";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbo_MANCC;
            this.layoutControlItem3.Location = new System.Drawing.Point(332, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(622, 44);
            this.layoutControlItem3.Text = "NHÀ CUNG CẤP";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 17);
            // 
            // HH_HangTonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp_KHOHANG);
            this.Name = "HH_HangTonkho";
            this.Size = new System.Drawing.Size(988, 667);
            this.Load += new System.EventHandler(this.HH_HangTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_KHOHANG)).EndInit();
            this.Grp_KHOHANG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grc_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_MaHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_MANCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Grp_KHOHANG;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Grc_TABLE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.TextBox txt_soluong;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_MaHH;
        private DevExpress.XtraEditors.TextEdit txt_tenHH;
        private DevExpress.XtraEditors.TextEdit txt_dongia;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_MANCC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn MANCC;
    }
}
