namespace GUI
{
    partial class Form_DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.link_DangKy = new System.Windows.Forms.LinkLabel();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.link_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.chk_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.grp_DangNhap = new System.Windows.Forms.GroupBox();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.grp_DangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bạn chưa có tài khoản?";
            // 
            // link_DangKy
            // 
            this.link_DangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_DangKy.AutoSize = true;
            this.link_DangKy.Location = new System.Drawing.Point(301, 365);
            this.link_DangKy.Name = "link_DangKy";
            this.link_DangKy.Size = new System.Drawing.Size(56, 16);
            this.link_DangKy.TabIndex = 31;
            this.link_DangKy.TabStop = true;
            this.link_DangKy.Text = "Đăng ký";
            this.link_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DangKy_LinkClicked);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(104, 270);
            this.txt_MatKhau.MinimumSize = new System.Drawing.Size(246, 41);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(299, 41);
            this.txt_MatKhau.TabIndex = 30;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(104, 208);
            this.txt_TaiKhoan.MinimumSize = new System.Drawing.Size(246, 41);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(299, 41);
            this.txt_TaiKhoan.TabIndex = 29;
            // 
            // link_QuenMatKhau
            // 
            this.link_QuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_QuenMatKhau.AutoSize = true;
            this.link_QuenMatKhau.Location = new System.Drawing.Point(286, 331);
            this.link_QuenMatKhau.Name = "link_QuenMatKhau";
            this.link_QuenMatKhau.Size = new System.Drawing.Size(96, 16);
            this.link_QuenMatKhau.TabIndex = 26;
            this.link_QuenMatKhau.TabStop = true;
            this.link_QuenMatKhau.Text = "Quên mật khẩu";
            this.link_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_QuenMatKhau_LinkClicked);
            // 
            // chk_HienMatKhau
            // 
            this.chk_HienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_HienMatKhau.AutoSize = true;
            this.chk_HienMatKhau.Location = new System.Drawing.Point(118, 331);
            this.chk_HienMatKhau.Name = "chk_HienMatKhau";
            this.chk_HienMatKhau.Size = new System.Drawing.Size(130, 20);
            this.chk_HienMatKhau.TabIndex = 25;
            this.chk_HienMatKhau.Text = "Hiển thị mật khẩu";
            this.chk_HienMatKhau.UseVisualStyleBackColor = true;
            this.chk_HienMatKhau.CheckedChanged += new System.EventHandler(this.chk_HienMatKhau_CheckedChanged);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.btn_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangNhap.Location = new System.Drawing.Point(104, 403);
            this.btn_DangNhap.MinimumSize = new System.Drawing.Size(140, 50);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(299, 50);
            this.btn_DangNhap.TabIndex = 24;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // grp_DangNhap
            // 
            this.grp_DangNhap.BackColor = System.Drawing.Color.White;
            this.grp_DangNhap.Controls.Add(this.lbl_TieuDe);
            this.grp_DangNhap.Controls.Add(this.lbl_MatKhau);
            this.grp_DangNhap.Controls.Add(this.lbl_TaiKhoan);
            this.grp_DangNhap.Controls.Add(this.txt_TaiKhoan);
            this.grp_DangNhap.Controls.Add(this.label1);
            this.grp_DangNhap.Controls.Add(this.btn_DangNhap);
            this.grp_DangNhap.Controls.Add(this.link_DangKy);
            this.grp_DangNhap.Controls.Add(this.chk_HienMatKhau);
            this.grp_DangNhap.Controls.Add(this.txt_MatKhau);
            this.grp_DangNhap.Controls.Add(this.link_QuenMatKhau);
            this.grp_DangNhap.Location = new System.Drawing.Point(373, 12);
            this.grp_DangNhap.Name = "grp_DangNhap";
            this.grp_DangNhap.Size = new System.Drawing.Size(492, 629);
            this.grp_DangNhap.TabIndex = 33;
            this.grp_DangNhap.TabStop = false;
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(111, 198);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(67, 16);
            this.lbl_TaiKhoan.TabIndex = 33;
            this.lbl_TaiKhoan.Text = "Tài khoản";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(115, 261);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(61, 16);
            this.lbl_MatKhau.TabIndex = 34;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(162, 94);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(162, 32);
            this.lbl_TieuDe.TabIndex = 174;
            this.lbl_TieuDe.Text = "Đăng nhập";
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.grp_DangNhap);
            this.DoubleBuffered = true;
            this.Name = "Form_DangNhap";
            this.Text = "Form_DangNhap";
            this.grp_DangNhap.ResumeLayout(false);
            this.grp_DangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_DangKy;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.LinkLabel link_QuenMatKhau;
        private System.Windows.Forms.CheckBox chk_HienMatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.GroupBox grp_DangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private System.Windows.Forms.Label lbl_TieuDe;
    }
}