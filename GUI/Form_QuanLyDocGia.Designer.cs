namespace GUI
{
    partial class Form_QuanLyDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyDocGia));
            this.txt_MaDocGia = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_TenDocGia = new System.Windows.Forms.TextBox();
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenDocGia = new System.Windows.Forms.Label();
            this.lbl_MaDocGia = new System.Windows.Forms.Label();
            this.dgv_DocGia = new System.Windows.Forms.DataGridView();
            this.maDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_ThuVienDataSet3 = new GUI.QL_ThuVienDataSet3();
            this.lbl_NgayTao = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.dtp_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.docGiaTableAdapter = new GUI.QL_ThuVienDataSet3TableAdapters.DocGiaTableAdapter();
            this.grp_ThongTIn = new System.Windows.Forms.GroupBox();
            this.grp_DuLieu = new System.Windows.Forms.GroupBox();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet3)).BeginInit();
            this.grp_ThongTIn.SuspendLayout();
            this.grp_DuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDocGia.Location = new System.Drawing.Point(70, 73);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.ReadOnly = true;
            this.txt_MaDocGia.Size = new System.Drawing.Size(170, 24);
            this.txt_MaDocGia.TabIndex = 170;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Xoa.ImageIndex = 2;
            this.btn_Xoa.ImageList = this.imgHinhAnh;
            this.btn_Xoa.Location = new System.Drawing.Point(815, 205);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 74);
            this.btn_Xoa.TabIndex = 96;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Them.ImageIndex = 0;
            this.btn_Them.ImageList = this.imgHinhAnh;
            this.btn_Them.Location = new System.Drawing.Point(815, 116);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 74);
            this.btn_Them.TabIndex = 95;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sua.ImageIndex = 5;
            this.btn_Sua.ImageList = this.imgHinhAnh;
            this.btn_Sua.Location = new System.Drawing.Point(815, 295);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 74);
            this.btn_Sua.TabIndex = 97;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LamMoi.BackColor = System.Drawing.Color.White;
            this.btn_LamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.BackgroundImage")));
            this.btn_LamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamMoi.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LamMoi.ImageIndex = 1;
            this.btn_LamMoi.ImageList = this.imgHinhAnh;
            this.btn_LamMoi.Location = new System.Drawing.Point(815, 389);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 74);
            this.btn_LamMoi.TabIndex = 98;
            this.btn_LamMoi.Text = "LÀM MỚI";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CapNhat.BackgroundImage = global::GUI.Properties.Resources.bg;
            this.btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CapNhat.Location = new System.Drawing.Point(398, 576);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(204, 70);
            this.btn_CapNhat.TabIndex = 167;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(70, 356);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(170, 24);
            this.txt_Email.TabIndex = 166;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(20, 325);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 17);
            this.lbl_Email.TabIndex = 165;
            this.lbl_Email.Text = "Email";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(70, 284);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(170, 24);
            this.txt_SDT.TabIndex = 157;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(20, 246);
            this.lbl_SDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(100, 17);
            this.lbl_SDT.TabIndex = 156;
            this.lbl_SDT.Text = "Số Điện Thoại";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(70, 202);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(170, 24);
            this.txt_DiaChi.TabIndex = 155;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(20, 177);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(57, 17);
            this.lbl_DiaChi.TabIndex = 154;
            this.lbl_DiaChi.Text = "Địa Chỉ";
            // 
            // txt_TenDocGia
            // 
            this.txt_TenDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDocGia.Location = new System.Drawing.Point(70, 140);
            this.txt_TenDocGia.Name = "txt_TenDocGia";
            this.txt_TenDocGia.ReadOnly = true;
            this.txt_TenDocGia.Size = new System.Drawing.Size(170, 24);
            this.txt_TenDocGia.TabIndex = 151;
            // 
            // lbl_Tim
            // 
            this.lbl_Tim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tim.ForeColor = System.Drawing.Color.White;
            this.lbl_Tim.Location = new System.Drawing.Point(45, 556);
            this.lbl_Tim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(82, 18);
            this.lbl_Tim.TabIndex = 148;
            this.lbl_Tim.Text = "Tìm kiếm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiem.Location = new System.Drawing.Point(146, 555);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_TimKiem.MaximumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.MinimumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.TabIndex = 147;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TenDocGia
            // 
            this.lbl_TenDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenDocGia.AutoSize = true;
            this.lbl_TenDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDocGia.Location = new System.Drawing.Point(18, 112);
            this.lbl_TenDocGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TenDocGia.Name = "lbl_TenDocGia";
            this.lbl_TenDocGia.Size = new System.Drawing.Size(90, 17);
            this.lbl_TenDocGia.TabIndex = 146;
            this.lbl_TenDocGia.Text = "Tên Độc Giả";
            // 
            // lbl_MaDocGia
            // 
            this.lbl_MaDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaDocGia.AutoSize = true;
            this.lbl_MaDocGia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDocGia.Location = new System.Drawing.Point(20, 44);
            this.lbl_MaDocGia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaDocGia.Name = "lbl_MaDocGia";
            this.lbl_MaDocGia.Size = new System.Drawing.Size(86, 17);
            this.lbl_MaDocGia.TabIndex = 145;
            this.lbl_MaDocGia.Text = "Mã Độc Giả";
            // 
            // dgv_DocGia
            // 
            this.dgv_DocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DocGia.AutoGenerateColumns = false;
            this.dgv_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDGDataGridViewTextBoxColumn,
            this.tenDGDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dgv_DocGia.DataSource = this.docGiaBindingSource;
            this.dgv_DocGia.Location = new System.Drawing.Point(6, 4);
            this.dgv_DocGia.Name = "dgv_DocGia";
            this.dgv_DocGia.ReadOnly = true;
            this.dgv_DocGia.RowHeadersWidth = 51;
            this.dgv_DocGia.RowTemplate.Height = 24;
            this.dgv_DocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DocGia.Size = new System.Drawing.Size(747, 414);
            this.dgv_DocGia.TabIndex = 174;
            this.dgv_DocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DocGia_CellContentClick);
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
            // tenDGDataGridViewTextBoxColumn
            // 
            this.tenDGDataGridViewTextBoxColumn.DataPropertyName = "TenDG";
            this.tenDGDataGridViewTextBoxColumn.HeaderText = "TenDG";
            this.tenDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDGDataGridViewTextBoxColumn.Name = "tenDGDataGridViewTextBoxColumn";
            this.tenDGDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTaoDataGridViewTextBoxColumn.Width = 125;
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
            // docGiaBindingSource
            // 
            this.docGiaBindingSource.DataMember = "DocGia";
            this.docGiaBindingSource.DataSource = this.qL_ThuVienDataSet3;
            // 
            // qL_ThuVienDataSet3
            // 
            this.qL_ThuVienDataSet3.DataSetName = "QL_ThuVienDataSet3";
            this.qL_ThuVienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_NgayTao
            // 
            this.lbl_NgayTao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NgayTao.AutoSize = true;
            this.lbl_NgayTao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTao.Location = new System.Drawing.Point(18, 403);
            this.lbl_NgayTao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NgayTao.Name = "lbl_NgayTao";
            this.lbl_NgayTao.Size = new System.Drawing.Size(70, 17);
            this.lbl_NgayTao.TabIndex = 175;
            this.lbl_NgayTao.Text = "Ngày Tạo";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrangThai.Location = new System.Drawing.Point(70, 513);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.ReadOnly = true;
            this.txt_TrangThai.Size = new System.Drawing.Size(170, 24);
            this.txt_TrangThai.TabIndex = 178;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(20, 482);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(79, 17);
            this.lbl_TrangThai.TabIndex = 177;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // dtp_NgayTao
            // 
            this.dtp_NgayTao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NgayTao.CustomFormat = "";
            this.dtp_NgayTao.Enabled = false;
            this.dtp_NgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTao.Location = new System.Drawing.Point(70, 438);
            this.dtp_NgayTao.Name = "dtp_NgayTao";
            this.dtp_NgayTao.Size = new System.Drawing.Size(170, 24);
            this.dtp_NgayTao.TabIndex = 179;
            this.dtp_NgayTao.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // docGiaTableAdapter
            // 
            this.docGiaTableAdapter.ClearBeforeFill = true;
            // 
            // grp_ThongTIn
            // 
            this.grp_ThongTIn.Controls.Add(this.txt_TrangThai);
            this.grp_ThongTIn.Controls.Add(this.dtp_NgayTao);
            this.grp_ThongTIn.Controls.Add(this.lbl_NgayTao);
            this.grp_ThongTIn.Controls.Add(this.lbl_MaDocGia);
            this.grp_ThongTIn.Controls.Add(this.lbl_TenDocGia);
            this.grp_ThongTIn.Controls.Add(this.lbl_TrangThai);
            this.grp_ThongTIn.Controls.Add(this.txt_TenDocGia);
            this.grp_ThongTIn.Controls.Add(this.lbl_DiaChi);
            this.grp_ThongTIn.Controls.Add(this.txt_Email);
            this.grp_ThongTIn.Controls.Add(this.txt_DiaChi);
            this.grp_ThongTIn.Controls.Add(this.lbl_Email);
            this.grp_ThongTIn.Controls.Add(this.txt_MaDocGia);
            this.grp_ThongTIn.Controls.Add(this.txt_SDT);
            this.grp_ThongTIn.Controls.Add(this.lbl_SDT);
            this.grp_ThongTIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTIn.Location = new System.Drawing.Point(931, 93);
            this.grp_ThongTIn.Name = "grp_ThongTIn";
            this.grp_ThongTIn.Size = new System.Drawing.Size(330, 561);
            this.grp_ThongTIn.TabIndex = 180;
            this.grp_ThongTIn.TabStop = false;
            this.grp_ThongTIn.Text = "Thông tin";
            // 
            // grp_DuLieu
            // 
            this.grp_DuLieu.BackgroundImage = global::GUI.Properties.Resources.bgc;
            this.grp_DuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_DuLieu.Controls.Add(this.dgv_DocGia);
            this.grp_DuLieu.Location = new System.Drawing.Point(48, 116);
            this.grp_DuLieu.Name = "grp_DuLieu";
            this.grp_DuLieu.Size = new System.Drawing.Size(759, 424);
            this.grp_DuLieu.TabIndex = 181;
            this.grp_DuLieu.TabStop = false;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe.Location = new System.Drawing.Point(40, 31);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(130, 44);
            this.lbl_TieuDe.TabIndex = 218;
            this.lbl_TieuDe.Text = "Độc Giả";
            // 
            // Form_QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::GUI.Properties.Resources.pixil_frame_0__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.grp_DuLieu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grp_ThongTIn);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.lbl_Tim);
            this.Controls.Add(this.txt_TimKiem);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form_QuanLyDocGia";
            this.Text = "Form_QuanLyDocGia";
            this.Load += new System.EventHandler(this.Form_QuanLyDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet3)).EndInit();
            this.grp_ThongTIn.ResumeLayout(false);
            this.grp_ThongTIn.PerformLayout();
            this.grp_DuLieu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_MaDocGia;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_TenDocGia;
        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TenDocGia;
        private System.Windows.Forms.Label lbl_MaDocGia;
        private System.Windows.Forms.DataGridView dgv_DocGia;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.Label lbl_NgayTao;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.DateTimePicker dtp_NgayTao;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private QL_ThuVienDataSet3 qL_ThuVienDataSet3;
        private System.Windows.Forms.BindingSource docGiaBindingSource;
        private QL_ThuVienDataSet3TableAdapters.DocGiaTableAdapter docGiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grp_ThongTIn;
        private System.Windows.Forms.GroupBox grp_DuLieu;
        private System.Windows.Forms.Label lbl_TieuDe;
    }
}