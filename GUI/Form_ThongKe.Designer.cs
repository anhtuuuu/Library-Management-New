namespace GUI
{
    partial class Form_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThongKe));
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.cbo_Quy = new System.Windows.Forms.ComboBox();
            this.btn_ThanhVien = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SLSachDaChoThue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_DoanhSo = new System.Windows.Forms.Label();
            this.lbl_ThanhVien = new System.Windows.Forms.Label();
            this.lbl_SachHienCo = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_DoanhSo = new System.Windows.Forms.Button();
            this.btn_SachHienCo = new System.Windows.Forms.Button();
            this.btn_SachDaChoThue = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(184, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lọc theo năm:";
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.Location = new System.Drawing.Point(339, 43);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(121, 24);
            this.cbo_Nam.TabIndex = 5;
            this.cbo_Nam.SelectedIndexChanged += new System.EventHandler(this.cbo_Nam_SelectedIndexChanged);
            // 
            // cbo_Quy
            // 
            this.cbo_Quy.Enabled = false;
            this.cbo_Quy.FormattingEnabled = true;
            this.cbo_Quy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cbo_Quy.Location = new System.Drawing.Point(476, 43);
            this.cbo_Quy.Name = "cbo_Quy";
            this.cbo_Quy.Size = new System.Drawing.Size(121, 24);
            this.cbo_Quy.TabIndex = 6;
            this.cbo_Quy.SelectedIndexChanged += new System.EventHandler(this.cbo_Quy_SelectedIndexChanged);
            // 
            // btn_ThanhVien
            // 
            this.btn_ThanhVien.Location = new System.Drawing.Point(339, 384);
            this.btn_ThanhVien.Name = "btn_ThanhVien";
            this.btn_ThanhVien.Size = new System.Drawing.Size(258, 220);
            this.btn_ThanhVien.TabIndex = 9;
            this.btn_ThanhVien.UseVisualStyleBackColor = true;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThongKe.Location = new System.Drawing.Point(540, 273);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(171, 144);
            this.btn_ThongKe.TabIndex = 15;
            this.btn_ThongKe.Text = "THỐNG KÊ";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(344, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sách đã cho thuê";
            // 
            // lbl_SLSachDaChoThue
            // 
            this.lbl_SLSachDaChoThue.AutoSize = true;
            this.lbl_SLSachDaChoThue.BackColor = System.Drawing.Color.White;
            this.lbl_SLSachDaChoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SLSachDaChoThue.Location = new System.Drawing.Point(360, 186);
            this.lbl_SLSachDaChoThue.Name = "lbl_SLSachDaChoThue";
            this.lbl_SLSachDaChoThue.Size = new System.Drawing.Size(36, 38);
            this.lbl_SLSachDaChoThue.TabIndex = 18;
            this.lbl_SLSachDaChoThue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(761, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sách hiện có";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(344, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thành viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(126)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(751, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Doanh Số";
            // 
            // lbl_DoanhSo
            // 
            this.lbl_DoanhSo.AutoSize = true;
            this.lbl_DoanhSo.BackColor = System.Drawing.Color.White;
            this.lbl_DoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoanhSo.Location = new System.Drawing.Point(674, 468);
            this.lbl_DoanhSo.Name = "lbl_DoanhSo";
            this.lbl_DoanhSo.Size = new System.Drawing.Size(36, 38);
            this.lbl_DoanhSo.TabIndex = 23;
            this.lbl_DoanhSo.Text = "0";
            this.lbl_DoanhSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ThanhVien
            // 
            this.lbl_ThanhVien.AutoSize = true;
            this.lbl_ThanhVien.BackColor = System.Drawing.Color.White;
            this.lbl_ThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhVien.Location = new System.Drawing.Point(360, 468);
            this.lbl_ThanhVien.Name = "lbl_ThanhVien";
            this.lbl_ThanhVien.Size = new System.Drawing.Size(36, 38);
            this.lbl_ThanhVien.TabIndex = 24;
            this.lbl_ThanhVien.Text = "0";
            this.lbl_ThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SachHienCo
            // 
            this.lbl_SachHienCo.AutoSize = true;
            this.lbl_SachHienCo.BackColor = System.Drawing.Color.White;
            this.lbl_SachHienCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SachHienCo.Location = new System.Drawing.Point(674, 186);
            this.lbl_SachHienCo.Name = "lbl_SachHienCo";
            this.lbl_SachHienCo.Size = new System.Drawing.Size(36, 38);
            this.lbl_SachHienCo.TabIndex = 25;
            this.lbl_SachHienCo.Text = "0";
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::GUI.Properties.Resources.R__1_;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(509, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 94);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::GUI.Properties.Resources.OIP__1_;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(642, 356);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 94);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::GUI.Properties.Resources._34_asana_color_gradient;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(634, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 93);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::GUI.Properties.Resources.bg;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(509, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 93);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_DoanhSo
            // 
            this.btn_DoanhSo.BackgroundImage = global::GUI.Properties.Resources.doanhthu;
            this.btn_DoanhSo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DoanhSo.Location = new System.Drawing.Point(655, 384);
            this.btn_DoanhSo.Name = "btn_DoanhSo";
            this.btn_DoanhSo.Size = new System.Drawing.Size(258, 220);
            this.btn_DoanhSo.TabIndex = 10;
            this.btn_DoanhSo.UseVisualStyleBackColor = true;
            // 
            // btn_SachHienCo
            // 
            this.btn_SachHienCo.BackgroundImage = global::GUI.Properties.Resources.cach_ve_quyen_sach_13;
            this.btn_SachHienCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SachHienCo.Location = new System.Drawing.Point(655, 105);
            this.btn_SachHienCo.Name = "btn_SachHienCo";
            this.btn_SachHienCo.Size = new System.Drawing.Size(258, 220);
            this.btn_SachHienCo.TabIndex = 8;
            this.btn_SachHienCo.UseVisualStyleBackColor = true;
            // 
            // btn_SachDaChoThue
            // 
            this.btn_SachDaChoThue.BackgroundImage = global::GUI.Properties.Resources.Screenshot_2024_05_09_142141;
            this.btn_SachDaChoThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SachDaChoThue.Location = new System.Drawing.Point(339, 102);
            this.btn_SachDaChoThue.Name = "btn_SachDaChoThue";
            this.btn_SachDaChoThue.Size = new System.Drawing.Size(258, 220);
            this.btn_SachDaChoThue.TabIndex = 7;
            this.btn_SachDaChoThue.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Thoat.ImageIndex = 3;
            this.btn_Thoat.ImageList = this.imgHinhAnh;
            this.btn_Thoat.Location = new System.Drawing.Point(1166, 12);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 74);
            this.btn_Thoat.TabIndex = 100;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // imgHinhAnh
            // 
            this.imgHinhAnh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHinhAnh.ImageStream")));
            this.imgHinhAnh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHinhAnh.Images.SetKeyName(0, "addimage.png");
            this.imgHinhAnh.Images.SetKeyName(1, "refresh.png");
            this.imgHinhAnh.Images.SetKeyName(2, "delete-181.png");
            this.imgHinhAnh.Images.SetKeyName(3, "Exit.png");
            this.imgHinhAnh.Images.SetKeyName(4, "back.jpg");
            this.imgHinhAnh.Images.SetKeyName(5, "sua1.png");
            this.imgHinhAnh.Images.SetKeyName(6, "search.png");
            this.imgHinhAnh.Images.SetKeyName(7, "save.png");
            this.imgHinhAnh.Images.SetKeyName(8, "DocGia.png");
            this.imgHinhAnh.Images.SetKeyName(9, "OIP.jpg");
            // 
            // Form_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_SachHienCo);
            this.Controls.Add(this.lbl_ThanhVien);
            this.Controls.Add(this.lbl_DoanhSo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_SLSachDaChoThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_DoanhSo);
            this.Controls.Add(this.btn_ThanhVien);
            this.Controls.Add(this.btn_SachHienCo);
            this.Controls.Add(this.btn_SachDaChoThue);
            this.Controls.Add(this.cbo_Quy);
            this.Controls.Add(this.cbo_Nam);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(1291, 713);
            this.MinimumSize = new System.Drawing.Size(1291, 713);
            this.Name = "Form_ThongKe";
            this.Text = "Form_ThongKe";
            this.Load += new System.EventHandler(this.Form_ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.ComboBox cbo_Quy;
        private System.Windows.Forms.Button btn_SachDaChoThue;
        private System.Windows.Forms.Button btn_SachHienCo;
        private System.Windows.Forms.Button btn_ThanhVien;
        private System.Windows.Forms.Button btn_DoanhSo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SLSachDaChoThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_DoanhSo;
        private System.Windows.Forms.Label lbl_ThanhVien;
        private System.Windows.Forms.Label lbl_SachHienCo;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ImageList imgHinhAnh;
    }
}