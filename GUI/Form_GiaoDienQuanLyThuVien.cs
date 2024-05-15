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
    public partial class Form_GiaoDienQuanLyThuVien : Form
    {
        private string maTK_ThuThu = "";
        public Form_GiaoDienQuanLyThuVien()
        {
            InitializeComponent();
        }
        public Form_GiaoDienQuanLyThuVien(string TKThuThu) : this()
        {
            InitializeComponent();
            maTK_ThuThu = TKThuThu;
        }
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(maTK_ThuThu == "")
            {
                Form_QuanLyTaiKhoan quanLyTaiKhoan = new Form_QuanLyTaiKhoan();
                quanLyTaiKhoan.ShowDialog();
            }
            else
            {
                Form_QuanLyTaiKhoan quanLyTaiKhoan = new Form_QuanLyTaiKhoan(maTK_ThuThu);
                quanLyTaiKhoan.ShowDialog();
            }            
            this.Show();
        }

        private void btn_KhoSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QuanLySach form_QuanLySach = new Form_QuanLySach();
            form_QuanLySach.ShowDialog();
            this.Show();
        }

        private void btn_LoaiSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LoaiSach form_LoaiSach = new Form_LoaiSach();
            form_LoaiSach.ShowDialog();
            this.Show();
        }

        private void btn_MuonTraSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MuonTraSach form_MuonTraSach = new Form_MuonTraSach();
            form_MuonTraSach.ShowDialog();
            this.Show();
        }
               

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QuanLyHoaDon form_QuanLyHoaDon = new Form_QuanLyHoaDon();
            form_QuanLyHoaDon.ShowDialog();
            this.Show();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NhaCungCap form_NhaCungCap = new Form_NhaCungCap();
            form_NhaCungCap.ShowDialog();
            this.Show();
        }        

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_DocGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QuanLyDocGia form_QuanLyDocGia = new Form_QuanLyDocGia();
            form_QuanLyDocGia.ShowDialog();
            this.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThongKe form_ThongKe = new Form_ThongKe();
            form_ThongKe.ShowDialog();
            this.Show();
        }
    }
}
