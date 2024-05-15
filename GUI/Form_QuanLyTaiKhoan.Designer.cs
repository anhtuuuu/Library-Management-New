namespace GUI
{
    partial class Form_QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyTaiKhoan));
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.chk_TrangThai = new System.Windows.Forms.CheckBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.lbl_TenTK = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_MaTK = new System.Windows.Forms.TextBox();
            this.lbl_MaTK = new System.Windows.Forms.Label();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_ThuVienDataSet = new GUI.QL_ThuVienDataSet();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.taiKhoanTableAdapter = new GUI.QL_ThuVienDataSetTableAdapters.TaiKhoanTableAdapter();
            this.grp_ThongTIn = new System.Windows.Forms.GroupBox();
            this.grp_DuLieu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet)).BeginInit();
            this.grp_ThongTIn.SuspendLayout();
            this.grp_DuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Tim
            // 
            this.lbl_Tim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Tim.Location = new System.Drawing.Point(51, 547);
            this.lbl_Tim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(82, 18);
            this.lbl_Tim.TabIndex = 135;
            this.lbl_Tim.Text = "Tìm kiếm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiem.Location = new System.Drawing.Point(146, 543);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_TimKiem.MaximumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.MinimumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.TabIndex = 134;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CapNhat.BackgroundImage = global::GUI.Properties.Resources.bg;
            this.btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CapNhat.Location = new System.Drawing.Point(353, 565);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(204, 70);
            this.btn_CapNhat.TabIndex = 133;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(33, 478);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(74, 17);
            this.lbl_TrangThai.TabIndex = 132;
            this.lbl_TrangThai.Text = "Trạng thái";
            // 
            // chk_TrangThai
            // 
            this.chk_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_TrangThai.AutoSize = true;
            this.chk_TrangThai.Checked = true;
            this.chk_TrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_TrangThai.Enabled = false;
            this.chk_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_TrangThai.Location = new System.Drawing.Point(119, 478);
            this.chk_TrangThai.Name = "chk_TrangThai";
            this.chk_TrangThai.Size = new System.Drawing.Size(99, 22);
            this.chk_TrangThai.TabIndex = 131;
            this.chk_TrangThai.Text = "Hoạt động";
            this.chk_TrangThai.UseVisualStyleBackColor = true;
            this.chk_TrangThai.CheckedChanged += new System.EventHandler(this.chk_TrangThai_CheckedChanged);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(55, 408);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.ReadOnly = true;
            this.txt_MatKhau.Size = new System.Drawing.Size(170, 24);
            this.txt_MatKhau.TabIndex = 130;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(27, 377);
            this.lbl_MatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(71, 17);
            this.lbl_MatKhau.TabIndex = 129;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTK.Location = new System.Drawing.Point(55, 329);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.ReadOnly = true;
            this.txt_TenTK.Size = new System.Drawing.Size(170, 24);
            this.txt_TenTK.TabIndex = 128;
            // 
            // lbl_TenTK
            // 
            this.lbl_TenTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenTK.AutoSize = true;
            this.lbl_TenTK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTK.Location = new System.Drawing.Point(27, 302);
            this.lbl_TenTK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TenTK.Name = "lbl_TenTK";
            this.lbl_TenTK.Size = new System.Drawing.Size(98, 17);
            this.lbl_TenTK.TabIndex = 127;
            this.lbl_TenTK.Text = "Tên tài khoản";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(55, 260);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(170, 24);
            this.txt_Email.TabIndex = 126;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(27, 238);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 17);
            this.lbl_Email.TabIndex = 125;
            this.lbl_Email.Text = "Email";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(55, 190);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(170, 24);
            this.txt_SDT.TabIndex = 124;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(27, 162);
            this.lbl_SDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(92, 17);
            this.lbl_SDT.TabIndex = 123;
            this.lbl_SDT.Text = "Số điện thoại";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(55, 122);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.Size = new System.Drawing.Size(170, 24);
            this.txt_HoTen.TabIndex = 122;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(27, 100);
            this.lbl_HoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(53, 17);
            this.lbl_HoTen.TabIndex = 121;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // txt_MaTK
            // 
            this.txt_MaTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTK.Location = new System.Drawing.Point(55, 65);
            this.txt_MaTK.Name = "txt_MaTK";
            this.txt_MaTK.ReadOnly = true;
            this.txt_MaTK.Size = new System.Drawing.Size(170, 24);
            this.txt_MaTK.TabIndex = 120;
            // 
            // lbl_MaTK
            // 
            this.lbl_MaTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaTK.AutoSize = true;
            this.lbl_MaTK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTK.Location = new System.Drawing.Point(18, 43);
            this.lbl_MaTK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaTK.Name = "lbl_MaTK";
            this.lbl_MaTK.Size = new System.Drawing.Size(94, 17);
            this.lbl_MaTK.TabIndex = 119;
            this.lbl_MaTK.Text = "Mã tài khoản";
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
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_Thoat.Location = new System.Drawing.Point(1165, 2);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 74);
            this.btn_Thoat.TabIndex = 117;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sua.ImageIndex = 5;
            this.btn_Sua.ImageList = this.imgHinhAnh;
            this.btn_Sua.Location = new System.Drawing.Point(815, 135);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 74);
            this.btn_Sua.TabIndex = 115;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dgv_TaiKhoan
            // 
            this.dgv_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_TaiKhoan.AutoGenerateColumns = false;
            this.dgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgv_TaiKhoan.DataSource = this.taiKhoanBindingSource;
            this.dgv_TaiKhoan.Location = new System.Drawing.Point(6, 7);
            this.dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            this.dgv_TaiKhoan.ReadOnly = true;
            this.dgv_TaiKhoan.RowHeadersWidth = 51;
            this.dgv_TaiKhoan.RowTemplate.Height = 24;
            this.dgv_TaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TaiKhoan.Size = new System.Drawing.Size(747, 411);
            this.dgv_TaiKhoan.TabIndex = 114;
            this.dgv_TaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TaiKhoan_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaTK";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaTK";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sdt";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sdt";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn5.HeaderText = "Username";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn6.HeaderText = "Password";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn7.HeaderText = "TrangThai";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.qL_ThuVienDataSet;
            // 
            // qL_ThuVienDataSet
            // 
            this.qL_ThuVienDataSet.DataSetName = "QL_ThuVienDataSet";
            this.qL_ThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LamMoi.BackColor = System.Drawing.Color.White;
            this.btn_LamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.BackgroundImage")));
            this.btn_LamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamMoi.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LamMoi.ImageIndex = 1;
            this.btn_LamMoi.ImageList = this.imgHinhAnh;
            this.btn_LamMoi.Location = new System.Drawing.Point(815, 229);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 74);
            this.btn_LamMoi.TabIndex = 136;
            this.btn_LamMoi.Text = "LÀM MỚI";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // grp_ThongTIn
            // 
            this.grp_ThongTIn.Controls.Add(this.txt_MaTK);
            this.grp_ThongTIn.Controls.Add(this.lbl_MaTK);
            this.grp_ThongTIn.Controls.Add(this.lbl_HoTen);
            this.grp_ThongTIn.Controls.Add(this.txt_HoTen);
            this.grp_ThongTIn.Controls.Add(this.lbl_SDT);
            this.grp_ThongTIn.Controls.Add(this.txt_SDT);
            this.grp_ThongTIn.Controls.Add(this.lbl_TrangThai);
            this.grp_ThongTIn.Controls.Add(this.lbl_Email);
            this.grp_ThongTIn.Controls.Add(this.chk_TrangThai);
            this.grp_ThongTIn.Controls.Add(this.txt_Email);
            this.grp_ThongTIn.Controls.Add(this.txt_MatKhau);
            this.grp_ThongTIn.Controls.Add(this.lbl_TenTK);
            this.grp_ThongTIn.Controls.Add(this.lbl_MatKhau);
            this.grp_ThongTIn.Controls.Add(this.txt_TenTK);
            this.grp_ThongTIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTIn.Location = new System.Drawing.Point(931, 87);
            this.grp_ThongTIn.Name = "grp_ThongTIn";
            this.grp_ThongTIn.Size = new System.Drawing.Size(330, 567);
            this.grp_ThongTIn.TabIndex = 138;
            this.grp_ThongTIn.TabStop = false;
            this.grp_ThongTIn.Text = "Thông tin";
            // 
            // grp_DuLieu
            // 
            this.grp_DuLieu.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.grp_DuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_DuLieu.Controls.Add(this.dgv_TaiKhoan);
            this.grp_DuLieu.Location = new System.Drawing.Point(48, 113);
            this.grp_DuLieu.Name = "grp_DuLieu";
            this.grp_DuLieu.Size = new System.Drawing.Size(759, 424);
            this.grp_DuLieu.TabIndex = 139;
            this.grp_DuLieu.TabStop = false;
            // 
            // Form_QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::GUI.Properties.Resources.pixil_frame_0__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.grp_DuLieu);
            this.Controls.Add(this.grp_ThongTIn);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.lbl_Tim);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.DoubleBuffered = true;
            this.Name = "Form_QuanLyTaiKhoan";
            this.Text = "Form_QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.Form_QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet)).EndInit();
            this.grp_ThongTIn.ResumeLayout(false);
            this.grp_ThongTIn.PerformLayout();
            this.grp_DuLieu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.CheckBox chk_TrangThai;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label lbl_TenTK;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_MaTK;
        private System.Windows.Forms.Label lbl_MaTK;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dgv_TaiKhoan;
        //private QL_ThuVienDataSet qL_ThuVienDataSet;
        //private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        //private QL_ThuVienDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_LamMoi;
        private QL_ThuVienDataSet qL_ThuVienDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QL_ThuVienDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox grp_ThongTIn;
        private System.Windows.Forms.GroupBox grp_DuLieu;
    }
}