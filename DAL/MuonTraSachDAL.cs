using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MuonTraSachDAL:DatabaseAccess
    {
        HoaDonDAL HDDAL = new HoaDonDAL();
        ChiTietHoaDonDAL CTHDDAL = new ChiTietHoaDonDAL();
        public List<HoaDon> GetListHD()
        {
            return HDDAL.GetListHoaDon();
        }
        public DataSet GetHD()
        {
            string query = "SELECT * FROM HoaDon";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetHD(string id)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHD = '" + id + "'";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetDG()
        {
            return HDDAL.GetDocGia();
        }
        public DataSet GetDG(string id)
        {
            string query = "SELECT * FROM DocGia WHERE MaDG = '" + id + "'";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetSach()
        {
            return HDDAL.GetSach();
        }
        public DataSet GetSach(string name)
        {
            string query = "SELECT * FROM Sach WHERE TenSach = N'" + name + "'";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetSachWithID(string id)
        {
            string query = "SELECT * FROM Sach WHERE MaSach = '" + id + "'";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string InsertHoaDon(HoaDon hoaDon)
        {
            string query = "INSERT INTO HoaDon VALUES('" + hoaDon.MaHD + "','" + hoaDon.MaDG + "','" + hoaDon.NgayLap + "','" + hoaDon.HanTra + "', NULL," + hoaDon.SoLuong + "," + hoaDon.TienKhachDua + "," + hoaDon.TienGuiKhach + "," + hoaDon.ThanhTien + "," + hoaDon.TrangThai + ")";
            try
            {
                Command(query);
                return "Successful_Change";
            }
            catch (Exception ex)
            {
                return "Fail_Change " + ex.Message;
            }
        }
        public string InsertChitietHoaDon(ChiTietHoaDon cthd)
        {
            string query = "INSERT INTO ChiTietHoaDon VALUES('" + cthd.MaHD + "','" + cthd.MaSach +"'," + cthd.SoLuong + "," + cthd.DonGia + "," + cthd.ThanhTien + "); update Sach set SoLuong = SoLuong - " + cthd.SoLuong + " where MaSach = '" + cthd.MaSach + "' ";
            try
            {
                Command(query);
                return "Successful_Change";
            }
            catch (Exception ex)
            {
                return "Fail_Change " + ex.Message;
            }
        }

        public string TraSach(string maHD, string ngayTra, int soLuong, string maSach)
        {
            string query = "UPDATE HoaDon SET TrangThai = 0, NgayTra = '" + ngayTra + "' WHERE MaHD = '" + maHD + "'; update Sach set SoLuong = SoLuong + " + soLuong + " where MaSach = '" + maSach +"' ";
            try
            {
                Command(query);
                return "Successful_Change";
            }
            catch (Exception ex)
            {
                return "Fail_Change " + ex.Message;
            }
        }

        public DataSet GetListCTHD(HoaDon hoaDon)
        {
            return CTHDDAL.GetCTHD(hoaDon);
        }
        

    }
}
