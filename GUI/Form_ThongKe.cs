using BLL;
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
    public partial class Form_ThongKe : Form
    {
        private ThongKeBLL thongKeBLL = new ThongKeBLL();
        private int ThongKeNam = 0;
        private int Quy = 0;
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            lbl_ThanhVien.Text = thongKeBLL.GetCountDocGia().ToString();
            lbl_SachHienCo.Text = thongKeBLL.GetSumSach().ToString();
            cbo_Nam.Items.Add("Tất cả");
            DataSet lst = thongKeBLL.GetListYear();
            for (int i = 0; i < lst.Tables[0].Rows.Count; i++)
                cbo_Nam.Items.Add(lst.Tables[0].Rows[i][0].ToString());
        }

        private void cbo_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_Nam.Text.Trim() == "Tất cả")
            {
                cbo_Quy.Enabled = false;
                int tongSoLuong = thongKeBLL.GetSumSL();
                int doanhSo = thongKeBLL.GetSumMoney();
                lbl_SLSachDaChoThue.Text = tongSoLuong.ToString();
                lbl_DoanhSo.Text = doanhSo.ToString();
                return;
            }
            cbo_Quy.Enabled = true;
            ThongKeNam = int.Parse(cbo_Nam.Text.Trim());
        }

        private void cbo_Quy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = int.Parse(cbo_Nam.Text);
            if (cbo_Quy.Text.Trim() == "Quý 1")
            {
                DataSet data = thongKeBLL.GetDataQuy1(nam);
                string soLuong = data.Tables[0].Rows[0][0].ToString();
                string doanhSo = data.Tables[0].Rows[0][1].ToString();
                lbl_SLSachDaChoThue.Text = (soLuong == ""?"0":soLuong);
                lbl_DoanhSo.Text = (doanhSo == ""?"0":doanhSo);
            }
            if (cbo_Quy.Text.Trim() == "Quý 2")
            {
                DataSet data = thongKeBLL.GetDataQuy2(nam);
                string soLuong = data.Tables[0].Rows[0][0].ToString();
                string doanhSo = data.Tables[0].Rows[0][1].ToString();
                lbl_SLSachDaChoThue.Text = (soLuong == "" ? "0" : soLuong);
                lbl_DoanhSo.Text = (doanhSo == "" ? "0" : doanhSo);
            }
            if (cbo_Quy.Text.Trim() == "Quý 3")
            {
                DataSet data = thongKeBLL.GetDataQuy3(nam);
                string soLuong = data.Tables[0].Rows[0][0].ToString();
                string doanhSo = data.Tables[0].Rows[0][1].ToString();
                lbl_SLSachDaChoThue.Text = (soLuong == "" ? "0" : soLuong);
                lbl_DoanhSo.Text = (doanhSo == "" ? "0" : doanhSo);
            }
            if (cbo_Quy.Text.Trim() == "Quý 4")
            {
                DataSet data = thongKeBLL.GetDataQuy4(nam);
                string soLuong = data.Tables[0].Rows[0][0].ToString();
                string doanhSo = data.Tables[0].Rows[0][1].ToString();
                lbl_SLSachDaChoThue.Text = (soLuong == "" ? "0" : soLuong);
                lbl_DoanhSo.Text = (doanhSo == "" ? "0" : doanhSo);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
