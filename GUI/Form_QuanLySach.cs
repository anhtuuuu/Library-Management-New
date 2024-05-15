using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_QuanLySach : Form
    {
        private SachBLL sachBLL = new SachBLL();
        public Form_QuanLySach()
        {
            InitializeComponent();
        }

        private void Form_QuanLySach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet7.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter2.Fill(this.qL_ThuVienDataSet7.Sach);
                      


            DataSet ls = sachBLL.GetLoaiSach();
            for (int i = 0; i < ls.Tables[0].Rows.Count; i++)
                cbo_MaLoaiSach.Items.Add(ls.Tables[0].Rows[i][0].ToString());
            DataSet ncc = sachBLL.GetNhaCungCap();
            for (int i = 0; i < ncc.Tables[0].Rows.Count; i++)
                cbo_MaNCC.Items.Add(ncc.Tables[0].Rows[i][0].ToString());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refresh()
        {
            txt_MaSach.Text = string.Empty;
            cbo_MaLoaiSach.Text = string.Empty;
            cbo_MaNCC.Text = string.Empty;
            txt_TenSach.Text = string.Empty;
            txt_GiaNhap.Text = string.Empty;
            txt_GiaChoThue.Text = string.Empty;
            txt_XuatXu.Text = string.Empty;
            txt_TacGia.Text = string.Empty;
            cbo_DonViTinh.Text = string.Empty;
            txt_SoLuong.Text = string.Empty;
            cbo_TrangThai.Text = string.Empty;
            pic_HinhAnh.Image = null;
            txt_ChonAnh.Text = string.Empty;
            btn_ChonAnh.Enabled = false;
        }

        private void OpenText()
        {
            cbo_MaLoaiSach.Enabled = true;
            cbo_MaNCC.Enabled = true;
            txt_TenSach.ReadOnly = false;
            txt_GiaNhap.ReadOnly = false;
            txt_GiaChoThue.ReadOnly = false;
            txt_XuatXu.ReadOnly = false;
            txt_TacGia.ReadOnly = false;
            cbo_DonViTinh.Enabled = true;
            txt_SoLuong.ReadOnly = false;
        }

        private void CloseText()
        {
            cbo_MaLoaiSach.Enabled = false;
            cbo_MaNCC.Enabled = false;
            txt_TenSach.ReadOnly = true;
            txt_GiaNhap.ReadOnly = true;
            txt_GiaChoThue.ReadOnly = true;
            txt_XuatXu.ReadOnly = true;
            txt_TacGia.ReadOnly = true;
            cbo_DonViTinh.Enabled = false;
            txt_SoLuong.ReadOnly = true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;         
            btn_Sua.Enabled = true;
            btn_CapNhat.Enabled = true;
            Refresh();
            btn_ChonAnh.Enabled = true;
            cbo_TrangThai.Enabled = false;
            OpenText();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;         
            btn_Sua.Enabled = true;
            btn_CapNhat.Enabled = false;
            CloseText();
            Refresh();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_MaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            Sach sach = new Sach() 
            {
                MaSach = txt_MaSach.Text
            };

            DialogResult dlg;
            dlg = MessageBox.Show("Bạn có chắc muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dlg == DialogResult.Yes)
            {
                string result = sachBLL.XoaSach(sach);
                switch (result)
                {
                    case "Successful_Change":
                        MessageBox.Show("Đã xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_QuanLySach_Load(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(txt_MaSach.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                return;
            }
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            btn_CapNhat.Enabled = true;
            OpenText();
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG files (*.jpg) | *.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_HinhAnh.ImageLocation = openFileDialog.FileName;
                txt_ChonAnh.Text = openFileDialog.FileName;
            }
        }

        private void dgv_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dgv_Sach.Rows[index];
            txt_MaSach.Text = data.Cells[0].Value.ToString();
            cbo_MaLoaiSach.Text = data.Cells[1].Value.ToString();
            txt_TenSach.Text = data.Cells[2].Value.ToString();
            txt_XuatXu.Text = data.Cells[3].Value.ToString();
            txt_TacGia.Text = data.Cells[4].Value.ToString();
            txt_GiaNhap.Text = data.Cells[5].Value.ToString();
            txt_GiaChoThue.Text = data.Cells[6].Value.ToString();
            cbo_DonViTinh.Text = data.Cells[7].Value.ToString();
            cbo_MaNCC.Text = data.Cells[8].Value.ToString();
            txt_SoLuong.Text = data.Cells[9].Value.ToString();
            cbo_TrangThai.Text = (data.Cells[10].Value.ToString() == "1"? "Còn Hàng":"Hết Hàng");
            pic_HinhAnh.Image = imgSach.Images[data.Cells[11].Value.ToString()];
        }

        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txt_ChonAnh.Text, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return data;
        }

        
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            int checkLS = sachBLL.GetLoaiSachWithID(cbo_MaLoaiSach.Text).Tables[0].Rows.Count;
            if(checkLS == 0)
            {
                MessageBox.Show("Mã loại sách không tồn tại hoặc đã xóa.");
                return;
            }
            int checkNCC = sachBLL.GetNhaCungCapWithID(cbo_MaNCC.Text).Tables[0].Rows.Count;
            if (checkNCC == 0)
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại hoặc đã xóa.");
                return;
            }
            if (btn_Them.Enabled == false)
            {
                
                int count  = sachBLL.GetListSach().Count + 1;
                string next_id = "";
                if (count < 10)
                {
                    next_id = "S00" + count.ToString();
                }
                else if(count >= 10 && count < 100)
                {
                    next_id = "S0" + count.ToString();
                }
                else
                {
                    next_id = "S" + count.ToString();
                }
                Sach sach = new Sach()
                { 
                    MaSach = next_id,
                    MaLoaiSach = cbo_MaLoaiSach.Text,
                    MaNhaCungCap = cbo_MaNCC.Text,
                    TenSach = txt_TenSach.Text,
                    XuatXu = txt_XuatXu.Text,
                    TacGia = txt_TacGia.Text,
                    GiaNhap = (txt_GiaNhap.Text.Trim() == "" ? 0 : Decimal.Parse(txt_GiaNhap.Text)),
                    GiaChoThue = (txt_GiaChoThue.Text.Trim() == "" ? 0 : Decimal.Parse(txt_GiaChoThue.Text)),
                    DonViTinh = cbo_DonViTinh.Text,
                    SoLuong = (txt_SoLuong.Text.Trim() == "" ? 0 : int.Parse(txt_SoLuong.Text)),
                    TrangThai = 1,
                    HinhAnh = ""
                };
                string result = sachBLL.ThemSach(sach);

                switch(result)
                {
                    case "Required_MLS":
                        MessageBox.Show("Vui lòng chọn mã loại sách.");
                        return;
                    case "Required_MNCC":
                        MessageBox.Show("Vui lòng chọn mã nhà cung cấp.");
                        return;
                    case "Wrong_Format_From":
                        MessageBox.Show("Xuất xứ không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Wrong_Format_NameBook":
                        MessageBox.Show("Tên sách không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Wrong_Format_InPrice":
                        MessageBox.Show("Giá nhập không hợp lệ. Chỉ bao gồm chữ số.");
                        return;
                    case "Wrong_Format_OutPrice":
                        MessageBox.Show("Giá cho thuê không hợp lệ. Chỉ bao gồm chữ số.");
                        return;
                    case "Wrong_Format_NameAuthor":
                        MessageBox.Show("Tên tác giả không hợp lệ. Chỉ gồm chữ, số và ký tự '.'");
                        return;
                    case "Wrong_Format_Number":
                        MessageBox.Show("Số lượng không hợp lệ. Chỉ bao gồm chữ số.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Thêm thành công.");
                        Form_QuanLySach_Load(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
            if(btn_Sua.Enabled == false)
            {
                if (!sachBLL.kiemTraSo(txt_GiaNhap.Text))
                {
                    MessageBox.Show("Giá nhập không hợp lệ. Chỉ bao gồm chữ số.");
                    return;
                }
                if (!sachBLL.kiemTraSo(txt_GiaChoThue.Text))
                {
                    MessageBox.Show("Giá cho thuê không hợp lệ. Chỉ bao gồm chữ số.");
                    return;
                }
                if (!sachBLL.kiemTraSo(txt_SoLuong.Text))
                {
                    MessageBox.Show("Số lượng không hợp lệ. Chỉ bao gồm chữ số.");
                    return;
                }

                Sach sach = new Sach()
                {
                    MaSach = txt_MaSach.Text,
                    MaLoaiSach = cbo_MaLoaiSach.Text,
                    MaNhaCungCap = cbo_MaNCC.Text,
                    TenSach = txt_TenSach.Text,
                    XuatXu = txt_XuatXu.Text,
                    TacGia = txt_TacGia.Text,
                    GiaNhap = int.Parse(txt_GiaNhap.Text),
                    GiaChoThue = int.Parse(txt_GiaChoThue.Text),
                    DonViTinh = cbo_DonViTinh.Text,
                    SoLuong = int.Parse(txt_SoLuong.Text),
                    TrangThai = (cbo_TrangThai.Text == "Còn Hàng"?1:0),
                };

                string result  = sachBLL.SuaSach(sach);
                switch (result)
                {
                    case "Required_MLS":
                        MessageBox.Show("Vui lòng chọn mã loại sách.");
                        return;
                    case "Required_MNCC":
                        MessageBox.Show("Vui lòng chọn mã nhà cung cấp.");
                        return;
                    case "Wrong_Format_From":
                        MessageBox.Show("Xuất xứ không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Wrong_Format_NameBook":
                        MessageBox.Show("Tên sách không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Wrong_Format_InPrice":
                        MessageBox.Show("Giá nhập không hợp lệ. Chỉ bao gồm chữ số.");
                        return;
                    case "Wrong_Format_OutPrice":
                        MessageBox.Show("Giá cho thuê không hợp lệ. Chỉ bao gồm chữ số.");
                        return;
                    case "Wrong_Format_NameAuthor":
                        MessageBox.Show("Tên tác giả không hợp lệ. Chỉ gồm chữ, số và ký tự '.'");
                        return;
                    case "Wrong_Format_Number":
                        MessageBox.Show("Số lượng không hợp lệ. Chỉ bao gồm chữ số.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Cập nhật thành công.");
                        Form_QuanLySach_Load(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txt_TimKiem.Text;
            dgv_Sach.DataSource = sachBLL.SearchSach(keyWord).Tables[0];
        }
        private void add_Image_To_ImageList()
        {
            string location = txt_ChonAnh.Text.Trim();
            //Image hinhSach = Image.FromFile(@location);
            //string[] partLocation = location.Split(char.Parse(@"\"));
            //string tenHinh = partLocation[partLocation.Length - 1];
            //MessageBox.Show(hinhSach.Width.ToString() +"-" + hinhSach.Height.ToString());
            try
            {
                imgSach.Images.Add(Image.FromFile(@location));
                MessageBox.Show("Them thanh cong");
            }
            catch
            {
                MessageBox.Show("Them khong thanh cong");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            add_Image_To_ImageList();
            MessageBox.Show( "Width: " +imgSach.Images[0].Width.ToString() + " - Height: " + imgSach.Images[0].Height.ToString());
        }
    }
}
