namespace GUI
{
    partial class Form_MuonTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MuonTraSach));
            this.lbl_TienGuiKhach = new System.Windows.Forms.Label();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.lbl_TienKhachDua = new System.Windows.Forms.Label();
            this.rad_DaTra = new System.Windows.Forms.RadioButton();
            this.rad_ChuaTra = new System.Windows.Forms.RadioButton();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_HanTra = new System.Windows.Forms.Label();
            this.dtp_HanTra = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayMuon = new System.Windows.Forms.Label();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lbl_MaDG = new System.Windows.Forms.Label();
            this.cbo_MaDG = new System.Windows.Forms.ComboBox();
            this.btn_Them1Thang = new System.Windows.Forms.Button();
            this.lbl_SachMuon = new System.Windows.Forms.Label();
            this.clb_SachMuon = new System.Windows.Forms.CheckedListBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_TenDG = new System.Windows.Forms.TextBox();
            this.lbl_TenDG = new System.Windows.Forms.Label();
            this.grp_TrangThai = new System.Windows.Forms.GroupBox();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.btn_Tra = new System.Windows.Forms.Button();
            this.num_TienKhachDua = new System.Windows.Forms.NumericUpDown();
            this.lbl_MaDH = new System.Windows.Forms.Label();
            this.cbo_MaHD = new System.Windows.Forms.ComboBox();
            this.txt_TienGuiKhach = new System.Windows.Forms.TextBox();
            this.grp_TraSach = new System.Windows.Forms.GroupBox();
            this.grp_Muon = new System.Windows.Forms.GroupBox();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.grp_TrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).BeginInit();
            this.grp_TraSach.SuspendLayout();
            this.grp_Muon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TienGuiKhach
            // 
            this.lbl_TienGuiKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TienGuiKhach.AutoSize = true;
            this.lbl_TienGuiKhach.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TienGuiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienGuiKhach.Location = new System.Drawing.Point(33, 467);
            this.lbl_TienGuiKhach.Name = "lbl_TienGuiKhach";
            this.lbl_TienGuiKhach.Size = new System.Drawing.Size(111, 16);
            this.lbl_TienGuiKhach.TabIndex = 222;
            this.lbl_TienGuiKhach.Text = "Tiền Gửi Khách";
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
            // lbl_TienKhachDua
            // 
            this.lbl_TienKhachDua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TienKhachDua.AutoSize = true;
            this.lbl_TienKhachDua.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienKhachDua.Location = new System.Drawing.Point(29, 400);
            this.lbl_TienKhachDua.Name = "lbl_TienKhachDua";
            this.lbl_TienKhachDua.Size = new System.Drawing.Size(115, 16);
            this.lbl_TienKhachDua.TabIndex = 220;
            this.lbl_TienKhachDua.Text = "Tiền Khách Đưa";
            // 
            // rad_DaTra
            // 
            this.rad_DaTra.AutoSize = true;
            this.rad_DaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_DaTra.ForeColor = System.Drawing.Color.Red;
            this.rad_DaTra.Location = new System.Drawing.Point(72, 74);
            this.rad_DaTra.Name = "rad_DaTra";
            this.rad_DaTra.Size = new System.Drawing.Size(114, 20);
            this.rad_DaTra.TabIndex = 219;
            this.rad_DaTra.Text = "Đã Trả Sách";
            this.rad_DaTra.UseVisualStyleBackColor = true;
            // 
            // rad_ChuaTra
            // 
            this.rad_ChuaTra.AutoSize = true;
            this.rad_ChuaTra.Checked = true;
            this.rad_ChuaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ChuaTra.ForeColor = System.Drawing.Color.Red;
            this.rad_ChuaTra.Location = new System.Drawing.Point(72, 38);
            this.rad_ChuaTra.Name = "rad_ChuaTra";
            this.rad_ChuaTra.Size = new System.Drawing.Size(130, 20);
            this.rad_ChuaTra.TabIndex = 218;
            this.rad_ChuaTra.TabStop = true;
            this.rad_ChuaTra.Text = "Chưa Trả Sách";
            this.rad_ChuaTra.UseVisualStyleBackColor = true;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ThanhTien.Location = new System.Drawing.Point(62, 357);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(229, 22);
            this.txt_ThanhTien.TabIndex = 201;
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(33, 330);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(85, 16);
            this.lbl_ThanhTien.TabIndex = 200;
            this.lbl_ThanhTien.Text = "Thành Tiền";
            // 
            // lbl_HanTra
            // 
            this.lbl_HanTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_HanTra.AutoSize = true;
            this.lbl_HanTra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HanTra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HanTra.Location = new System.Drawing.Point(29, 266);
            this.lbl_HanTra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_HanTra.Name = "lbl_HanTra";
            this.lbl_HanTra.Size = new System.Drawing.Size(61, 17);
            this.lbl_HanTra.TabIndex = 197;
            this.lbl_HanTra.Text = "Hạn Trả";
            // 
            // dtp_HanTra
            // 
            this.dtp_HanTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_HanTra.Enabled = false;
            this.dtp_HanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HanTra.Location = new System.Drawing.Point(62, 290);
            this.dtp_HanTra.Name = "dtp_HanTra";
            this.dtp_HanTra.Size = new System.Drawing.Size(139, 22);
            this.dtp_HanTra.TabIndex = 196;
            // 
            // lbl_NgayMuon
            // 
            this.lbl_NgayMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NgayMuon.AutoSize = true;
            this.lbl_NgayMuon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayMuon.Location = new System.Drawing.Point(29, 204);
            this.lbl_NgayMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NgayMuon.Name = "lbl_NgayMuon";
            this.lbl_NgayMuon.Size = new System.Drawing.Size(85, 17);
            this.lbl_NgayMuon.TabIndex = 195;
            this.lbl_NgayMuon.Text = "Ngày Mượn";
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(62, 226);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(139, 22);
            this.dtp_NgayMuon.TabIndex = 194;
            // 
            // lbl_MaDG
            // 
            this.lbl_MaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaDG.AutoSize = true;
            this.lbl_MaDG.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaDG.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDG.Location = new System.Drawing.Point(29, 29);
            this.lbl_MaDG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaDG.Name = "lbl_MaDG";
            this.lbl_MaDG.Size = new System.Drawing.Size(86, 17);
            this.lbl_MaDG.TabIndex = 190;
            this.lbl_MaDG.Text = "Mã Độc Giả";
            // 
            // cbo_MaDG
            // 
            this.cbo_MaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaDG.FormattingEnabled = true;
            this.cbo_MaDG.Location = new System.Drawing.Point(66, 50);
            this.cbo_MaDG.Name = "cbo_MaDG";
            this.cbo_MaDG.Size = new System.Drawing.Size(233, 24);
            this.cbo_MaDG.TabIndex = 189;
            this.cbo_MaDG.SelectedIndexChanged += new System.EventHandler(this.cbo_MaDG_SelectedIndexChanged);
            // 
            // btn_Them1Thang
            // 
            this.btn_Them1Thang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Them1Thang.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Them1Thang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them1Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them1Thang.Location = new System.Drawing.Point(211, 247);
            this.btn_Them1Thang.Name = "btn_Them1Thang";
            this.btn_Them1Thang.Size = new System.Drawing.Size(88, 57);
            this.btn_Them1Thang.TabIndex = 225;
            this.btn_Them1Thang.Text = "+ 1 tháng";
            this.btn_Them1Thang.UseVisualStyleBackColor = false;
            this.btn_Them1Thang.Click += new System.EventHandler(this.btn_Them1Thang_Click);
            // 
            // lbl_SachMuon
            // 
            this.lbl_SachMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SachMuon.AutoSize = true;
            this.lbl_SachMuon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SachMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SachMuon.Location = new System.Drawing.Point(385, 50);
            this.lbl_SachMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_SachMuon.Name = "lbl_SachMuon";
            this.lbl_SachMuon.Size = new System.Drawing.Size(82, 17);
            this.lbl_SachMuon.TabIndex = 236;
            this.lbl_SachMuon.Text = "Sách Mượn";
            // 
            // clb_SachMuon
            // 
            this.clb_SachMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clb_SachMuon.FormattingEnabled = true;
            this.clb_SachMuon.Location = new System.Drawing.Point(409, 77);
            this.clb_SachMuon.Name = "clb_SachMuon";
            this.clb_SachMuon.Size = new System.Drawing.Size(230, 293);
            this.clb_SachMuon.TabIndex = 235;
            this.clb_SachMuon.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_SachMuon_ItemCheck);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Location = new System.Drawing.Point(62, 165);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(233, 22);
            this.txt_SDT.TabIndex = 240;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(29, 146);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(37, 16);
            this.lbl_SDT.TabIndex = 239;
            this.lbl_SDT.Text = "SĐT";
            // 
            // txt_TenDG
            // 
            this.txt_TenDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenDG.Location = new System.Drawing.Point(66, 110);
            this.txt_TenDG.Name = "txt_TenDG";
            this.txt_TenDG.ReadOnly = true;
            this.txt_TenDG.Size = new System.Drawing.Size(233, 22);
            this.txt_TenDG.TabIndex = 238;
            // 
            // lbl_TenDG
            // 
            this.lbl_TenDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenDG.AutoSize = true;
            this.lbl_TenDG.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDG.Location = new System.Drawing.Point(29, 91);
            this.lbl_TenDG.Name = "lbl_TenDG";
            this.lbl_TenDG.Size = new System.Drawing.Size(93, 16);
            this.lbl_TenDG.TabIndex = 237;
            this.lbl_TenDG.Text = "Tên Độc Giả";
            // 
            // grp_TrangThai
            // 
            this.grp_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TrangThai.BackColor = System.Drawing.Color.Transparent;
            this.grp_TrangThai.Controls.Add(this.rad_ChuaTra);
            this.grp_TrangThai.Controls.Add(this.rad_DaTra);
            this.grp_TrangThai.Enabled = false;
            this.grp_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TrangThai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grp_TrangThai.Location = new System.Drawing.Point(32, 108);
            this.grp_TrangThai.Name = "grp_TrangThai";
            this.grp_TrangThai.Size = new System.Drawing.Size(274, 128);
            this.grp_TrangThai.TabIndex = 241;
            this.grp_TrangThai.TabStop = false;
            this.grp_TrangThai.Text = "Trạng Thái";
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InHoaDon.BackColor = System.Drawing.Color.White;
            this.btn_InHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InHoaDon.BackgroundImage")));
            this.btn_InHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_InHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InHoaDon.Enabled = false;
            this.btn_InHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Mistral", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InHoaDon.ImageIndex = 9;
            this.btn_InHoaDon.ImageList = this.imgHinhAnh;
            this.btn_InHoaDon.Location = new System.Drawing.Point(815, 217);
            this.btn_InHoaDon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(108, 74);
            this.btn_InHoaDon.TabIndex = 217;
            this.btn_InHoaDon.Text = "IN HÓA ĐƠN";
            this.btn_InHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
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
            this.btn_Thoat.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Thoat.ImageIndex = 3;
            this.btn_Thoat.ImageList = this.imgHinhAnh;
            this.btn_Thoat.Location = new System.Drawing.Point(1164, 2);
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
            this.btn_LamMoi.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LamMoi.ImageIndex = 1;
            this.btn_LamMoi.ImageList = this.imgHinhAnh;
            this.btn_LamMoi.Location = new System.Drawing.Point(815, 101);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 74);
            this.btn_LamMoi.TabIndex = 98;
            this.btn_LamMoi.Text = "LÀM MỚI";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Muon
            // 
            this.btn_Muon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Muon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Muon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Muon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Muon.Location = new System.Drawing.Point(447, 442);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(122, 61);
            this.btn_Muon.TabIndex = 243;
            this.btn_Muon.Text = "Mượn";
            this.btn_Muon.UseVisualStyleBackColor = false;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
            // 
            // btn_Tra
            // 
            this.btn_Tra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Tra.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Tra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tra.Location = new System.Drawing.Point(112, 442);
            this.btn_Tra.Name = "btn_Tra";
            this.btn_Tra.Size = new System.Drawing.Size(122, 61);
            this.btn_Tra.TabIndex = 244;
            this.btn_Tra.Text = "Trả";
            this.btn_Tra.UseVisualStyleBackColor = false;
            this.btn_Tra.Click += new System.EventHandler(this.btn_Tra_Click);
            // 
            // num_TienKhachDua
            // 
            this.num_TienKhachDua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_TienKhachDua.Location = new System.Drawing.Point(62, 424);
            this.num_TienKhachDua.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.num_TienKhachDua.Name = "num_TienKhachDua";
            this.num_TienKhachDua.Size = new System.Drawing.Size(228, 22);
            this.num_TienKhachDua.TabIndex = 245;
            this.num_TienKhachDua.ValueChanged += new System.EventHandler(this.num_TienKhachDua_ValueChanged);
            // 
            // lbl_MaDH
            // 
            this.lbl_MaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaDH.AutoSize = true;
            this.lbl_MaDH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaDH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDH.Location = new System.Drawing.Point(29, 47);
            this.lbl_MaDH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaDH.Name = "lbl_MaDH";
            this.lbl_MaDH.Size = new System.Drawing.Size(92, 17);
            this.lbl_MaDH.TabIndex = 248;
            this.lbl_MaDH.Text = "Mã Hóa Đơn";
            // 
            // cbo_MaHD
            // 
            this.cbo_MaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaHD.FormattingEnabled = true;
            this.cbo_MaHD.Location = new System.Drawing.Point(129, 45);
            this.cbo_MaHD.Name = "cbo_MaHD";
            this.cbo_MaHD.Size = new System.Drawing.Size(177, 24);
            this.cbo_MaHD.TabIndex = 247;
            this.cbo_MaHD.SelectedIndexChanged += new System.EventHandler(this.cbo_MaHD_SelectedIndexChanged);
            // 
            // txt_TienGuiKhach
            // 
            this.txt_TienGuiKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TienGuiKhach.Location = new System.Drawing.Point(66, 492);
            this.txt_TienGuiKhach.Name = "txt_TienGuiKhach";
            this.txt_TienGuiKhach.ReadOnly = true;
            this.txt_TienGuiKhach.Size = new System.Drawing.Size(229, 22);
            this.txt_TienGuiKhach.TabIndex = 249;
            // 
            // grp_TraSach
            // 
            this.grp_TraSach.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.grp_TraSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_TraSach.Controls.Add(this.cbo_MaHD);
            this.grp_TraSach.Controls.Add(this.lbl_MaDH);
            this.grp_TraSach.Controls.Add(this.grp_TrangThai);
            this.grp_TraSach.Controls.Add(this.btn_Tra);
            this.grp_TraSach.Location = new System.Drawing.Point(931, 85);
            this.grp_TraSach.Name = "grp_TraSach";
            this.grp_TraSach.Size = new System.Drawing.Size(330, 569);
            this.grp_TraSach.TabIndex = 250;
            this.grp_TraSach.TabStop = false;
            // 
            // grp_Muon
            // 
            this.grp_Muon.BackColor = System.Drawing.Color.Transparent;
            this.grp_Muon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_Muon.Controls.Add(this.btn_Them1Thang);
            this.grp_Muon.Controls.Add(this.cbo_MaDG);
            this.grp_Muon.Controls.Add(this.lbl_MaDG);
            this.grp_Muon.Controls.Add(this.txt_TienGuiKhach);
            this.grp_Muon.Controls.Add(this.dtp_NgayMuon);
            this.grp_Muon.Controls.Add(this.txt_SDT);
            this.grp_Muon.Controls.Add(this.lbl_SDT);
            this.grp_Muon.Controls.Add(this.btn_Muon);
            this.grp_Muon.Controls.Add(this.txt_TenDG);
            this.grp_Muon.Controls.Add(this.lbl_NgayMuon);
            this.grp_Muon.Controls.Add(this.lbl_TenDG);
            this.grp_Muon.Controls.Add(this.num_TienKhachDua);
            this.grp_Muon.Controls.Add(this.dtp_HanTra);
            this.grp_Muon.Controls.Add(this.lbl_HanTra);
            this.grp_Muon.Controls.Add(this.clb_SachMuon);
            this.grp_Muon.Controls.Add(this.lbl_ThanhTien);
            this.grp_Muon.Controls.Add(this.txt_ThanhTien);
            this.grp_Muon.Controls.Add(this.lbl_TienKhachDua);
            this.grp_Muon.Controls.Add(this.lbl_TienGuiKhach);
            this.grp_Muon.Controls.Add(this.lbl_SachMuon);
            this.grp_Muon.Location = new System.Drawing.Point(26, 85);
            this.grp_Muon.Name = "grp_Muon";
            this.grp_Muon.Size = new System.Drawing.Size(739, 569);
            this.grp_Muon.TabIndex = 251;
            this.grp_Muon.TabStop = false;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe.Location = new System.Drawing.Point(36, 23);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(244, 44);
            this.lbl_TieuDe.TabIndex = 252;
            this.lbl_TieuDe.Text = "Mượn / Trả Sách";
            // 
            // Form_MuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::GUI.Properties.Resources.pixil_frame_0__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.grp_Muon);
            this.Controls.Add(this.grp_TraSach);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1291, 713);
            this.MinimumSize = new System.Drawing.Size(1291, 713);
            this.Name = "Form_MuonTraSach";
            this.Text = "Form_MuonTraSach";
            this.Load += new System.EventHandler(this.Form_MuonTraSach_Load);
            this.grp_TrangThai.ResumeLayout(false);
            this.grp_TrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).EndInit();
            this.grp_TraSach.ResumeLayout(false);
            this.grp_TraSach.PerformLayout();
            this.grp_Muon.ResumeLayout(false);
            this.grp_Muon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TienGuiKhach;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.Label lbl_TienKhachDua;
        private System.Windows.Forms.RadioButton rad_DaTra;
        private System.Windows.Forms.RadioButton rad_ChuaTra;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_HanTra;
        private System.Windows.Forms.DateTimePicker dtp_HanTra;
        private System.Windows.Forms.Label lbl_NgayMuon;
        private System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.Label lbl_MaDG;
        private System.Windows.Forms.ComboBox cbo_MaDG;
        private System.Windows.Forms.Button btn_Them1Thang;
        private System.Windows.Forms.Label lbl_SachMuon;
        private System.Windows.Forms.CheckedListBox clb_SachMuon;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_TenDG;
        private System.Windows.Forms.Label lbl_TenDG;
        private System.Windows.Forms.GroupBox grp_TrangThai;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Muon;
        private System.Windows.Forms.Button btn_Tra;
        private System.Windows.Forms.NumericUpDown num_TienKhachDua;
        private System.Windows.Forms.Label lbl_MaDH;
        private System.Windows.Forms.ComboBox cbo_MaHD;
        private System.Windows.Forms.TextBox txt_TienGuiKhach;
        private System.Windows.Forms.GroupBox grp_TraSach;
        private System.Windows.Forms.GroupBox grp_Muon;
        private System.Windows.Forms.Label lbl_TieuDe;
    }
}