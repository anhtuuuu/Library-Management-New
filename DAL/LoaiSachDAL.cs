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
    public class LoaiSachDAL:DatabaseAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();

        public List<LoaiSach> GetListLoaiSach()
        {
            List<LoaiSach> loaiSachs = new List<LoaiSach>();
            string query = "SELECT * FROM LoaiSach";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    LoaiSach loaiSach = new LoaiSach();
                    if (!reader.IsDBNull(0))
                        loaiSach.MaLoaiSach = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                        loaiSach.TenLoaiSach = reader.GetString(1);
                    loaiSachs.Add(loaiSach);
                }
                sqlConnection.Close();
            }
            return loaiSachs;
        }

        public string ThemLoaiSach(LoaiSach loaiSach)
        {
            string query = "INSERT INTO LoaiSach VALUES ('" + loaiSach.MaLoaiSach + "', N'" + loaiSach.TenLoaiSach +"', 1 )";
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

        public string SuaLoaiSach(LoaiSach loaiSach)
        {
            string query = "UPDATE LoaiSach SET TenLoaiSach = N'" + loaiSach.TenLoaiSach + "' WHERE MaLoaiSach = '" + loaiSach.MaLoaiSach + "' ";
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

        public string XoaLoaiSach(LoaiSach loaiSach)
        {
            string query = "UPDATE LoaiSach SET TrangThai = 0 WHERE MaLoaiSach = '" + loaiSach.MaLoaiSach + "' ";
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
        public DataSet SearchLoaiSach(string keyWord)
        {
            string query = "SELECT * FROM LoaiSach WHERE MaLoaiSach like '" + keyWord + "%' OR TenLoaiSach like N'%" + keyWord + "%'";
            DataSet result = Search(query);
            return result;
        }
    }
}
