namespace Main
{
    partial class QL_TAICHINH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_TAICHINH));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_show = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TongBan = new DevExpress.XtraEditors.TextEdit();
            this.txt_TongNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Sum = new DevExpress.XtraEditors.TextEdit();
            this.cbo_Thang = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Thang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Đóng", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(988, 667);
            this.groupControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.btn_show);
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.cbo_Thang);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 33);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(984, 632);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "QUẢN LÝ TÀI CHÍNH CỬA HÀNG";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(148, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 29);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Tháng :";
            // 
            // btn_show
            // 
            this.btn_show.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btn_show.Appearance.Options.UseFont = true;
            this.btn_show.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_show.Location = new System.Drawing.Point(452, 56);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(101, 39);
            this.btn_show.TabIndex = 3;
            this.btn_show.Text = "Lọc";
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TongBan);
            this.groupBox1.Controls.Add(this.txt_TongNhap);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txt_Sum);
            this.groupBox1.Location = new System.Drawing.Point(21, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ THU NHẬP CỦA CỬA HÀNG";
            // 
            // txt_TongBan
            // 
            this.txt_TongBan.Location = new System.Drawing.Point(267, 70);
            this.txt_TongBan.Name = "txt_TongBan";
            this.txt_TongBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txt_TongBan.Properties.Appearance.Options.UseFont = true;
            this.txt_TongBan.Size = new System.Drawing.Size(481, 36);
            this.txt_TongBan.TabIndex = 11;
            // 
            // txt_TongNhap
            // 
            this.txt_TongNhap.Location = new System.Drawing.Point(267, 226);
            this.txt_TongNhap.Name = "txt_TongNhap";
            this.txt_TongNhap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txt_TongNhap.Properties.Appearance.Options.UseFont = true;
            this.txt_TongNhap.Size = new System.Drawing.Size(481, 36);
            this.txt_TongNhap.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(57, 363);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(177, 29);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Lợi nhuận thu về:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(57, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(132, 29);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tổng chi phí:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(153, 29);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tổng thu nhập:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 324);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 1;
            // 
            // txt_Sum
            // 
            this.txt_Sum.Location = new System.Drawing.Point(267, 360);
            this.txt_Sum.Name = "txt_Sum";
            this.txt_Sum.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txt_Sum.Properties.Appearance.Options.UseFont = true;
            this.txt_Sum.Size = new System.Drawing.Size(481, 36);
            this.txt_Sum.TabIndex = 9;
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.Location = new System.Drawing.Point(283, 55);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cbo_Thang.Properties.Appearance.Options.UseFont = true;
            this.cbo_Thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_Thang.Size = new System.Drawing.Size(148, 36);
            this.cbo_Thang.TabIndex = 14;
            // 
            // QL_TAICHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "QL_TAICHINH";
            this.Size = new System.Drawing.Size(988, 667);
            this.Load += new System.EventHandler(this.QL_TAICHINH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Thang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TongBan;
        private DevExpress.XtraEditors.TextEdit txt_TongNhap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Sum;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn_show;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_Thang;
    }
}
