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
    public partial class Form_ChiTietHoaDon : Form
    {
        private HoaDon hd;
        private ChiTietHoaDonBLL CTHD = new ChiTietHoaDonBLL();
        public Form_ChiTietHoaDon()
        {
            InitializeComponent();
        }
        public Form_ChiTietHoaDon(HoaDon hoaDon) : this()
        {
            hd = hoaDon;
            dgv_ChiTietHoaDon.DataSource = CTHD.GetCTHD(hd).Tables[0];
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
