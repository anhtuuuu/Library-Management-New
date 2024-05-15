using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL:DatabaseAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();

        public List<NhaCungCap> GetListNhaCungCap()
        {
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
            string query = "SELECT * FROM NhaCungCap";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    NhaCungCap ncc = new NhaCungCap();
                    if (!reader.IsDBNull(0))
                        ncc.MaNCC = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                        ncc.TenNCC = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        ncc.DiaChi = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        ncc.Sdt = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        ncc.TrangThai = reader.GetInt32(4);
                    nhaCungCaps.Add(ncc);
                }
                sqlConnection.Close();
            }
            return nhaCungCaps;
        }

        public string ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            string query = "INSERT INTO NhaCungCap VALUES ('" + nhaCungCap.MaNCC + "', N'" + nhaCungCap.TenNCC + "', N'" + nhaCungCap.DiaChi + "', '" + nhaCungCap.Sdt + "', 1 )";
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

        public string SuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            string query = "UPDATE NhaCungCap SET TenNCC = N'" + nhaCungCap.TenNCC + "', DiaChi = N'"+ nhaCungCap.DiaChi + "', SDT = '" + nhaCungCap.Sdt + "' WHERE MaNCC = '" + nhaCungCap.MaNCC + "' ";
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

        public string XoaNhaCungCap(NhaCungCap nhaCungCap)
        {
            string query = "UPDATE NhaCungCap SET TrangThai = 0 WHERE MaNCC = '" + nhaCungCap.MaNCC + "' ";
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
        public DataSet SearchNCC(string keyWord)
        {
            string query = "SELECT * FROM NhaCungCap WHERE MaNCC like '" + keyWord + "%' OR TenNCC like N'%" + keyWord + "%' OR DiaChi like N'%" + keyWord +"%' OR SDT like '%" + keyWord + "'";
            DataSet result = Search(query);
            return result;
        }
    }
}
