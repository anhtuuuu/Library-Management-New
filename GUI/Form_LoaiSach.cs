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
    public partial class Form_LoaiSach : Form
    {
        LoaiSachBLL loaiSachBLL = new LoaiSachBLL();
        public Form_LoaiSach()
        {
            InitializeComponent();
        }

        private void Form_LoaiSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet2.LoaiSach' table. You can move, or remove it, as needed.
            this.loaiSachTableAdapter.Fill(this.qL_ThuVienDataSet2.LoaiSach);
            // TODO: This line of code loads data into the 'library_managementDataSet3.LoaiSach' table. You can move, or remove it, as needed.
            //this.loaiSachTableAdapter1.Fill(this.library_managementDataSet3.LoaiSach);
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet5.LoaiSach' table. You can move, or remove it, as needed.
            //this.loaiSachTableAdapter.Fill(this.qL_ThuVienDataSet5.LoaiSach);


        }


        private void dgv_LoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dgv_LoaiSach.Rows[index];
            txt_MaLoaiSach.Text = data.Cells[0].Value.ToString();
            txt_TenLoaiSach.Text = data.Cells[1].Value.ToString();
            txt_Status.Text = (data.Cells[2].Value.ToString() == "1"?"Hoạt động":"Đã xóa");
        }

      

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refresh()
        {
            txt_MaLoaiSach.Text = string.Empty;
            txt_TenLoaiSach.Text = string.Empty;
            txt_Status.Text = string.Empty;  
            txt_TimKiem.Text = string.Empty;
        }

        private void OpenText()
        {
            txt_TenLoaiSach.ReadOnly = false;
        }

        private void CloseText()
        {
            txt_TenLoaiSach.ReadOnly=true;
            btn_CapNhat.Enabled = false;
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
            if (txt_MaLoaiSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại sách cần sửa.");
                return;
            }
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            OpenText();
            btn_CapNhat.Enabled = true;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_CapNhat.Enabled = false;
            CloseText();
            Refresh();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if(btn_Them.Enabled == false)
            {
                int count = loaiSachBLL.GetListLoaiSach().Count + 1;
                string next_id = "";
                if (count < 10)
                {
                    next_id = "LS00" + count.ToString();
                }
                else if (count >= 10 && count < 100)
                {
                    next_id = "LS0" + count.ToString();
                }
                else
                {
                    next_id = "LS" + count.ToString();
                }

                LoaiSach loaiSach = new LoaiSach()
                { 
                    MaLoaiSach = next_id,
                    TenLoaiSach = txt_TenLoaiSach.Text
                };
                string result = loaiSachBLL.ThemLoaiSach(loaiSach);

                switch (result)
                {
                    case "Required_Name":
                        MessageBox.Show("Vui lòng nhập tên loại sách.");
                        return;
                    case "Wrong_Format_Name":
                        MessageBox.Show("Tên loại sách không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Thêm thành công.");
                        Form_LoaiSach_Load(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
            if(btn_Sua.Enabled == false)
            {
                
                LoaiSach loaiSach = new LoaiSach()
                { 
                    MaLoaiSach = txt_MaLoaiSach.Text,
                    TenLoaiSach = txt_TenLoaiSach.Text.Trim()
                };

                string result = loaiSachBLL.SuaLoaiSach(loaiSach);
                switch (result)
                {
                    case "Required_Name":
                        MessageBox.Show("Vui lòng nhập tên loại sách.");
                        return;
                    case "Wrong_Format_Name":
                        MessageBox.Show("Tên loại sách không hợp lệ. Không bao gồm ký tự đặc biệt.");
                        return;
                    case "Successful_Change":
                        MessageBox.Show("Sửa loại sách thành công.");
                        Form_LoaiSach_Load(sender, e);
                        return;
                    default:
                        MessageBox.Show(result);
                        return;
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaLoaiSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại sách cần xóa.");
                return;
            }
            LoaiSach loaiSach = new LoaiSach()
            {
                MaLoaiSach = txt_MaLoaiSach.Text                
            };
            DialogResult dlg;
            dlg = MessageBox.Show("Bạn có chắc muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                string result = loaiSachBLL.XoaLoaiSach(loaiSach);
                switch (result)
                {
                    case "Successful_Change":
                        MessageBox.Show("Đã xóa loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_LoaiSach_Load(sender, e);
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
            dgv_LoaiSach.DataSource = loaiSachBLL.SearchLoaiSach(keyWord).Tables[0];
        }
    }
}
