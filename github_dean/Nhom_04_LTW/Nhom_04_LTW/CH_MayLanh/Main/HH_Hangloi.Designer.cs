namespace Main
{
    partial class HH_Hangloi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HH_Hangloi));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode1 = new DevExpress.XtraEditors.BreadCrumbNode();
            this.Grp_HangLoi = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Grc_TABLE = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SERI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.cbo_ID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_NAME = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Root1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_MaSeri = new DevExpress.XtraEditors.TextEdit();
            this.cbo_GT = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_HangLoi)).BeginInit();
            this.Grp_HangLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grc_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_HangLoi
            // 
            this.Grp_HangLoi.ContentImage = ((System.Drawing.Image)(resources.GetObject("Grp_HangLoi.ContentImage")));
            this.Grp_HangLoi.Controls.Add(this.groupControl2);
            this.Grp_HangLoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp_HangLoi.Location = new System.Drawing.Point(0, 0);
            this.Grp_HangLoi.Name = "Grp_HangLoi";
            this.Grp_HangLoi.Size = new System.Drawing.Size(988, 667);
            this.Grp_HangLoi.TabIndex = 5;
            this.Grp_HangLoi.Text = "HÀNG LỖI";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Grc_TABLE);
            this.groupControl2.Controls.Add(this.groupBox1);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thoát", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 25);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(984, 640);
            this.groupControl2.TabIndex = 1;
            // 
            // Grc_TABLE
            // 
            this.Grc_TABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grc_TABLE.Location = new System.Drawing.Point(2, 182);
            this.Grc_TABLE.MainView = this.gridView1;
            this.Grc_TABLE.Name = "Grc_TABLE";
            this.Grc_TABLE.Size = new System.Drawing.Size(980, 456);
            this.Grc_TABLE.TabIndex = 4;
            this.Grc_TABLE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHH,
            this.TENHH,
            this.SERI,
            this.TINHTRANG,
            this.GHICHU});
            this.gridView1.GridControl = this.Grc_TABLE;
            this.gridView1.Name = "gridView1";
            // 
            // MAHH
            // 
            this.MAHH.Caption = "MÃ HÀNG HÓA";
            this.MAHH.FieldName = "MAHH";
            this.MAHH.MinWidth = 25;
            this.MAHH.Name = "MAHH";
            this.MAHH.Visible = true;
            this.MAHH.VisibleIndex = 0;
            this.MAHH.Width = 128;
            // 
            // TENHH
            // 
            this.TENHH.Caption = "TÊN HÀNG HÓA";
            this.TENHH.FieldName = "TENHH";
            this.TENHH.MinWidth = 25;
            this.TENHH.Name = "TENHH";
            this.TENHH.Visible = true;
            this.TENHH.VisibleIndex = 1;
            this.TENHH.Width = 287;
            // 
            // SERI
            // 
            this.SERI.Caption = "SERI SẢN PHẨM";
            this.SERI.FieldName = "SERI";
            this.SERI.MinWidth = 25;
            this.SERI.Name = "SERI";
            this.SERI.Visible = true;
            this.SERI.VisibleIndex = 2;
            this.SERI.Width = 114;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Caption = "TÌNH TRẠNG";
            this.TINHTRANG.FieldName = "TINHTRANG";
            this.TINHTRANG.MinWidth = 25;
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Visible = true;
            this.TINHTRANG.VisibleIndex = 3;
            this.TINHTRANG.Width = 155;
            // 
            // GHICHU
            // 
            this.GHICHU.Caption = "GHI CHÚ";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.MinWidth = 25;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 4;
            this.GHICHU.Width = 278;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.cbo_ID);
            this.layoutControl2.Controls.Add(this.txt_NAME);
            this.layoutControl2.Controls.Add(this.txt_DiaChi);
            this.layoutControl2.Controls.Add(this.txt_MaSeri);
            this.layoutControl2.Controls.Add(this.cbo_GT);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 19);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(974, 127);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // cbo_ID
            // 
            this.cbo_ID.Location = new System.Drawing.Point(113, 22);
            this.cbo_ID.Name = "cbo_ID";
            this.cbo_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_ID.Size = new System.Drawing.Size(215, 22);
            this.cbo_ID.StyleController = this.layoutControl2;
            this.cbo_ID.TabIndex = 4;
            // 
            // txt_NAME
            // 
            this.txt_NAME.Location = new System.Drawing.Point(423, 22);
            this.txt_NAME.Name = "txt_NAME";
            this.txt_NAME.Size = new System.Drawing.Size(529, 22);
            this.txt_NAME.StyleController = this.layoutControl2;
            this.txt_NAME.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Root1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(974, 127);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Root1
            // 
            this.Root1.CustomizationFormText = "Root";
            this.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root1.GroupBordersVisible = false;
            this.Root1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem13,
            this.layoutControlItem15});
            this.Root1.Location = new System.Drawing.Point(0, 0);
            this.Root1.Name = "Root1";
            this.Root1.Size = new System.Drawing.Size(954, 107);
            this.Root1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root1.Text = "Root";
            this.Root1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cbo_ID;
            this.layoutControlItem9.CustomizationFormText = "Mã nhân viên";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(310, 26);
            this.layoutControlItem9.Text = "MÃ HÀNG HÓA";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txt_NAME;
            this.layoutControlItem10.CustomizationFormText = "Tên nhân viên";
            this.layoutControlItem10.Location = new System.Drawing.Point(310, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(624, 26);
            this.layoutControlItem10.Text = "TÊN HÀNG HÓA";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txt_MaSeri;
            this.layoutControlItem11.CustomizationFormText = "Ngày sinh";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(310, 30);
            this.layoutControlItem11.Text = "Seri Sản Phẩm";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(88, 16);
            // 
            // txt_MaSeri
            // 
            this.txt_MaSeri.EditValue = "";
            this.txt_MaSeri.Location = new System.Drawing.Point(113, 48);
            this.txt_MaSeri.Name = "txt_MaSeri";
            this.txt_MaSeri.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_MaSeri.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_MaSeri.Properties.Mask.EditMask = "99/99/0000";
            this.txt_MaSeri.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txt_MaSeri.Size = new System.Drawing.Size(215, 22);
            this.txt_MaSeri.StyleController = this.layoutControl2;
            this.txt_MaSeri.TabIndex = 6;
            // 
            // cbo_GT
            // 
            this.cbo_GT.Location = new System.Drawing.Point(423, 48);
            this.cbo_GT.Name = "cbo_GT";
            this.cbo_GT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            breadCrumbNode1.Caption = "Root";
            breadCrumbNode1.Value = "Root";
            this.cbo_GT.Properties.Nodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode1});
            this.cbo_GT.Size = new System.Drawing.Size(529, 26);
            this.cbo_GT.StyleController = this.layoutControl2;
            this.cbo_GT.TabIndex = 8;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.cbo_GT;
            this.layoutControlItem13.CustomizationFormText = "Giới tính";
            this.layoutControlItem13.Location = new System.Drawing.Point(310, 26);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(624, 30);
            this.layoutControlItem13.Text = "TÌNH TRẠNG";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.txt_DiaChi;
            this.layoutControlItem15.CustomizationFormText = "Địa chỉ";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(934, 31);
            this.layoutControlItem15.Text = "GHI CHÚ";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(88, 16);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(113, 78);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(839, 22);
            this.txt_DiaChi.StyleController = this.layoutControl2;
            this.txt_DiaChi.TabIndex = 10;
            // 
            // HH_Hangloi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp_HangLoi);
            this.Name = "HH_Hangloi";
            this.Size = new System.Drawing.Size(988, 667);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_HangLoi)).EndInit();
            this.Grp_HangLoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grc_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Grp_HangLoi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Grc_TABLE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAHH;
        private DevExpress.XtraGrid.Columns.GridColumn TENHH;
        private DevExpress.XtraGrid.Columns.GridColumn SERI;
        private DevExpress.XtraGrid.Columns.GridColumn TINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_ID;
        private DevExpress.XtraEditors.TextEdit txt_NAME;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_MaSeri;
        private DevExpress.XtraEditors.BreadCrumbEdit cbo_GT;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
    }
}
