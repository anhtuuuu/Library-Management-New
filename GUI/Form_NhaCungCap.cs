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
    public partial class Form_NhaCungCap : Form
    {
        NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }

        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet5.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.qL_ThuVienDataSet5.NhaCungCap);

        }
        private void Refresh()
        {
            txt_MaNCC.Text = string.Empty;
            txt_TenNCC.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_SDT.Text = string.Empty;
            txt_TrangThai.Text = string.Empty;
            txt_TimKiem.Text = string.Empty;
        }

        private void OpenText()
        {
            txt_TenNCC.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_SDT.ReadOnly = false;
        }

        private void CloseText()
        {
            txt_TenNCC.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
            txt_SDT.ReadOnly = true;
            btn_CapNhat.Enabled = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_CapNhat.Enabled = false;
            CloseText();
            Refresh();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Sua.Enabled = true;
            Refresh();
            OpenText();
            btn_CapNhat.Enabled = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa.");
                return;
            }
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            OpenText();
            btn_CapNhat.Enabled = true;
        }

        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dgv_NhaCungCap.Rows[index];
            txt_MaNCC.Text = data.Cells[0].Value.ToString();
            txt_TenNCC.Text = data.Cells[1].Value.ToString();
            txt_DiaChi.Text = data.Cells[2].Value.ToString();
            txt_SDT.Text = data.Cells[3].Value.ToString();
            txt_TrangThai.Text = (data.Cells[4].Value.ToString() == "1" ? "Hoạt động" : "Đã xóa");

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.");
                return;
            }
            NhaCungCap nhaCungCap = new NhaCungCap()
            {
                MaNCC = txt_MaNCC.Text
            };
            DialogResult dlg;
            dlg = MessageBox.Show("Bạn có chắc muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                string result = nhaCungCapBLL.XoaNhaCungCap(nhaCungCap);
                switch (result)
                {
                    case "Successful_Change":
                        MessageBox.Show("Đã xóa nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_NhaCungCap_Load(sender, e);
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
                int count = nhaCungCapBLL.GetListNhaCungCap().Count + 1;
                string next_id = "";
                if (count < 10)
                {
                    next_id = "NCC00" + count.ToString();
                }
                else if (count >= 10 && count < 100)
                {
                    next_id = "NCC0" + count.ToString();
                }
                else
                {
                    next_id = "NCC" + count.ToString();
                }

                NhaCungCap nhaCungCap = new NhaCungCap()
                {
                    MaNCC = next_id,
                    TenNCC = txt_TenNCC.Text,
                    DiaChi = txt_DiaChi.Text,
                    Sdt = txt_SDT.Text
                };
                string result = nhaCungCapBLL.ThemNhaCungCap(nhaCungCap);

                switch (result)
                {
                    case "Required_Name":
                        MessageBox.Show("Vui lòng nhập tên nhà cung cấp.");
                        return;
                    case "Wrong_Format_Name":
                        MessageBox.Show("Tên nhà cung cấp không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Required_Address":
                        MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp.");
                        return;
                    case "Wrong_Format_Address":
                        MessageBox.Show("Địa chỉ nhà cung cấp không hợp lệ. Chỉ bao gồm chữ, số và ký tự '/' và ','");
                        return;
                    case "Required_Phone":
                        MessageBox.Show("Vui lòng nhập số điện thoại nhà cung cấp.");
                        return;
                    case "Wrong_Format_PhoneNumber":
                        MessageBox.Show("Số điện thoại nhà cung cấp không hợp lệ. Chỉ bao gồm số và tối đa 10 số.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Thêm thành công.");
                        Form_NhaCungCap_Load(sender, e);
                        btn_LamMoi_Click(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
            if (btn_Sua.Enabled == false)
            {

                NhaCungCap nhaCungCap = new NhaCungCap()
                {
                    MaNCC = txt_MaNCC.Text,
                    TenNCC = txt_TenNCC.Text.Trim(),
                    DiaChi = txt_DiaChi.Text.Trim(),
                    Sdt = txt_SDT.Text.Trim()
                };

                string result = nhaCungCapBLL.SuaNhaCungCap(nhaCungCap);

                switch (result)
                {
                    case "Required_Name":
                        MessageBox.Show("Vui lòng nhập tên nhà cung cấp.");
                        return;
                    case "Wrong_Format_Name":
                        MessageBox.Show("Tên nhà cung cấp không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Required_Address":
                        MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp.");
                        return;
                    case "Wrong_Format_Address":
                        MessageBox.Show("Địa chỉ nhà cung cấp không hợp lệ. Chỉ bao gồm chữ, số và ký tự '/' và ','");
                        return;
                    case "Required_Phone":
                        MessageBox.Show("Vui lòng nhập số điện thoại nhà cung cấp.");
                        return;
                    case "Wrong_Format_PhoneNumber":
                        MessageBox.Show("Số điện thoại nhà cung cấp không hợp lệ. Chỉ bao gồm số và tối đa 10 số.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Sửa thành công.");
                        Form_NhaCungCap_Load(sender, e);
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
            dgv_NhaCungCap.DataSource = nhaCungCapBLL.SearchNCC(keyWord).Tables[0];
        }
    }
}
