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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GUI
{
    public partial class Form_MuonTraSach : Form
    {
        private MuonTraSachBLL MuonTra = new MuonTraSachBLL();
        private Decimal tongTien = 0;
        private int soLuong = 0;
        private string maHD = "";
        private List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();

        public Form_MuonTraSach()
        {
            InitializeComponent();
        }

        private void Form_MuonTraSach_Load(object sender, EventArgs e)
        {
            int count = MuonTra.GetListHD().Count + 1;
            if (count < 10)
                maHD = "HD00" + count.ToString();
            else if (count >= 10 && count < 100)
                maHD = "HD0" + count.ToString();
            else
                maHD = "HD" + count.ToString();


            dtp_NgayMuon.Value = DateTime.Now;
            dtp_HanTra.Value = dtp_NgayMuon.Value.AddDays(30);
            DataSet docGia = MuonTra.GetDG();
            for (int i = 0; i < docGia.Tables[0].Rows.Count; i++)
            {
                cbo_MaDG.Items.Add(docGia.Tables[0].Rows[i][0].ToString());
            }

            DataSet sach = MuonTra.GetSach();
            for (int i = 0; i < sach.Tables[0].Rows.Count; i++)
            {
                clb_SachMuon.Items.Add(sach.Tables[0].Rows[i][2].ToString());                
            }

            DataSet hoaDon = MuonTra.GetHD();
            for (int i = 0; i < hoaDon.Tables[0].Rows.Count; i++)
            {
                cbo_MaHD.Items.Add(hoaDon.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            cbo_MaDG.Text=string.Empty;
            cbo_MaDG.Items.Clear();
            dtp_NgayMuon.Text = string.Empty;
            dtp_HanTra.Text = string.Empty;
            txt_TienGuiKhach.Text = string.Empty;
            num_TienKhachDua.ResetText();
            txt_ThanhTien.Text = string.Empty;
            clb_SachMuon.Items.Clear();
            txt_TenDG.Text = string.Empty;
            txt_SDT.Text = string.Empty;
            cbo_MaHD.Text = string.Empty;
            cbo_MaHD.Items.Clear();
            btn_InHoaDon.Enabled = false;
            Form_MuonTraSach_Load(sender, e);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbo_MaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbo_MaDG.SelectedItem.ToString();
            DataSet muonTra = MuonTra.GetDG(id);
            txt_TenDG.Text = muonTra.Tables[0].Rows[0][1].ToString();
            txt_SDT.Text = muonTra.Tables[0].Rows[0][4].ToString();

        }

        private void cbo_MaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbo_MaHD.SelectedItem.ToString();
            DataSet muonTra = MuonTra.GetHD(id);
            if (muonTra.Tables[0].Rows[0][9].ToString() == "1")
                rad_ChuaTra.Checked = true;
            else
                rad_DaTra.Checked = true;
        }

        private void btn_Them1Thang_Click(object sender, EventArgs e)
        {
            dtp_HanTra.Value = dtp_HanTra.Value.AddDays(30);
            tongTien += tongTien;
            txt_ThanhTien.Text = tongTien.ToString();
        }

        private void clb_SachMuon_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string name = clb_SachMuon.Text;
            DataSet sach = MuonTra.GetSach(name);

            if (e.CurrentValue.ToString() == "Unchecked")
            {
                soLuong += 1;
                tongTien +=  Decimal.Parse(sach.Tables[0].Rows[0][6].ToString());
                txt_ThanhTien.Text = tongTien.ToString();

                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                {
                    MaHD = maHD,
                    MaSach = sach.Tables[0].Rows[0][0].ToString(),
                    SoLuong = 1,
                    DonGia = Decimal.Parse(sach.Tables[0].Rows[0][6].ToString()),
                    ThanhTien = Decimal.Parse(sach.Tables[0].Rows[0][6].ToString())
                };

                chiTietHoaDons.Add(chiTietHoaDon);
            }
            else
            {
                soLuong -= 1;
                tongTien -= Decimal.Parse(sach.Tables[0].Rows[0][6].ToString());
                txt_ThanhTien.Text = tongTien.ToString();
                string maSach = sach.Tables[0].Rows[0][0].ToString();
                try
                {                    
                    int index = chiTietHoaDons.FindIndex(delegate (ChiTietHoaDon cthd)
                        {
                            return (cthd.MaHD.Equals(maHD) && cthd.MaSach.Equals(maSach));
                        });
                    //MessageBox.Show(index.ToString());
                    chiTietHoaDons.RemoveAt(index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void num_TienKhachDua_ValueChanged(object sender, EventArgs e)
        {
            if (tongTien == 0) return;
            Decimal tienGuiKhach = Decimal.Parse(num_TienKhachDua.Text) - tongTien;
            if (tienGuiKhach < 0)
            {
                MessageBox.Show("Cẩn thận có sai sót.");
                return;
            }
            txt_TienGuiKhach.Text = tienGuiKhach.ToString();
        }

        private void btn_Muon_Click(object sender, EventArgs e)
        {
            if(maHD == "")
            {
                return;
            }
            if (cbo_MaDG.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn độc giả.");
                return;
            }

            int checkDG = MuonTra.GetDG(cbo_MaDG.Text).Tables[0].Rows.Count;
            if(checkDG == 0)
            {
                MessageBox.Show("Mã độc giả không tồn tại. Vui lòng chọn mã độc giả khác.");
                return;
            }

            if(txt_ThanhTien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sách.");
                return;
            }
            if (num_TienKhachDua.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đã đưa.");
                return;
            }
            if (txt_TienGuiKhach.Text.Trim() == "")
            {
                MessageBox.Show("Chú ý tiền gửi khách.");
                return;
            }
            DialogResult dialog = MessageBox.Show("Xác nhận mượn?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;
            HoaDon hoaDon = new HoaDon()
            {
                MaHD = maHD,
                MaDG = cbo_MaDG.Text,
                NgayLap = dtp_NgayMuon.Value.ToString("yyyy/MM/dd"),
                HanTra = dtp_HanTra.Value.ToString("yyyy/MM/dd"),
                NgayTra = null,
                SoLuong = soLuong,
                TienKhachDua = num_TienKhachDua.Value,
                TienGuiKhach = Decimal.Parse(txt_TienGuiKhach.Text),
                ThanhTien = Decimal.Parse(txt_ThanhTien.Text),
                TrangThai = 1
            };
            string resultInsHD = MuonTra.InsertHoaDon(hoaDon);
            switch (resultInsHD)
            {
                case "Required_ID":
                    MessageBox.Show("Mã hóa đơn rỗng.");
                    return;
                case "Successful_Change":                    
                    foreach (ChiTietHoaDon item in chiTietHoaDons)
                    {
                        string resultInsCTHD = MuonTra.InsertChitietHoaDon(item);
                        switch (resultInsCTHD)
                        {
                            case "Required_IDHD":
                                MessageBox.Show("Mã hóa đơn rỗng.");
                                return;
                            case "Required_IDSach":
                                MessageBox.Show("Mã sách rỗng.");
                                return;
                            case "Successful_Change":                                
                                break;
                            default:
                                MessageBox.Show(resultInsCTHD);
                                return;
                        }
                    }
                    MessageBox.Show("Lập hóa đơn thành công.");
                    btn_InHoaDon.Enabled = true;
                    return;
                default:
                    MessageBox.Show(resultInsHD);
                    return;
            }

            

        }

        private void btn_Tra_Click(object sender, EventArgs e)
        {
            if (rad_DaTra.Checked)
            {
                MessageBox.Show("Hóa đơn này đã được trả.");
                return;
            }
            string ngayTra = DateTime.Now.ToString("yyyy/MM/dd");
            if(cbo_MaHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn mã đọc giả.");
                return;
            }
            int checkHD = MuonTra.GetHD(cbo_MaHD.Text).Tables[0].Rows.Count;
            if(checkHD == 0)
            {
                MessageBox.Show("Mã hóa đơn không tồn tại.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Xác nhận trả sách?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;

            string mhd = cbo_MaHD.Text.Trim();

            HoaDon hoaDon = new HoaDon() 
            {
                MaHD = mhd
            };

            DataSet data = MuonTra.GetListCTHD(hoaDon);

            for(int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string resultTra = MuonTra.TraSach(mhd, ngayTra, int.Parse(data.Tables[0].Rows[i][2].ToString()), data.Tables[0].Rows[i][1].ToString());
                switch (resultTra)
                {
                    case "Successful_Change":
                        MessageBox.Show("Trả sách thành công.");
                        btn_LamMoi_Click(sender, e);
                        break;
                    default:
                        MessageBox.Show(resultTra);
                        return;
                }
            }

            
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon()
            {
                MaHD = maHD,
                MaDG = cbo_MaDG.Text,
                NgayLap = dtp_NgayMuon.Value.ToString("yyyy/MM/dd"),
                HanTra = dtp_HanTra.Value.ToString("yyyy/MM/dd"),
                SoLuong = soLuong,
                TienKhachDua = num_TienKhachDua.Value,
                TienGuiKhach = Decimal.Parse(txt_TienGuiKhach.Text),
                ThanhTien = Decimal.Parse(txt_ThanhTien.Text),
            };

            DataSet getDocGia = MuonTra.GetDG(hoaDon.MaDG);
            string tenDG = getDocGia.Tables[0].Rows[0][1].ToString();

            string printHD = "\t\t\tHÓA ĐƠN" + "\n----------------------------------------\n";
            printHD += "Mã hóa đơn: " + hoaDon.MaHD + "\n";
            printHD += "Mã độc giả: " + hoaDon.MaDG + "\n";
            printHD += "Tên độc giả: " + tenDG + "\n";
            printHD += "Ngày lập: " + hoaDon.NgayLap + "\n";
            printHD += "Hạn trả: " + hoaDon.HanTra + "\n";
            printHD += "Số lượng: " + hoaDon.SoLuong + "\n";
            printHD += "Thành tiền: " + hoaDon.ThanhTien + "\n";
            printHD += "Tiền khách đưa: " + hoaDon.TienKhachDua + "\n";
            printHD += "Tiền gửi khách: " + hoaDon.TienGuiKhach + "\n";
            printHD += "Sách mượn: " + "\n";
            foreach(ChiTietHoaDon cthd in chiTietHoaDons)
            {
                DataSet getSach = MuonTra.GetSachWithID(cthd.MaSach);
                printHD += "\t+ " + getSach.Tables[0].Rows[0][2].ToString() +"\n";
            }
            printHD += "----------------------------------------\nXin cảm ơn quý khách";

            Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter.GetInstance(document, new FileStream(@"D:\\Project_CSharp\\HoaDon\\"+ maHD +".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(printHD);
            document.Add(paragraph);
            document.Close();
            MessageBox.Show("In hóa đơn thành công.");
            return;
        }
    }
}
