namespace GUI
{
    partial class Form_QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyHoaDon));
            this.lbl_TienGuiKhach = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TienKhachDua = new System.Windows.Forms.Label();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbo_MaDG = new System.Windows.Forms.ComboBox();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.lbl_MaDG = new System.Windows.Forms.Label();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.lbl_HanTra = new System.Windows.Forms.Label();
            this.dtp_HanTra = new System.Windows.Forms.DateTimePicker();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienKhachDuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienGuiKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_ThuVienDataSet4 = new GUI.QL_ThuVienDataSet4();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.num_TienKhachDua = new System.Windows.Forms.NumericUpDown();
            this.num_TienGuiKhach = new System.Windows.Forms.NumericUpDown();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.hoaDonTableAdapter = new GUI.QL_ThuVienDataSet4TableAdapters.HoaDonTableAdapter();
            this.clb_SachDaMuon = new System.Windows.Forms.CheckedListBox();
            this.lbl_SachDaMuon = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_NgayTra = new System.Windows.Forms.Label();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.grp_ThongTIn = new System.Windows.Forms.GroupBox();
            this.grp_DuLieu = new System.Windows.Forms.GroupBox();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienGuiKhach)).BeginInit();
            this.grp_ThongTIn.SuspendLayout();
            this.grp_DuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TienGuiKhach
            // 
            this.lbl_TienGuiKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TienGuiKhach.AutoSize = true;
            this.lbl_TienGuiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienGuiKhach.Location = new System.Drawing.Point(10, 259);
            this.lbl_TienGuiKhach.Name = "lbl_TienGuiKhach";
            this.lbl_TienGuiKhach.Size = new System.Drawing.Size(111, 16);
            this.lbl_TienGuiKhach.TabIndex = 213;
            this.lbl_TienGuiKhach.Text = "Tiền Gửi Khách";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(138, 288);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(170, 24);
            this.txt_ThanhTien.TabIndex = 212;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 211;
            this.label4.Text = "Thành Tiền";
            // 
            // lbl_TienKhachDua
            // 
            this.lbl_TienKhachDua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TienKhachDua.AutoSize = true;
            this.lbl_TienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienKhachDua.Location = new System.Drawing.Point(6, 225);
            this.lbl_TienKhachDua.Name = "lbl_TienKhachDua";
            this.lbl_TienKhachDua.Size = new System.Drawing.Size(115, 16);
            this.lbl_TienKhachDua.TabIndex = 209;
            this.lbl_TienKhachDua.Text = "Tiền Khách Đưa";
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayLap.Location = new System.Drawing.Point(54, 91);
            this.lbl_NgayLap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(70, 17);
            this.lbl_NgayLap.TabIndex = 208;
            this.lbl_NgayLap.Text = "Ngày Lập";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NgayLap.Enabled = false;
            this.dtp_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLap.Location = new System.Drawing.Point(138, 91);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(170, 24);
            this.dtp_NgayLap.TabIndex = 207;
            // 
            // cbo_MaDG
            // 
            this.cbo_MaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaDG.Enabled = false;
            this.cbo_MaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaDG.FormattingEnabled = true;
            this.cbo_MaDG.Location = new System.Drawing.Point(138, 57);
            this.cbo_MaDG.Name = "cbo_MaDG";
            this.cbo_MaDG.Size = new System.Drawing.Size(170, 26);
            this.cbo_MaDG.TabIndex = 206;
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.Location = new System.Drawing.Point(38, 29);
            this.lbl_MaHD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(92, 17);
            this.lbl_MaHD.TabIndex = 205;
            this.lbl_MaHD.Text = "Mã Hóa Đơn";
            // 
            // lbl_MaDG
            // 
            this.lbl_MaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaDG.AutoSize = true;
            this.lbl_MaDG.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDG.Location = new System.Drawing.Point(38, 57);
            this.lbl_MaDG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaDG.Name = "lbl_MaDG";
            this.lbl_MaDG.Size = new System.Drawing.Size(86, 17);
            this.lbl_MaDG.TabIndex = 203;
            this.lbl_MaDG.Text = "Mã Độc Giả";
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
            this.imgHinhAnh.Images.SetKeyName(10, "OIP (1).jpg");
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemChiTiet.BackColor = System.Drawing.Color.White;
            this.btn_XemChiTiet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_XemChiTiet.BackgroundImage")));
            this.btn_XemChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XemChiTiet.FlatAppearance.BorderSize = 0;
            this.btn_XemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemChiTiet.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemChiTiet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_XemChiTiet.ImageIndex = 10;
            this.btn_XemChiTiet.ImageList = this.imgHinhAnh;
            this.btn_XemChiTiet.Location = new System.Drawing.Point(815, 331);
            this.btn_XemChiTiet.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(108, 74);
            this.btn_XemChiTiet.TabIndex = 193;
            this.btn_XemChiTiet.Text = "CHI TIẾT";
            this.btn_XemChiTiet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_XemChiTiet.UseVisualStyleBackColor = false;
            this.btn_XemChiTiet.Click += new System.EventHandler(this.btn_XemChiTiet_Click);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHD.Location = new System.Drawing.Point(138, 24);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(170, 24);
            this.txt_MaHD.TabIndex = 219;
            // 
            // lbl_HanTra
            // 
            this.lbl_HanTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_HanTra.AutoSize = true;
            this.lbl_HanTra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HanTra.Location = new System.Drawing.Point(63, 122);
            this.lbl_HanTra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_HanTra.Name = "lbl_HanTra";
            this.lbl_HanTra.Size = new System.Drawing.Size(61, 17);
            this.lbl_HanTra.TabIndex = 221;
            this.lbl_HanTra.Text = "Hạn Trả";
            // 
            // dtp_HanTra
            // 
            this.dtp_HanTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_HanTra.Enabled = false;
            this.dtp_HanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_HanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HanTra.Location = new System.Drawing.Point(138, 124);
            this.dtp_HanTra.Name = "dtp_HanTra";
            this.dtp_HanTra.Size = new System.Drawing.Size(170, 24);
            this.dtp_HanTra.TabIndex = 220;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_HoaDon.AutoGenerateColumns = false;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maDGDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.hanTraDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tienKhachDuaDataGridViewTextBoxColumn,
            this.tienGuiKhachDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dgv_HoaDon.DataSource = this.hoaDonBindingSource;
            this.dgv_HoaDon.Location = new System.Drawing.Point(6, 5);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(747, 413);
            this.dgv_HoaDon.TabIndex = 223;
            this.dgv_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // maDGDataGridViewTextBoxColumn
            // 
            this.maDGDataGridViewTextBoxColumn.DataPropertyName = "MaDG";
            this.maDGDataGridViewTextBoxColumn.HeaderText = "MaDG";
            this.maDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDGDataGridViewTextBoxColumn.Name = "maDGDataGridViewTextBoxColumn";
            this.maDGDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // hanTraDataGridViewTextBoxColumn
            // 
            this.hanTraDataGridViewTextBoxColumn.DataPropertyName = "HanTra";
            this.hanTraDataGridViewTextBoxColumn.HeaderText = "HanTra";
            this.hanTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hanTraDataGridViewTextBoxColumn.Name = "hanTraDataGridViewTextBoxColumn";
            this.hanTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.hanTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienKhachDuaDataGridViewTextBoxColumn
            // 
            this.tienKhachDuaDataGridViewTextBoxColumn.DataPropertyName = "TienKhachDua";
            this.tienKhachDuaDataGridViewTextBoxColumn.HeaderText = "TienKhachDua";
            this.tienKhachDuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienKhachDuaDataGridViewTextBoxColumn.Name = "tienKhachDuaDataGridViewTextBoxColumn";
            this.tienKhachDuaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tienKhachDuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienGuiKhachDataGridViewTextBoxColumn
            // 
            this.tienGuiKhachDataGridViewTextBoxColumn.DataPropertyName = "TienGuiKhach";
            this.tienGuiKhachDataGridViewTextBoxColumn.HeaderText = "TienGuiKhach";
            this.tienGuiKhachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienGuiKhachDataGridViewTextBoxColumn.Name = "tienGuiKhachDataGridViewTextBoxColumn";
            this.tienGuiKhachDataGridViewTextBoxColumn.ReadOnly = true;
            this.tienGuiKhachDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qL_ThuVienDataSet4;
            // 
            // qL_ThuVienDataSet4
            // 
            this.qL_ThuVienDataSet4.DataSetName = "QL_ThuVienDataSet4";
            this.qL_ThuVienDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(48, 190);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(72, 16);
            this.lbl_SoLuong.TabIndex = 224;
            this.lbl_SoLuong.Text = "Số Lượng";
            // 
            // num_SoLuong
            // 
            this.num_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_SoLuong.Location = new System.Drawing.Point(138, 190);
            this.num_SoLuong.Name = "num_SoLuong";
            this.num_SoLuong.ReadOnly = true;
            this.num_SoLuong.Size = new System.Drawing.Size(170, 24);
            this.num_SoLuong.TabIndex = 226;
            // 
            // num_TienKhachDua
            // 
            this.num_TienKhachDua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_TienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_TienKhachDua.Location = new System.Drawing.Point(138, 223);
            this.num_TienKhachDua.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.num_TienKhachDua.Name = "num_TienKhachDua";
            this.num_TienKhachDua.ReadOnly = true;
            this.num_TienKhachDua.Size = new System.Drawing.Size(170, 24);
            this.num_TienKhachDua.TabIndex = 227;
            // 
            // num_TienGuiKhach
            // 
            this.num_TienGuiKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_TienGuiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_TienGuiKhach.Location = new System.Drawing.Point(138, 255);
            this.num_TienGuiKhach.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.num_TienGuiKhach.Name = "num_TienGuiKhach";
            this.num_TienGuiKhach.ReadOnly = true;
            this.num_TienGuiKhach.Size = new System.Drawing.Size(170, 24);
            this.num_TienGuiKhach.TabIndex = 228;
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
            this.btn_Thoat.Location = new System.Drawing.Point(1164, 1);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 74);
            this.btn_Thoat.TabIndex = 99;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
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
            this.btn_Xoa.Location = new System.Drawing.Point(815, 136);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 74);
            this.btn_Xoa.TabIndex = 97;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_LamMoi.Location = new System.Drawing.Point(815, 232);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 74);
            this.btn_LamMoi.TabIndex = 98;
            this.btn_LamMoi.Text = "LÀM MỚI";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // lbl_Tim
            // 
            this.lbl_Tim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Tim.Location = new System.Drawing.Point(55, 557);
            this.lbl_Tim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(82, 18);
            this.lbl_Tim.TabIndex = 232;
            this.lbl_Tim.Text = "Tìm kiếm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiem.Location = new System.Drawing.Point(159, 553);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_TimKiem.MaximumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.MinimumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.TabIndex = 231;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // clb_SachDaMuon
            // 
            this.clb_SachDaMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clb_SachDaMuon.Enabled = false;
            this.clb_SachDaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_SachDaMuon.FormattingEnabled = true;
            this.clb_SachDaMuon.Location = new System.Drawing.Point(92, 378);
            this.clb_SachDaMuon.Name = "clb_SachDaMuon";
            this.clb_SachDaMuon.Size = new System.Drawing.Size(216, 180);
            this.clb_SachDaMuon.TabIndex = 233;
            // 
            // lbl_SachDaMuon
            // 
            this.lbl_SachDaMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SachDaMuon.AutoSize = true;
            this.lbl_SachDaMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SachDaMuon.Location = new System.Drawing.Point(20, 357);
            this.lbl_SachDaMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_SachDaMuon.Name = "lbl_SachDaMuon";
            this.lbl_SachDaMuon.Size = new System.Drawing.Size(104, 17);
            this.lbl_SachDaMuon.TabIndex = 234;
            this.lbl_SachDaMuon.Text = "Sách Đã Mượn";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrangThai.Location = new System.Drawing.Point(138, 321);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.ReadOnly = true;
            this.txt_TrangThai.Size = new System.Drawing.Size(170, 24);
            this.txt_TrangThai.TabIndex = 236;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(41, 321);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(83, 16);
            this.lbl_TrangThai.TabIndex = 235;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // lbl_NgayTra
            // 
            this.lbl_NgayTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NgayTra.AutoSize = true;
            this.lbl_NgayTra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTra.Location = new System.Drawing.Point(63, 155);
            this.lbl_NgayTra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NgayTra.Name = "lbl_NgayTra";
            this.lbl_NgayTra.Size = new System.Drawing.Size(67, 17);
            this.lbl_NgayTra.TabIndex = 238;
            this.lbl_NgayTra.Text = "Ngày Trả";
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NgayTra.Enabled = false;
            this.dtp_NgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(138, 157);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(170, 24);
            this.dtp_NgayTra.TabIndex = 237;
            // 
            // grp_ThongTIn
            // 
            this.grp_ThongTIn.Controls.Add(this.cbo_MaDG);
            this.grp_ThongTIn.Controls.Add(this.lbl_SachDaMuon);
            this.grp_ThongTIn.Controls.Add(this.txt_TrangThai);
            this.grp_ThongTIn.Controls.Add(this.clb_SachDaMuon);
            this.grp_ThongTIn.Controls.Add(this.lbl_TrangThai);
            this.grp_ThongTIn.Controls.Add(this.lbl_NgayTra);
            this.grp_ThongTIn.Controls.Add(this.lbl_MaDG);
            this.grp_ThongTIn.Controls.Add(this.dtp_NgayTra);
            this.grp_ThongTIn.Controls.Add(this.lbl_MaHD);
            this.grp_ThongTIn.Controls.Add(this.txt_MaHD);
            this.grp_ThongTIn.Controls.Add(this.dtp_NgayLap);
            this.grp_ThongTIn.Controls.Add(this.lbl_NgayLap);
            this.grp_ThongTIn.Controls.Add(this.num_TienGuiKhach);
            this.grp_ThongTIn.Controls.Add(this.txt_ThanhTien);
            this.grp_ThongTIn.Controls.Add(this.label4);
            this.grp_ThongTIn.Controls.Add(this.num_TienKhachDua);
            this.grp_ThongTIn.Controls.Add(this.dtp_HanTra);
            this.grp_ThongTIn.Controls.Add(this.num_SoLuong);
            this.grp_ThongTIn.Controls.Add(this.lbl_HanTra);
            this.grp_ThongTIn.Controls.Add(this.lbl_SoLuong);
            this.grp_ThongTIn.Controls.Add(this.lbl_TienKhachDua);
            this.grp_ThongTIn.Controls.Add(this.lbl_TienGuiKhach);
            this.grp_ThongTIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTIn.Location = new System.Drawing.Point(933, 90);
            this.grp_ThongTIn.Name = "grp_ThongTIn";
            this.grp_ThongTIn.Size = new System.Drawing.Size(328, 564);
            this.grp_ThongTIn.TabIndex = 239;
            this.grp_ThongTIn.TabStop = false;
            this.grp_ThongTIn.Text = "Thông tin";
            // 
            // grp_DuLieu
            // 
            this.grp_DuLieu.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.grp_DuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_DuLieu.Controls.Add(this.dgv_HoaDon);
            this.grp_DuLieu.Location = new System.Drawing.Point(50, 114);
            this.grp_DuLieu.Name = "grp_DuLieu";
            this.grp_DuLieu.Size = new System.Drawing.Size(759, 424);
            this.grp_DuLieu.TabIndex = 240;
            this.grp_DuLieu.TabStop = false;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe.Location = new System.Drawing.Point(50, 31);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(135, 44);
            this.lbl_TieuDe.TabIndex = 241;
            this.lbl_TieuDe.Text = "Hóa Đơn";
            // 
            // Form_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::GUI.Properties.Resources.pixil_frame_0__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.grp_DuLieu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grp_ThongTIn);
            this.Controls.Add(this.lbl_Tim);
            this.Controls.Add(this.btn_XemChiTiet);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_TimKiem);
            this.DoubleBuffered = true;
            this.Name = "Form_QuanLyHoaDon";
            this.Text = "Form_QuanLyHoaDon";
            this.Load += new System.EventHandler(this.Form_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienGuiKhach)).EndInit();
            this.grp_ThongTIn.ResumeLayout(false);
            this.grp_ThongTIn.PerformLayout();
            this.grp_DuLieu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TienGuiKhach;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TienKhachDua;
        private System.Windows.Forms.Label lbl_NgayLap;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.ComboBox cbo_MaDG;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.Label lbl_MaDG;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.Button btn_XemChiTiet;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label lbl_HanTra;
        private System.Windows.Forms.DateTimePicker dtp_HanTra;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.NumericUpDown num_SoLuong;
        private System.Windows.Forms.NumericUpDown num_TienKhachDua;
        private System.Windows.Forms.NumericUpDown num_TienGuiKhach;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private QL_ThuVienDataSet4 qL_ThuVienDataSet4;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QL_ThuVienDataSet4TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienKhachDuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienGuiKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox clb_SachDaMuon;
        private System.Windows.Forms.Label lbl_SachDaMuon;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.Label lbl_NgayTra;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.GroupBox grp_ThongTIn;
        private System.Windows.Forms.GroupBox grp_DuLieu;
        private System.Windows.Forms.Label lbl_TieuDe;
    }
}