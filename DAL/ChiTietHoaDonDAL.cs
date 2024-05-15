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
    public class ChiTietHoaDonDAL:DatabaseAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();

        public List<ChiTietHoaDon> GetListCTHD()
        {
            List<ChiTietHoaDon> cthds = new List<ChiTietHoaDon>();
            string query = "SELECT * FROM ChiTietHoaDon";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    ChiTietHoaDon cthd = new ChiTietHoaDon();
                    if (!reader.IsDBNull(0))
                        cthd.MaHD = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                        cthd.MaSach = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        cthd.SoLuong = reader.GetInt32(2);
                    if (!reader.IsDBNull(3))
                        cthd.DonGia = reader.GetDecimal(3);
                    if (!reader.IsDBNull(4))
                        cthd.ThanhTien = reader.GetDecimal(4);
                    cthds.Add(cthd);
                }
                sqlConnection.Close();
            }
            return cthds;
        }
        public DataSet GetCTHD(HoaDon hoaDon)
        {
            string query = "SELECT * FROM ChiTietHoaDon WHERE MaHD = '" + hoaDon.MaHD + "'";
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
    }
}
