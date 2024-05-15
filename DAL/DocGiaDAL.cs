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
    public class DocGiaDAL:DatabaseAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();

        public List<DocGia> GetListDocGia()
        {
            List<DocGia> docGias = new List<DocGia>();
            string query = "SELECT * FROM DocGia";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    DocGia docGia = new DocGia();
                    if (!reader.IsDBNull(0))
                        docGia.MaDG = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                        docGia.TenDG = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        docGia.DiaChi = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        docGia.Email = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        docGia.Sdt = reader.GetString(4);
                    if (!reader.IsDBNull(5))
                        docGia.NgayTao = null;
                    if (!reader.IsDBNull(6))
                        docGia.TrangThai = reader.GetInt32(6);
                    docGias.Add(docGia);
                }
                sqlConnection.Close();
            }
            return docGias;
        }

        public string ThemDocGia(DocGia docGia)
        {
            string query = "INSERT INTO DocGia VALUES ('" + docGia.MaDG + "', N'" + docGia.TenDG + "', N'" + docGia.DiaChi + "', '" + docGia.Email +"', '" + docGia.Sdt + "', '" + docGia.NgayTao + "', 1 )";
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

        public string SuaDocGia(DocGia docGia)
        {
            string query = "UPDATE DocGia SET TenDG = N'" + docGia.TenDG + "', DiaChi = N'" + docGia.DiaChi + "', Email = '" + docGia.Email + "', Sdt = '" + docGia.Sdt + "', NgayTao = '" + docGia.NgayTao + "' WHERE MaDG = '" + docGia.MaDG + "' ";
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

        public string XoaDocGia(DocGia docGia)
        {
            string query = "UPDATE DocGia SET TrangThai = 0 WHERE MaDG = '" + docGia.MaDG + "' ";
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
        public DataSet SearchDocGia(string keyWord)
        {
            string query = "SELECT * FROM DocGia WHERE MaDG like '" + keyWord + "%' OR TenDG like N'%" + keyWord + "%' OR DiaChi like N'%" + keyWord + "%' OR Email like '" + keyWord + "%' OR Sdt like '%" + keyWord + "'";
            DataSet result = Search(query);
            return result;
        }
    }
}
