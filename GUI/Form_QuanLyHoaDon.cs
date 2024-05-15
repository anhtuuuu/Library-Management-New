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
    public partial class Form_QuanLyHoaDon : Form
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        public Form_QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void Form_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet4.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qL_ThuVienDataSet4.HoaDon);          

        }
        private void Refresh()
        {
            txt_MaHD.Text = string.Empty;
            cbo_MaDG.Text = string.Empty;
            dtp_NgayLap.Text = string.Empty;
            dtp_HanTra.Text = string.Empty;
            num_SoLuong.Text = string.Empty;
            num_TienKhachDua.Text = string.Empty;
            num_TienGuiKhach.Text = string.Empty;
            txt_ThanhTien.Text = string.Empty;
            dtp_HanTra.Text = string.Empty;
            dtp_NgayLap.Text = string.Empty; 
            dtp_NgayTra.Text = string.Empty;
            txt_TrangThai.Text = string.Empty;
            txt_TimKiem.Text = string.Empty;
            clb_SachDaMuon.Items.Clear();
            cbo_MaDG.Items.Clear();
        }

        private void OpenText()
        {
            cbo_MaDG.Enabled = true;
            num_SoLuong.ReadOnly = false;
            num_TienKhachDua.ReadOnly = false;
            num_TienGuiKhach.ReadOnly = false;
            dtp_HanTra.Enabled = true;
            dtp_NgayLap.Enabled = true;
            dtp_NgayTra.Enabled = true;
            clb_SachDaMuon.Enabled = true;
        }

        private void CloseText()
        {
            cbo_MaDG.Enabled = false;
            dtp_NgayLap.Enabled = false;
            dtp_HanTra.Enabled = false;
            dtp_NgayTra.Enabled = false;
            num_SoLuong.ReadOnly = true;
            num_TienKhachDua.ReadOnly = true;
            num_TienGuiKhach.ReadOnly = true;
            clb_SachDaMuon.Enabled = false;

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {            
            btn_Xoa.Enabled = true;
            CloseText();
            Refresh();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clb_SachDaMuon.Items.Clear();
            int index = e.RowIndex;
            DataGridViewRow data = dgv_HoaDon.Rows[index];            
            txt_MaHD.Text = data.Cells[0].Value.ToString();
            cbo_MaDG.Text = data.Cells[1].Value.ToString();
            dtp_NgayLap.Text = data.Cells[2].Value.ToString();
            dtp_HanTra.Text = data.Cells[3].Value.ToString();
            dtp_NgayTra.Text = data.Cells[4].Value.ToString();
            num_SoLuong.Text = data.Cells[5].Value.ToString();
            num_TienKhachDua.Text = data.Cells[6].Value.ToString();
            num_TienGuiKhach.Text = data.Cells[7].Value.ToString();
            txt_ThanhTien.Text = data.Cells[8].Value.ToString();
            txt_TrangThai.Text = (data.Cells[9].Value.ToString() == "1" ? "Chưa Trả Sách" : "Đã Trả Sách");

            HoaDon hoaDon = new HoaDon()
            {
                MaHD = txt_MaHD.Text
            };
            DataSet ms = hoaDonBLL.GetSach();
            DataSet cthd = hoaDonBLL.GetCTHD(hoaDon);
            
            for (int i = 0; i < ms.Tables[0].Rows.Count; i++)
            {
                clb_SachDaMuon.Items.Add(ms.Tables[0].Rows[i][2].ToString());
                for (int j = 0; j < cthd.Tables[0].Rows.Count; j++)
                {
                    if (ms.Tables[0].Rows[i][0].ToString() == cthd.Tables[0].Rows[j][1].ToString())
                        clb_SachDaMuon.SetItemChecked(i, true);
                }
            }
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            if(txt_MaHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết.");
                return;
            }
            HoaDon hoaDon = new HoaDon()
            { 
                MaHD = txt_MaHD.Text.Trim()
            };
            Form_ChiTietHoaDon form_ChiTietHoaDon = new Form_ChiTietHoaDon(hoaDon);
            form_ChiTietHoaDon.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_MaHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa");
                return;
            }

            DialogResult dialog = MessageBox.Show("Xác nhận xóa hóa đơn?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
                return;
            string resultDelHD = hoaDonBLL.DeleteHoaDon(txt_MaHD.Text.Trim());
            switch (resultDelHD)
            {
                case "Successful_Change":
                    string resultDelCTHD = hoaDonBLL.DeleteChiTietHoaDon(txt_MaHD.Text.Trim());
                    switch (resultDelCTHD)
                    {
                        case "Successful_Change":
                            MessageBox.Show("Xóa hóa đơn thành công.");
                            Form_QuanLyHoaDon_Load(sender, e);
                            return;
                        default:
                            MessageBox.Show(resultDelCTHD);
                            return;
                    }
                default:
                    MessageBox.Show(resultDelHD);
                    return;
            }

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            DataSet data = hoaDonBLL.SearchHoaDon(txt_TimKiem.Text);
            dgv_HoaDon.DataSource = data.Tables[0];
        }
    }
}
