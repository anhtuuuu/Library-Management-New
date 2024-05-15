namespace GUI
{
    partial class Form_LoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LoaiSach));
            this.txt_TenLoaiSach = new System.Windows.Forms.TextBox();
            this.lbl_TenLoaiSach = new System.Windows.Forms.Label();
            this.lbl_MaLoaiSach = new System.Windows.Forms.Label();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txt_MaLoaiSach = new System.Windows.Forms.TextBox();
            this.dgv_LoaiSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_ThuVienDataSet2 = new GUI.QL_ThuVienDataSet2();
            this.loaiSachTableAdapter = new GUI.QL_ThuVienDataSet2TableAdapters.LoaiSachTableAdapter();
            this.grp_DuLieu = new System.Windows.Forms.GroupBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.grp_ThongTin = new System.Windows.Forms.GroupBox();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet2)).BeginInit();
            this.grp_DuLieu.SuspendLayout();
            this.grp_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TenLoaiSach
            // 
            this.txt_TenLoaiSach.Location = new System.Drawing.Point(43, 160);
            this.txt_TenLoaiSach.MaxLength = 250;
            this.txt_TenLoaiSach.Name = "txt_TenLoaiSach";
            this.txt_TenLoaiSach.ReadOnly = true;
            this.txt_TenLoaiSach.Size = new System.Drawing.Size(177, 27);
            this.txt_TenLoaiSach.TabIndex = 193;
            // 
            // lbl_TenLoaiSach
            // 
            this.lbl_TenLoaiSach.AutoSize = true;
            this.lbl_TenLoaiSach.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenLoaiSach.Location = new System.Drawing.Point(4, 128);
            this.lbl_TenLoaiSach.Name = "lbl_TenLoaiSach";
            this.lbl_TenLoaiSach.Size = new System.Drawing.Size(107, 16);
            this.lbl_TenLoaiSach.TabIndex = 192;
            this.lbl_TenLoaiSach.Text = "Tên Loại Sách";
            // 
            // lbl_MaLoaiSach
            // 
            this.lbl_MaLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaLoaiSach.AutoSize = true;
            this.lbl_MaLoaiSach.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLoaiSach.Location = new System.Drawing.Point(10, 53);
            this.lbl_MaLoaiSach.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaLoaiSach.Name = "lbl_MaLoaiSach";
            this.lbl_MaLoaiSach.Size = new System.Drawing.Size(101, 16);
            this.lbl_MaLoaiSach.TabIndex = 190;
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
            this.lbl_Tim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Tim.Location = new System.Drawing.Point(31, 547);
            this.lbl_Tim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(91, 20);
            this.lbl_Tim.TabIndex = 195;
            this.lbl_Tim.Text = "Tìm kiếm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_TimKiem.Location = new System.Drawing.Point(132, 547);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(237, 22);
            this.txt_TimKiem.TabIndex = 194;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
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
            this.btn_Xoa.Location = new System.Drawing.Point(813, 231);
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
            this.btn_Them.Location = new System.Drawing.Point(813, 136);
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
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sua.ImageIndex = 5;
            this.btn_Sua.ImageList = this.imgHinhAnh;
            this.btn_Sua.Location = new System.Drawing.Point(813, 328);
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
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamMoi.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LamMoi.ImageIndex = 1;
            this.btn_LamMoi.ImageList = this.imgHinhAnh;
            this.btn_LamMoi.Location = new System.Drawing.Point(813, 424);
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
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CapNhat.BackgroundImage = global::GUI.Properties.Resources.bg;
            this.btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CapNhat.Location = new System.Drawing.Point(387, 573);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(204, 70);
            this.btn_CapNhat.TabIndex = 198;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_MaLoaiSach
            // 
            this.txt_MaLoaiSach.Location = new System.Drawing.Point(43, 87);
            this.txt_MaLoaiSach.Name = "txt_MaLoaiSach";
            this.txt_MaLoaiSach.ReadOnly = true;
            this.txt_MaLoaiSach.Size = new System.Drawing.Size(177, 27);
            this.txt_MaLoaiSach.TabIndex = 199;
            // 
            // dgv_LoaiSach
            // 
            this.dgv_LoaiSach.AutoGenerateColumns = false;
            this.dgv_LoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_LoaiSach.DataSource = this.loaiSachBindingSource;
            this.dgv_LoaiSach.Location = new System.Drawing.Point(5, 5);
            this.dgv_LoaiSach.Name = "dgv_LoaiSach";
            this.dgv_LoaiSach.ReadOnly = true;
            this.dgv_LoaiSach.RowHeadersWidth = 51;
            this.dgv_LoaiSach.RowTemplate.Height = 24;
            this.dgv_LoaiSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiSach.Size = new System.Drawing.Size(748, 413);
            this.dgv_LoaiSach.TabIndex = 200;
            this.dgv_LoaiSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiSach_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLoaiSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaLoaiSach";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLoaiSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenLoaiSach";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn3.HeaderText = "TrangThai";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // loaiSachBindingSource
            // 
            this.loaiSachBindingSource.DataMember = "LoaiSach";
            this.loaiSachBindingSource.DataSource = this.qL_ThuVienDataSet2;
            // 
            // qL_ThuVienDataSet2
            // 
            this.qL_ThuVienDataSet2.DataSetName = "QL_ThuVienDataSet2";
            this.qL_ThuVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiSachTableAdapter
            // 
            this.loaiSachTableAdapter.ClearBeforeFill = true;
            // 
            // grp_DuLieu
            // 
            this.grp_DuLieu.BackgroundImage = global::GUI.Properties.Resources.bg;
            this.grp_DuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_DuLieu.Controls.Add(this.dgv_LoaiSach);
            this.grp_DuLieu.Location = new System.Drawing.Point(34, 104);
            this.grp_DuLieu.Name = "grp_DuLieu";
            this.grp_DuLieu.Size = new System.Drawing.Size(759, 424);
            this.grp_DuLieu.TabIndex = 201;
            this.grp_DuLieu.TabStop = false;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(43, 245);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(177, 27);
            this.txt_Status.TabIndex = 203;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(10, 206);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(83, 16);
            this.lbl_Status.TabIndex = 202;
            this.lbl_Status.Text = "Trạng Thái";
            // 
            // grp_ThongTin
            // 
            this.grp_ThongTin.Controls.Add(this.txt_Status);
            this.grp_ThongTin.Controls.Add(this.lbl_MaLoaiSach);
            this.grp_ThongTin.Controls.Add(this.lbl_Status);
            this.grp_ThongTin.Controls.Add(this.lbl_TenLoaiSach);
            this.grp_ThongTin.Controls.Add(this.txt_TenLoaiSach);
            this.grp_ThongTin.Controls.Add(this.txt_MaLoaiSach);
            this.grp_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTin.Location = new System.Drawing.Point(938, 94);
            this.grp_ThongTin.Name = "grp_ThongTin";
            this.grp_ThongTin.Size = new System.Drawing.Size(314, 549);
            this.grp_ThongTin.TabIndex = 204;
            this.grp_ThongTin.TabStop = false;
            this.grp_ThongTin.Text = "Thông tin";
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.ForeColor = System.Drawing.Color.White;
            this.lbl_TieuDe.Location = new System.Drawing.Point(31, 27);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(142, 44);
            this.lbl_TieuDe.TabIndex = 204;
            this.lbl_TieuDe.Text = "Loại Sách";
            // 
            // Form_LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::GUI.Properties.Resources.pixil_frame_0__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 666);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.grp_ThongTin);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.lbl_Tim);
            this.Controls.Add(this.grp_DuLieu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_LamMoi);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1291, 713);
            this.MinimumSize = new System.Drawing.Size(1291, 713);
            this.Name = "Form_LoaiSach";
            this.Text = "Form_LoaiSach";
            this.Load += new System.EventHandler(this.Form_LoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet2)).EndInit();
            this.grp_DuLieu.ResumeLayout(false);
            this.grp_ThongTin.ResumeLayout(false);
            this.grp_ThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TenLoaiSach;
        private System.Windows.Forms.Label lbl_TenLoaiSach;
        private System.Windows.Forms.Label lbl_MaLoaiSach;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_MaLoaiSach;
        private System.Windows.Forms.DataGridView dgv_LoaiSach;
        //private QL_ThuVienDataSet5 qL_ThuVienDataSet5;
        //private System.Windows.Forms.BindingSource loaiSachBindingSource;
        //private QL_ThuVienDataSet5TableAdapters.LoaiSachTableAdapter loaiSachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.Label lbl_TrangThai;
        private QL_ThuVienDataSet2 qL_ThuVienDataSet2;
        private System.Windows.Forms.BindingSource loaiSachBindingSource;
        private QL_ThuVienDataSet2TableAdapters.LoaiSachTableAdapter loaiSachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox grp_DuLieu;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox grp_ThongTin;
        private System.Windows.Forms.Label lbl_TieuDe;
        //private Library_managementDataSet3 library_managementDataSet3;
        //private System.Windows.Forms.BindingSource loaiSachBindingSource1;
        //private Library_managementDataSet3TableAdapters.LoaiSachTableAdapter loaiSachTableAdapter1;
    }
}