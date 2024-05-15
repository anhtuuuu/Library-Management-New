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
    public partial class Form_QuanLyTaiKhoan : Form
    {
        private string maTK_ThuTHU = "";
        public Form_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        public Form_QuanLyTaiKhoan(string TKThuThu)
        {
            InitializeComponent();
            maTK_ThuTHU = TKThuThu;
        }
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private void Form_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            if (maTK_ThuTHU == "")
            {
                this.taiKhoanTableAdapter.Fill(this.qL_ThuVienDataSet.TaiKhoan);
                List<TaiKhoan> lstTaiKhoan = taiKhoanBLL.GetListTaiKhoan();
                dgv_TaiKhoan.DataSource = lstTaiKhoan;
            }
            else
            {
                DataSet data = taiKhoanBLL.GetTaiKhoanWithID(maTK_ThuTHU);
                dgv_TaiKhoan.DataSource = data.Tables[0];
                txt_TimKiem.Enabled = false;
            }

            if (chk_TrangThai.Checked)            
                chk_TrangThai.Text = "Hoạt động";            
            else
                chk_TrangThai.Text = "Ngưng hoạt động";
        }

        private void dgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dgv_TaiKhoan.Rows[index];
            txt_MaTK.Text = data.Cells[0].Value.ToString();
            txt_HoTen.Text = data.Cells[1].Value.ToString();
            txt_SDT.Text = data.Cells[2].Value.ToString();
            txt_Email.Text = data.Cells[3].Value.ToString();
            txt_TenTK.Text = data.Cells[4].Value.ToString();
            txt_MatKhau.Text = data.Cells[5].Value.ToString();
            string status = data.Cells[6].Value.ToString();
            chk_TrangThai.Checked = (status == "1" ? true : false);
        }

        private void openText()
        {
            txt_HoTen.ReadOnly = false;
            txt_SDT.ReadOnly = false;
            txt_Email.ReadOnly = false;
            // Admin không được sửa tên tài khoản
            if (maTK_ThuTHU == "")
                txt_TenTK.ReadOnly = true;
            else
                txt_TenTK.ReadOnly = false;

            txt_MatKhau.ReadOnly = false;
            //Nếu là admin mới được sửa trạng thái
            if(maTK_ThuTHU == "")
                chk_TrangThai.Enabled = true;
        }
        private void closeText()
        {
            txt_HoTen.ReadOnly = true;
            txt_SDT.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_TenTK.ReadOnly = true;
            txt_MatKhau.ReadOnly = true;
            chk_TrangThai.Enabled = false;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {            
            if(txt_MaTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa");
                return;
            }
            btn_Sua.Enabled = false;
            openText();
            btn_CapNhat.Enabled = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                MaTK = txt_MaTK.Text,
                HoTen = txt_HoTen.Text,
                Sdt = txt_SDT.Text,
                Email = txt_Email.Text,
                Username = txt_TenTK.Text,
                Password = txt_MatKhau.Text,
                TrangThai = (chk_TrangThai.Checked?1:0)
            };
            string result = taiKhoanBLL.SuaTaiKhoan(taiKhoan);
            switch(result) 
            {
                case "Wrong_Format_FullName":
                    MessageBox.Show("Họ tên không hợp lệ. Không bao gồm ký tự đặc biệt.");
                    return;
                case "Wrong_Format_PhoneNumber":
                    MessageBox.Show("Số điện thoại không hợp lệ. Chỉ bao gồm số và tố đa 10 số.");
                    return;
                case "Required_Email":
                    MessageBox.Show("Vui lòng nhập đầy đủ Email");
                    return;
                case "Required_Password":
                    MessageBox.Show("Vui lòng nhập đầy đủ Password");
                    return;
                case "Required_Username":
                    MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản");
                    return;
                case "Wrong_Format_Username":
                    MessageBox.Show("Tên tài khoản không hợp lệ. Chỉ bao gồm chữ và số.");
                    return;
                case "Successful_Change":
                    MessageBox.Show("Thay đổi thông tin thành công");
                    Form_QuanLyTaiKhoan_Load(sender, e);
                    return;
                default:
                    MessageBox.Show(result);
                    return;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaTK.Text = "";
            txt_MatKhau.Text = "";
            txt_HoTen.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
            txt_TenTK.Text = "";
            chk_TrangThai.Checked = false;
            txt_TimKiem.Text = "";
            btn_CapNhat.Enabled = false;
            btn_Sua.Enabled = true;
            closeText();
            Form_QuanLyTaiKhoan_Load(sender, e);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txt_TimKiem.Text;
            dgv_TaiKhoan.DataSource = taiKhoanBLL.SearchTK(keyWord).Tables[0];
        }

        private void chk_TrangThai_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TrangThai.Checked)
                chk_TrangThai.Text = "Hoạt động";
            else
                chk_TrangThai.Text = "Ngưng hoạt động";
        }
    }
}
