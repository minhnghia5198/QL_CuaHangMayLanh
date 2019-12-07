namespace Main
{
    partial class HT_TaoTK
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
            this.Grp_TaoTk = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddUser = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPASS1 = new System.Windows.Forms.TextBox();
            this.txtUSER = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_TaoTk)).BeginInit();
            this.Grp_TaoTk.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_TaoTk
            // 
            this.Grp_TaoTk.Controls.Add(this.panel1);
            this.Grp_TaoTk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp_TaoTk.Location = new System.Drawing.Point(0, 0);
            this.Grp_TaoTk.Name = "Grp_TaoTk";
            this.Grp_TaoTk.Size = new System.Drawing.Size(988, 667);
            this.Grp_TaoTk.TabIndex = 2;
            this.Grp_TaoTk.Text = "Tạo tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUSER);
            this.panel1.Controls.Add(this.btn_AddUser);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtPASS);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txtPASS1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 640);
            this.panel1.TabIndex = 10;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(292, 437);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(392, 46);
            this.btn_AddUser.TabIndex = 9;
            this.btn_AddUser.Text = "Tạo tài khoản";
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(214, 159);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 17);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Tài khoản";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(154, 315);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Xác nhận mật khẩu";
            // 
            // txtPASS
            // 
            this.txtPASS.Location = new System.Drawing.Point(292, 238);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.PasswordChar = '*';
            this.txtPASS.Size = new System.Drawing.Size(392, 23);
            this.txtPASS.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(217, 241);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 17);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Mật khẩu";
            // 
            // txtPASS1
            // 
            this.txtPASS1.Location = new System.Drawing.Point(292, 312);
            this.txtPASS1.Name = "txtPASS1";
            this.txtPASS1.PasswordChar = '*';
            this.txtPASS1.Size = new System.Drawing.Size(392, 23);
            this.txtPASS1.TabIndex = 3;
            // 
            // txtUSER
            // 
            this.txtUSER.Location = new System.Drawing.Point(292, 156);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUSER.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtUSER.Size = new System.Drawing.Size(392, 22);
            this.txtUSER.TabIndex = 10;
            this.txtUSER.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // HT_TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp_TaoTk);
            this.Name = "HT_TaoTK";
            this.Size = new System.Drawing.Size(988, 667);
            this.Load += new System.EventHandler(this.HT_TaoTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_TaoTk)).EndInit();
            this.Grp_TaoTk.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUSER.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Grp_TaoTk;
        private DevExpress.XtraEditors.SimpleButton btn_AddUser;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtPASS1;
        private System.Windows.Forms.TextBox txtPASS;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit txtUSER;
    }
}
