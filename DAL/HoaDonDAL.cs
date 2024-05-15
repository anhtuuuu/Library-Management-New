using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL:DatabaseAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();

        public List<HoaDon> GetListHoaDon()
        {
            List<HoaDon> hoaDons = new List<HoaDon>();
            string query = "SELECT * FROM HoaDon";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    HoaDon hoaDon = new HoaDon();
                    if (!reader.IsDBNull(0))
                        hoaDon.MaHD = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                        hoaDon.MaDG = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        hoaDon.NgayLap = reader.GetDateTime(2).ToString();
                    if (!reader.IsDBNull(3))
                        hoaDon.HanTra = reader.GetDateTime(3).ToString();
                    if (!reader.IsDBNull(4))
                        hoaDon.NgayTra = reader.GetDateTime(4).ToString();
                    if (!reader.IsDBNull(5))
                        hoaDon.SoLuong = reader.GetInt32(5);
                    if (!reader.IsDBNull(6))
                        hoaDon.TienKhachDua = reader.GetDecimal(6);
                    if (!reader.IsDBNull(7))
                        hoaDon.TienGuiKhach = reader.GetDecimal(7);
                    if (!reader.IsDBNull(8))
                        hoaDon.ThanhTien = reader.GetDecimal(8);
                    if (!reader.IsDBNull(9))
                        hoaDon.TrangThai = reader.GetInt32(9);
                    hoaDons.Add(hoaDon);
                }
                sqlConnection.Close();
            }
            return hoaDons;
        }
        public string SuaHoaDon(HoaDon hoaDon)
        {
            string query = "UPDATE HoaDon SET MaDG = '" + hoaDon.MaDG + "', NgayLap = '" + hoaDon.NgayLap + "', HanTra = '" + hoaDon.HanTra + "', NgayTra = '" + hoaDon.NgayTra + "', SoLuong = " + hoaDon.SoLuong + ", TienKhachDua = " + hoaDon.TienKhachDua + ", TienGuiKhach = " + hoaDon.TienGuiKhach + ", ThanhTien = " + hoaDon.ThanhTien + " WHERE MaHD = '" + hoaDon.MaHD + "' ";
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
        public DataSet GetDocGia()
        {
            string query = "SELECT * FROM DocGia ";
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
        public DataSet GetCTHD(HoaDon hoaDon)
        {
            string query = "SELECT * FROM ChiTietHoaDon WHERE MaHD = '" + hoaDon.MaHD +"' " ;
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
            string query = "SELECT * FROM Sach";
            try
            {
                DataSet hoaDon = GetData(query);
                return hoaDon;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet SearchHoaDon(string keyWord)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHD like '" + keyWord + "%' OR MaDG like '" + keyWord +"%' ";
            DataSet result = Search(query);
            return result;
        }

        public string DeleteHoaDon(string maHD)
        {
            string query = "UPDATE HoaDon SET SoLuong = 0, TienKhachDua = 0, TienGuiKhach = 0, ThanhTien = 0, TrangThai = 0 WHERE MaHD = '" + maHD + "'";
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
        public string DeleteChiTietHoaDon(string maHD)
        {
            string query = "DELETE ChiTietHoaDon WHERE MaHD ='" + maHD + "'";
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
    }
}
