namespace GUI
{
    partial class Form_QuenMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.btn_XacNhanOTP = new System.Windows.Forms.Button();
            this.txt_MaXacNhan = new System.Windows.Forms.TextBox();
            this.txt_EmailDaDangKy = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.link_DangNhap = new System.Windows.Forms.LinkLabel();
            this.btn_GuiOTP = new System.Windows.Forms.Button();
            this.timer_OTP = new System.Windows.Forms.Timer(this.components);
            this.lbl_Counter = new System.Windows.Forms.Label();
            this.timer_Counter = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_QuenMatKhau = new System.Windows.Forms.GroupBox();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_QuenMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_XacNhanOTP
            // 
            this.btn_XacNhanOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XacNhanOTP.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.btn_XacNhanOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XacNhanOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhanOTP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_XacNhanOTP.Location = new System.Drawing.Point(134, 510);
            this.btn_XacNhanOTP.MinimumSize = new System.Drawing.Size(168, 55);
            this.btn_XacNhanOTP.Name = "btn_XacNhanOTP";
            this.btn_XacNhanOTP.Size = new System.Drawing.Size(246, 55);
            this.btn_XacNhanOTP.TabIndex = 38;
            this.btn_XacNhanOTP.Text = "Xác nhận OTP";
            this.btn_XacNhanOTP.UseVisualStyleBackColor = true;
            this.btn_XacNhanOTP.Click += new System.EventHandler(this.btn_XacNhanOTP_Click);
            // 
            // txt_MaXacNhan
            // 
            this.txt_MaXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaXacNhan.Location = new System.Drawing.Point(134, 399);
            this.txt_MaXacNhan.MinimumSize = new System.Drawing.Size(129, 41);
            this.txt_MaXacNhan.Multiline = true;
            this.txt_MaXacNhan.Name = "txt_MaXacNhan";
            this.txt_MaXacNhan.Size = new System.Drawing.Size(129, 41);
            this.txt_MaXacNhan.TabIndex = 37;
            // 
            // txt_EmailDaDangKy
            // 
            this.txt_EmailDaDangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EmailDaDangKy.Location = new System.Drawing.Point(134, 311);
            this.txt_EmailDaDangKy.MinimumSize = new System.Drawing.Size(246, 41);
            this.txt_EmailDaDangKy.Multiline = true;
            this.txt_EmailDaDangKy.Name = "txt_EmailDaDangKy";
            this.txt_EmailDaDangKy.Size = new System.Drawing.Size(246, 41);
            this.txt_EmailDaDangKy.TabIndex = 36;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(130, 376);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(109, 20);
            this.lbl_MatKhau.TabIndex = 35;
            this.lbl_MatKhau.Text = "Mã xác nhận:";
            // 
            // link_DangNhap
            // 
            this.link_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_DangNhap.AutoSize = true;
            this.link_DangNhap.Location = new System.Drawing.Point(308, 454);
            this.link_DangNhap.Name = "link_DangNhap";
            this.link_DangNhap.Size = new System.Drawing.Size(72, 16);
            this.link_DangNhap.TabIndex = 33;
            this.link_DangNhap.TabStop = true;
            this.link_DangNhap.Text = "Đăng nhập";
            this.link_DangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DangNhap_LinkClicked);
            // 
            // btn_GuiOTP
            // 
            this.btn_GuiOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuiOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuiOTP.Location = new System.Drawing.Point(269, 399);
            this.btn_GuiOTP.MinimumSize = new System.Drawing.Size(81, 41);
            this.btn_GuiOTP.Name = "btn_GuiOTP";
            this.btn_GuiOTP.Size = new System.Drawing.Size(111, 41);
            this.btn_GuiOTP.TabIndex = 32;
            this.btn_GuiOTP.Text = "Gửi OTP";
            this.btn_GuiOTP.UseVisualStyleBackColor = true;
            this.btn_GuiOTP.Click += new System.EventHandler(this.btn_GuiOTP_Click);
            // 
            // timer_OTP
            // 
            this.timer_OTP.Interval = 60000;
            this.timer_OTP.Tick += new System.EventHandler(this.timer_OTP_Tick);
            // 
            // lbl_Counter
            // 
            this.lbl_Counter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Counter.AutoSize = true;
            this.lbl_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Counter.Location = new System.Drawing.Point(395, 336);
            this.lbl_Counter.Name = "lbl_Counter";
            this.lbl_Counter.Size = new System.Drawing.Size(0, 20);
            this.lbl_Counter.TabIndex = 39;
            // 
            // timer_Counter
            // 
            this.timer_Counter.Interval = 1000;
            this.timer_Counter.Tick += new System.EventHandler(this.timer_Counter_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GUI.Properties.Resources._173_1731325_person_icon_png_transparent_png;
            this.pictureBox1.Location = new System.Drawing.Point(148, 10);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(197, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // grp_QuenMatKhau
            // 
            this.grp_QuenMatKhau.Controls.Add(this.lbl_TieuDe);
            this.grp_QuenMatKhau.Controls.Add(this.pictureBox1);
            this.grp_QuenMatKhau.Controls.Add(this.btn_XacNhanOTP);
            this.grp_QuenMatKhau.Controls.Add(this.lbl_Counter);
            this.grp_QuenMatKhau.Controls.Add(this.txt_MaXacNhan);
            this.grp_QuenMatKhau.Controls.Add(this.btn_GuiOTP);
            this.grp_QuenMatKhau.Controls.Add(this.txt_EmailDaDangKy);
            this.grp_QuenMatKhau.Controls.Add(this.link_DangNhap);
            this.grp_QuenMatKhau.Controls.Add(this.lbl_MatKhau);
            this.grp_QuenMatKhau.Controls.Add(this.lbl_TaiKhoan);
            this.grp_QuenMatKhau.Location = new System.Drawing.Point(378, 12);
            this.grp_QuenMatKhau.Name = "grp_QuenMatKhau";
            this.grp_QuenMatKhau.Size = new System.Drawing.Size(492, 629);
            this.grp_QuenMatKhau.TabIndex = 40;
            this.grp_QuenMatKhau.TabStop = false;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(142, 205);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(220, 32);
            this.lbl_TieuDe.TabIndex = 175;
            this.lbl_TieuDe.Text = "Quên mật khẩu";
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(130, 288);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(141, 20);
            this.lbl_TaiKhoan.TabIndex = 34;
            this.lbl_TaiKhoan.Text = "Email đã đăng ký:";
            // 
            // Form_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.grp_QuenMatKhau);
            this.DoubleBuffered = true;
            this.Name = "Form_QuenMatKhau";
            this.Text = "Form_QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_QuenMatKhau.ResumeLayout(false);
            this.grp_QuenMatKhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XacNhanOTP;
        private System.Windows.Forms.TextBox txt_MaXacNhan;
        private System.Windows.Forms.TextBox txt_EmailDaDangKy;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.LinkLabel link_DangNhap;
        private System.Windows.Forms.Button btn_GuiOTP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_OTP;
        private System.Windows.Forms.Label lbl_Counter;
        private System.Windows.Forms.Timer timer_Counter;
        private System.Windows.Forms.GroupBox grp_QuenMatKhau;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private System.Windows.Forms.Label lbl_TieuDe;
    }
}