using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_QuenMatKhau : Form
    {
        int otp;
        int counter;
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public Form_QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btn_GuiOTP_Click(object sender, EventArgs e)
        {
            string email = txt_EmailDaDangKy.Text;

            if(txt_EmailDaDangKy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }
            string reslutCheckEmail = taiKhoanBLL.CheckExistedEmail(email);
            if(reslutCheckEmail == "Undefind_Email")
            {
                MessageBox.Show("Email này chưa được đăng ký.");
                return;
            }

            counter = timer_OTP.Interval / 1000;
            btn_GuiOTP.Enabled = false;
            lbl_Counter.Text = counter.ToString();
            timer_Counter.Start();
            timer_OTP.Start();

            string result = taiKhoanBLL.Send_OTP(email);
            if(result == "" || result == "ERROR")
            {
                MessageBox.Show("Gửi OTP thất bại");
                return;
            }
            switch (result)
            {
                case "Required_Email":
                    MessageBox.Show("Vui lòng nhập email");
                    return;                
                default:
                    MessageBox.Show("OTP đã được gửi qua email " + email);
                    otp = (int.Parse(result));
                    //MessageBox.Show(otp.ToString());
                    return;
            }
        }

        private void btn_XacNhanOTP_Click(object sender, EventArgs e)
        {
            if (txt_MaXacNhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận");
            }
            else
            {
                if (otp.ToString().Equals(txt_MaXacNhan.Text.Trim()))
                {
                    MessageBox.Show("Xác nhận thành công");
                    TaiKhoan taiKhoan = taiKhoanBLL.GetTaiKhoanEmail(txt_EmailDaDangKy.Text);

                    MessageBox.Show("Mật khẩu của bạn là: " + taiKhoan.Password);
                }
                else
                {
                    MessageBox.Show("Xác nhận thất bại. Mã OTP không chính xác.");
                }
            }
        }

        private void timer_OTP_Tick(object sender, EventArgs e)
        {
            btn_GuiOTP.Enabled = true;
            if (counter == 0)
            {
                timer_OTP.Stop();
            }
        }

        private void timer_Counter_Tick(object sender, EventArgs e)
        {
            counter--;
            lbl_Counter.Text = counter.ToString();
            if (counter == 0)
            {
                lbl_Counter.Text = "";
                timer_Counter.Stop();
            }
        }

        private void link_DangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
