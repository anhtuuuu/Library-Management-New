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
    public partial class Form_DangKy : Form
    {
        public TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public Form_DangKy()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txt_HoTen.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            string email = txt_Email.Text.Trim();
            string username = txt_TenTaiKhoan.Text.Trim();
            string password = txt_MatKhau.Text.Trim();
            string xacNhanMK = txt_XacNhanMK.Text.Trim();

            TaiKhoan taiKhoan = new TaiKhoan()
            {
                HoTen = hoTen,
                Sdt = sdt,
                Email = email,
                Username = username,
                Password = password
            };

            string result = taiKhoanBLL.Check_DangKy(taiKhoan, xacNhanMK);
            
            switch (result)
            {
                case "Required_Infomation":
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "Wrong_Format_Fullname":
                    MessageBox.Show("Họ tên không được chứa ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "Wrong_Format_PhoneNumber":
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "Wrong_Format_Username":
                    MessageBox.Show("Vui lòng nhập tên tài khoản từ 8-25 ký tự bao gồm chữ hoa, chữ thường và số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "Wrong_Format_Email":
                    MessageBox.Show("Email không đúng định dạng. Vui lòng kiểm tra lại email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "Existed_Email":
                    MessageBox.Show("Email này đã được đăng ký. Vui lòng đăng ký với email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "Existed_Username":
                    MessageBox.Show("Tên tài khoản này đã được đăng ký. Vui lòng nhập tên tài khoản khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "Fail_Confirm":
                    MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng xác nhận lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;                
                case "Succsessful_Register":
                    MessageBox.Show("Đăng ký tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                default:
                    MessageBox.Show(result);
                    return;
            }
        }

        private void link_DangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lbl_XacNhanMK_Click(object sender, EventArgs e)
        {

        }
    }
}
