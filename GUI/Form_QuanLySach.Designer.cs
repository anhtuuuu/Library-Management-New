namespace GUI
{
    partial class Form_QuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLySach));
            this.pic_HinhAnh = new System.Windows.Forms.PictureBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_DonViTinh = new System.Windows.Forms.ComboBox();
            this.cbo_MaNCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GiaChoThue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_XuatXu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.cbo_MaLoaiSach = new System.Windows.Forms.ComboBox();
            this.lbl_MaLoaiSach = new System.Windows.Forms.Label();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.lbl_MaSanPham = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.btn_ChonAnh = new System.Windows.Forms.Button();
            this.txt_ChonAnh = new System.Windows.Forms.TextBox();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.lbl_TacGia = new System.Windows.Forms.Label();
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_ThuVienDataSet7 = new GUI.QL_ThuVienDataSet7();
            this.sachTableAdapter2 = new GUI.QL_ThuVienDataSet7TableAdapters.SachTableAdapter();
            this.imgSach = new System.Windows.Forms.ImageList(this.components);
            this.grp_ThongTin = new System.Windows.Forms.GroupBox();
            this.grp_DanhSach = new System.Windows.Forms.GroupBox();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet7)).BeginInit();
            this.grp_ThongTin.SuspendLayout();
            this.grp_DanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_HinhAnh
            // 
            this.pic_HinhAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_HinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_HinhAnh.Location = new System.Drawing.Point(75, 26);
            this.pic_HinhAnh.Name = "pic_HinhAnh";
            this.pic_HinhAnh.Size = new System.Drawing.Size(176, 158);
            this.pic_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_HinhAnh.TabIndex = 126;
            this.pic_HinhAnh.TabStop = false;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoLuong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(118, 496);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.ReadOnly = true;
            this.txt_SoLuong.Size = new System.Drawing.Size(85, 25);
            this.txt_SoLuong.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 496);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 122;
            this.label5.Text = "Số Lượng";
            // 
            // cbo_DonViTinh
            // 
            this.cbo_DonViTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_DonViTinh.Enabled = false;
            this.cbo_DonViTinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_DonViTinh.FormattingEnabled = true;
            this.cbo_DonViTinh.Items.AddRange(new object[] {
            "Cuốn"});
            this.cbo_DonViTinh.Location = new System.Drawing.Point(118, 462);
            this.cbo_DonViTinh.Name = "cbo_DonViTinh";
            this.cbo_DonViTinh.Size = new System.Drawing.Size(85, 25);
            this.cbo_DonViTinh.TabIndex = 121;
            // 
            // cbo_MaNCC
            // 
            this.cbo_MaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaNCC.Enabled = false;
            this.cbo_MaNCC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaNCC.FormattingEnabled = true;
            this.cbo_MaNCC.Location = new System.Drawing.Point(36, 296);
            this.cbo_MaNCC.Name = "cbo_MaNCC";
            this.cbo_MaNCC.Size = new System.Drawing.Size(105, 25);
            this.cbo_MaNCC.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 119;
            this.label6.Text = "Mã Nhà Cung Cấp:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 118;
            this.label4.Text = "Đơn Vị Tính:";
            // 
            // txt_GiaChoThue
            // 
            this.txt_GiaChoThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GiaChoThue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaChoThue.Location = new System.Drawing.Point(122, 396);
            this.txt_GiaChoThue.Name = "txt_GiaChoThue";
            this.txt_GiaChoThue.ReadOnly = true;
            this.txt_GiaChoThue.Size = new System.Drawing.Size(170, 25);
            this.txt_GiaChoThue.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Giá Cho Thuê";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GiaNhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaNhap.Location = new System.Drawing.Point(122, 363);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.ReadOnly = true;
            this.txt_GiaNhap.Size = new System.Drawing.Size(170, 25);
            this.txt_GiaNhap.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "Giá Nhập";
            // 
            // txt_XuatXu
            // 
            this.txt_XuatXu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_XuatXu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XuatXu.Location = new System.Drawing.Point(201, 297);
            this.txt_XuatXu.Name = "txt_XuatXu";
            this.txt_XuatXu.ReadOnly = true;
            this.txt_XuatXu.Size = new System.Drawing.Size(105, 25);
            this.txt_XuatXu.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Xuất Xứ";
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSach.Location = new System.Drawing.Point(122, 330);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.ReadOnly = true;
            this.txt_TenSach.Size = new System.Drawing.Size(170, 25);
            this.txt_TenSach.TabIndex = 111;
            // 
            // cbo_MaLoaiSach
            // 
            this.cbo_MaLoaiSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaLoaiSach.Enabled = false;
            this.cbo_MaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaLoaiSach.FormattingEnabled = true;
            this.cbo_MaLoaiSach.Location = new System.Drawing.Point(201, 244);
            this.cbo_MaLoaiSach.Name = "cbo_MaLoaiSach";
            this.cbo_MaLoaiSach.Size = new System.Drawing.Size(105, 25);
            this.cbo_MaLoaiSach.TabIndex = 110;
            // 
            // lbl_MaLoaiSach
            // 
            this.lbl_MaLoaiSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaLoaiSach.AutoSize = true;
            this.lbl_MaLoaiSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLoaiSach.Location = new System.Drawing.Point(168, 221);
            this.lbl_MaLoaiSach.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaLoaiSach.Name = "lbl_MaLoaiSach";
            this.lbl_MaLoaiSach.Size = new System.Drawing.Size(97, 17);
            this.lbl_MaLoaiSach.TabIndex = 109;
            this.lbl_MaLoaiSach.Text = "Mã Loại Sách";
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
            // lbl_Tim
            // 
            this.lbl_Tim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Tim.Location = new System.Drawing.Point(48, 550);
            this.lbl_Tim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(82, 18);
            this.lbl_Tim.TabIndex = 104;
            this.lbl_Tim.Text = "Tìm kiếm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiem.Location = new System.Drawing.Point(140, 549);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_TimKiem.MaximumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.MinimumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.TabIndex = 103;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSach.Location = new System.Drawing.Point(30, 333);
            this.lbl_TenSach.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(68, 17);
            this.lbl_TenSach.TabIndex = 102;
            this.lbl_TenSach.Text = "Tên Sách";
            // 
            // lbl_MaSanPham
            // 
            this.lbl_MaSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaSanPham.AutoSize = true;
            this.lbl_MaSanPham.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaSanPham.Location = new System.Drawing.Point(14, 222);
            this.lbl_MaSanPham.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaSanPham.Name = "lbl_MaSanPham";
            this.lbl_MaSanPham.Size = new System.Drawing.Size(64, 17);
            this.lbl_MaSanPham.TabIndex = 101;
            this.lbl_MaSanPham.Text = "Mã Sách";
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
            this.btn_Thoat.Location = new System.Drawing.Point(1165, 4);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 74);
            this.btn_Thoat.TabIndex = 99;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_LamMoi.Location = new System.Drawing.Point(817, 403);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 74);
            this.btn_LamMoi.TabIndex = 98;
            this.btn_LamMoi.Text = "LÀM MỚI";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_Sua.Location = new System.Drawing.Point(817, 307);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 74);
            this.btn_Sua.TabIndex = 97;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Xoa.ImageIndex = 2;
            this.btn_Xoa.ImageList = this.imgHinhAnh;
            this.btn_Xoa.Location = new System.Drawing.Point(817, 217);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 74);
            this.btn_Xoa.TabIndex = 96;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Them.ImageIndex = 0;
            this.btn_Them.ImageList = this.imgHinhAnh;
            this.btn_Them.Location = new System.Drawing.Point(817, 137);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 74);
            this.btn_Them.TabIndex = 95;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
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
            this.btn_CapNhat.Location = new System.Drawing.Point(436, 560);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(204, 70);
            this.btn_CapNhat.TabIndex = 136;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(25, 529);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(79, 17);
            this.lbl_TrangThai.TabIndex = 138;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSach.Location = new System.Drawing.Point(44, 244);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.ReadOnly = true;
            this.txt_MaSach.Size = new System.Drawing.Size(105, 25);
            this.txt_MaSach.TabIndex = 141;
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ChonAnh.Enabled = false;
            this.btn_ChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonAnh.Location = new System.Drawing.Point(201, 196);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(79, 23);
            this.btn_ChonAnh.TabIndex = 142;
            this.btn_ChonAnh.Text = "Chọn Ảnh";
            this.btn_ChonAnh.UseVisualStyleBackColor = true;
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // txt_ChonAnh
            // 
            this.txt_ChonAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ChonAnh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChonAnh.Location = new System.Drawing.Point(60, 196);
            this.txt_ChonAnh.Name = "txt_ChonAnh";
            this.txt_ChonAnh.ReadOnly = true;
            this.txt_ChonAnh.Size = new System.Drawing.Size(135, 25);
            this.txt_ChonAnh.TabIndex = 143;
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_TrangThai.Enabled = false;
            this.cbo_TrangThai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Còn Hàng",
            "Hết Hàng"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(118, 529);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(105, 25);
            this.cbo_TrangThai.TabIndex = 144;
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TacGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TacGia.Location = new System.Drawing.Point(118, 429);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.ReadOnly = true;
            this.txt_TacGia.Size = new System.Drawing.Size(170, 25);
            this.txt_TacGia.TabIndex = 146;
            // 
            // lbl_TacGia
            // 
            this.lbl_TacGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TacGia.AutoSize = true;
            this.lbl_TacGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TacGia.Location = new System.Drawing.Point(36, 432);
            this.lbl_TacGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TacGia.Name = "lbl_TacGia";
            this.lbl_TacGia.Size = new System.Drawing.Size(58, 17);
            this.lbl_TacGia.TabIndex = 145;
            this.lbl_TacGia.Text = "Tác Giả";
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Sach.AutoGenerateColumns = false;
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewImageColumn1});
            this.dgv_Sach.DataSource = this.sachBindingSource2;
            this.dgv_Sach.Location = new System.Drawing.Point(6, 5);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.ReadOnly = true;
            this.dgv_Sach.RowHeadersWidth = 51;
            this.dgv_Sach.RowTemplate.Height = 24;
            this.dgv_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sach.Size = new System.Drawing.Size(747, 413);
            this.dgv_Sach.TabIndex = 147;
            this.dgv_Sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSach";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaLoaiSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaLoaiSach";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn3.HeaderText = "TenSach";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "XuatXu";
            this.dataGridViewTextBoxColumn4.HeaderText = "XuatXu";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TacGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "TacGia";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GiaNhap";
            this.dataGridViewTextBoxColumn6.HeaderText = "GiaNhap";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GiaChoThue";
            this.dataGridViewTextBoxColumn7.HeaderText = "GiaChoThue";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DonViTinh";
            this.dataGridViewTextBoxColumn8.HeaderText = "DonViTinh";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MaNhaCungCap";
            this.dataGridViewTextBoxColumn9.HeaderText = "MaNhaCungCap";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn10.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn11.HeaderText = "TrangThai";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "HinhAnh";
            this.dataGridViewImageColumn1.HeaderText = "HinhAnh";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // sachBindingSource2
            // 
            this.sachBindingSource2.DataMember = "Sach";
            this.sachBindingSource2.DataSource = this.qL_ThuVienDataSet7;
            // 
            // qL_ThuVienDataSet7
            // 
            this.qL_ThuVienDataSet7.DataSetName = "QL_ThuVienDataSet7";
            this.qL_ThuVienDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachTableAdapter2
            // 
            this.sachTableAdapter2.ClearBeforeFill = true;
            // 
            // imgSach
            // 
            this.imgSach.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSach.ImageStream")));
            this.imgSach.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSach.Images.SetKeyName(0, "7 Thoi quen hieu qua.jpg");
            this.imgSach.Images.SetKeyName(1, "Nha Quan Ly 1 Phut.jpg");
            this.imgSach.Images.SetKeyName(2, "Bi Mat Tu Duy Trieu Phu.jpg");
            this.imgSach.Images.SetKeyName(3, "Dac Nhan Tam.jpg");
            this.imgSach.Images.SetKeyName(4, "Harry Potter va hon da phu thuy.jpg");
            this.imgSach.Images.SetKeyName(5, "BiAnVuTru.jpg");
            // 
            // grp_ThongTin
            // 
            this.grp_ThongTin.Controls.Add(this.pic_HinhAnh);
            this.grp_ThongTin.Controls.Add(this.btn_ChonAnh);
            this.grp_ThongTin.Controls.Add(this.txt_ChonAnh);
            this.grp_ThongTin.Controls.Add(this.cbo_TrangThai);
            this.grp_ThongTin.Controls.Add(this.lbl_TrangThai);
            this.grp_ThongTin.Controls.Add(this.txt_TacGia);
            this.grp_ThongTin.Controls.Add(this.lbl_TacGia);
            this.grp_ThongTin.Controls.Add(this.txt_MaSach);
            this.grp_ThongTin.Controls.Add(this.lbl_MaSanPham);
            this.grp_ThongTin.Controls.Add(this.txt_SoLuong);
            this.grp_ThongTin.Controls.Add(this.label5);
            this.grp_ThongTin.Controls.Add(this.lbl_MaLoaiSach);
            this.grp_ThongTin.Controls.Add(this.cbo_MaLoaiSach);
            this.grp_ThongTin.Controls.Add(this.cbo_DonViTinh);
            this.grp_ThongTin.Controls.Add(this.label4);
            this.grp_ThongTin.Controls.Add(this.label6);
            this.grp_ThongTin.Controls.Add(this.cbo_MaNCC);
            this.grp_ThongTin.Controls.Add(this.txt_XuatXu);
            this.grp_ThongTin.Controls.Add(this.label1);
            this.grp_ThongTin.Controls.Add(this.txt_GiaNhap);
            this.grp_ThongTin.Controls.Add(this.lbl_TenSach);
            this.grp_ThongTin.Controls.Add(this.txt_GiaChoThue);
            this.grp_ThongTin.Controls.Add(this.label3);
            this.grp_ThongTin.Controls.Add(this.txt_TenSach);
            this.grp_ThongTin.Controls.Add(this.label2);
            this.grp_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTin.Location = new System.Drawing.Point(933, 89);
            this.grp_ThongTin.Name = "grp_ThongTin";
            this.grp_ThongTin.Size = new System.Drawing.Size(326, 561);
            this.grp_ThongTin.TabIndex = 149;
            this.grp_ThongTin.TabStop = false;
            this.grp_ThongTin.Text = "Thông tin";
            // 
            // grp_DanhSach
            // 
            this.grp_DanhSach.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.grp_DanhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_DanhSach.Controls.Add(this.dgv_Sach);
            this.grp_DanhSach.Location = new System.Drawing.Point(40, 104);
            this.grp_DanhSach.Name = "grp_DanhSach";
            this.grp_DanhSach.Size = new System.Drawing.Size(759, 424);
            this.grp_DanhSach.TabIndex = 150;
            this.grp_DanhSach.TabStop = false;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe.Location = new System.Drawing.Point(43, 25);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(74, 44);
            this.lbl_TieuDe.TabIndex = 205;
            this.lbl_TieuDe.Text = "Sách";
            // 
            // Form_QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::GUI.Properties.Resources.pixil_frame_0__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.grp_DanhSach);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grp_ThongTin);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.lbl_Tim);
            this.Controls.Add(this.txt_TimKiem);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1291, 713);
            this.MinimumSize = new System.Drawing.Size(1291, 713);
            this.Name = "Form_QuanLySach";
            this.Text = "Form_QuanLySach";
            this.Load += new System.EventHandler(this.Form_QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet7)).EndInit();
            this.grp_ThongTin.ResumeLayout(false);
            this.grp_ThongTin.PerformLayout();
            this.grp_DanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_HinhAnh;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_DonViTinh;
        private System.Windows.Forms.ComboBox cbo_MaNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_GiaChoThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_XuatXu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.ComboBox cbo_MaLoaiSach;
        private System.Windows.Forms.Label lbl_MaLoaiSach;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.Label lbl_MaSanPham;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Button btn_ChonAnh;
        private System.Windows.Forms.TextBox txt_ChonAnh;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.Label lbl_TacGia;
        //private Library_managementDataSet2 library_managementDataSet2;
        //private System.Windows.Forms.BindingSource sachBindingSource;
        //private Library_managementDataSet2TableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatXuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaChoThueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuyenMaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private QL_ThuVienDataSet7 qL_ThuVienDataSet7;
        private System.Windows.Forms.BindingSource sachBindingSource2;
        private QL_ThuVienDataSet7TableAdapters.SachTableAdapter sachTableAdapter2;
        private System.Windows.Forms.ImageList imgSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox grp_ThongTin;
        private System.Windows.Forms.GroupBox grp_DanhSach;
        private System.Windows.Forms.Label lbl_TieuDe;
    }
}