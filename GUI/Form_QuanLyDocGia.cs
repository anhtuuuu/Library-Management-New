using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_QuanLyDocGia : Form
    {
        DocGiaBLL docGiaBLL = new DocGiaBLL();
        public Form_QuanLyDocGia()
        {
            InitializeComponent();
        }

        private void Form_QuanLyDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet3.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.qL_ThuVienDataSet3.DocGia);
            // TODO: This line of code loads data into the 'library_managementDataSet5.DocGia' table. You can move, or remove it, as needed.
            //this.docGiaTableAdapter.Fill(this.library_managementDataSet5.DocGia);            
        }

        private void dgv_DocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dgv_DocGia.Rows[index];
            txt_MaDocGia.Text = data.Cells[0].Value.ToString();
            txt_TenDocGia.Text = data.Cells[1].Value.ToString();
            txt_DiaChi.Text = data.Cells[2].Value.ToString();
            txt_Email.Text = data.Cells[3].Value.ToString();
            txt_SDT.Text = data.Cells[4].Value.ToString();
            dtp_NgayTao.Text = data.Cells[5].Value.ToString();
            txt_TrangThai.Text = (data.Cells[6].Value.ToString() == "1" ? "Hoạt động" : "Đã xóa");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refresh()
        {                       
            txt_MaDocGia.Text = string.Empty;
            txt_TenDocGia.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_SDT.Text = string.Empty;
            dtp_NgayTao.Text = DateTime.Now.ToString();
            txt_TrangThai.Text = string.Empty;
            txt_TimKiem.Text = string.Empty;
        }

        private void OpenText()
        {
            txt_TenDocGia.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_Email.ReadOnly = false;
            txt_SDT.ReadOnly = false;
            dtp_NgayTao.Enabled = true;
        }

        private void CloseText()
        {
            txt_TenDocGia.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_SDT.ReadOnly = true;
            txt_TrangThai.ReadOnly = true;
            dtp_NgayTao.Enabled = false;

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_CapNhat.Enabled = false;
            CloseText();
            Refresh();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Sua.Enabled = true;
            Refresh();
            OpenText();
            btn_CapNhat.Enabled = true;
            dtp_NgayTao.Text = DateTime.Now.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa.");
                return;
            }
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            OpenText();
            btn_CapNhat.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa.");
                return;
            }
            DocGia docGia = new DocGia()
            {
                MaDG = txt_MaDocGia.Text
            };
            DialogResult dlg;
            dlg = MessageBox.Show("Bạn có chắc muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                string result = docGiaBLL.XoaDocGia(docGia);
                switch (result)
                {
                    case "Successful_Change":
                        MessageBox.Show("Đã xóa loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_QuanLyDocGia_Load(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == false)
            {
                int count = docGiaBLL.GetListDocGia().Count + 1;
                string next_id = "";
                if (count < 10)
                {
                    next_id = "DG00" + count.ToString();
                }
                else if (count >= 10 && count < 100)
                {
                    next_id = "DG0" + count.ToString();
                }
                else
                {
                    next_id = "DG" + count.ToString();
                }
                DocGia docGia = new DocGia()
                {
                    MaDG = next_id,
                    TenDG = txt_TenDocGia.Text,
                    DiaChi = txt_DiaChi.Text,
                    Email = txt_Email.Text,
                    Sdt = txt_SDT.Text,
                    NgayTao = dtp_NgayTao.Value.ToString("yyyy/MM/dd")
                };
                string result = docGiaBLL.ThemDocGia(docGia);

                switch (result)
                {
                    case "Required_Name":
                        MessageBox.Show("Vui lòng nhập tên độc giả.");
                        return;
                    case "Wrong_Format_Name":
                        MessageBox.Show("Tên độc giả không hợp lệ. Không chứ ký tự đặc biệt.");
                        return;
                    case "Required_Address":
                        MessageBox.Show("Vui lòng nhập địa chỉ của độc giả.");
                        return;
                    case "Wrong_Format_Address":
                        MessageBox.Show("Địa chỉ không hợp lệ. Chỉ chứa chữ, số, ký tự '/' và ','");
                        return;
                    case "Required_Email":
                        MessageBox.Show("Vui lòng nhập email của độc giả.");
                        return;
                    case "Required_Phone":
                        MessageBox.Show("Vui lòng nhập sđt của độc giả.");
                        return;
                    case "Wrong_Format_PhoneNumber":
                        MessageBox.Show("Số điện thoại không hợp lệ. Chỉ chứa số và tối đa 10 số.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Thêm thành công.");
                        Form_QuanLyDocGia_Load(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
            if (btn_Sua.Enabled == false)
            {                
                DocGia docGia = new DocGia()
                {
                    MaDG = txt_MaDocGia.Text,
                    TenDG = txt_TenDocGia.Text,
                    DiaChi = txt_DiaChi.Text,
                    Email = txt_Email.Text,
                    Sdt = txt_SDT.Text,
                    NgayTao = dtp_NgayTao.Value.ToString("yyyy/MM/dd")
                };

                string result = docGiaBLL.SuaDocGia(docGia);

                switch (result)
                {
                    case "Required_Name":
                        MessageBox.Show("Vui lòng nhập tên độc giả.");
                        return;
                    case "Wrong_Format_Name":
                        MessageBox.Show("Tên độc giả không hợp lệ. Không chứ ký tự đặc biệt.");
                        return;
                    case "Required_Address":
                        MessageBox.Show("Vui lòng nhập địa chỉ của độc giả.");
                        return;
                    case "Wrong_Format_Address":
                        MessageBox.Show("Địa chỉ không hợp lệ. Chỉ chứa chữ, số, ký tự '/' và ','");
                        return;
                    case "Required_Email":
                        MessageBox.Show("Vui lòng nhập email của độc giả.");
                        return;
                    case "Required_Phone":
                        MessageBox.Show("Vui lòng nhập sđt của độc giả.");
                        return;
                    case "Wrong_Format_PhoneNumber":
                        MessageBox.Show("Số điện thoại không hợp lệ. Chỉ chứa số và tối đa 10 số.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Sửa thông tin thành công.");
                        Form_QuanLyDocGia_Load(sender, e);
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
            dgv_DocGia.DataSource = docGiaBLL.SearchDocGia(keyWord).Tables[0];
        }
    }
}
