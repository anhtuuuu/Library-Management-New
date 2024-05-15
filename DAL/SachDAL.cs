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
    public class SachDAL:DatabaseAccess
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public List<Sach> GetListSach()
        {
            List<Sach> sachs = new List<Sach>();
            string query = "SELECT * FROM Sach";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    Sach sach = new Sach();
                    if (!reader.IsDBNull(0))
                        sach.MaSach = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                        sach.MaLoaiSach = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        sach.TenSach = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        sach.XuatXu = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        sach.TacGia = reader.GetString(4);
                    if (!reader.IsDBNull(5))
                        sach.GiaNhap = reader.GetDecimal(5);
                    if (!reader.IsDBNull(6))
                        sach.GiaChoThue = reader.GetDecimal(6);
                    if (!reader.IsDBNull(7))
                        sach.DonViTinh = reader.GetString(7);
                    if (!reader.IsDBNull(8))
                        sach.MaNhaCungCap = reader.GetString(8);
                    if (!reader.IsDBNull(9))
                        sach.SoLuong = reader.GetInt32(9);
                    if (!reader.IsDBNull(10))
                        sach.TrangThai = reader.GetInt32(10);
                    if (!reader.IsDBNull(11))
                        sach.HinhAnh = null;
                    sachs.Add(sach);
                }
                sqlConnection.Close();
            }
            return sachs;
        }

        public string ThemSach(Sach sach)
        {
            string query = "INSERT INTO Sach VALUES ('" + sach.MaSach + "', '" + sach.MaLoaiSach + "', N'" + sach.TenSach + "', N'" + sach.XuatXu + "', N'" + sach.TacGia + "'," + sach.GiaNhap + ", " + sach.GiaChoThue + ", N'" + sach.DonViTinh + "', '" + sach.MaNhaCungCap + "', " + sach.SoLuong + ", " + sach.TrangThai + ", NULL) ";

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

        public DataSet GetLoaiSach()
        {
            string query = "SELECT * FROM LoaiSach WHERE TrangThai = 1";
            try
            {
                DataSet sach = GetData(query);
                return sach;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetLoaiSachWithID(string maLoaiSach)
        {
            string query = "SELECT * FROM LoaiSach WHERE MaLoaiSach = '"+ maLoaiSach +"' AND TrangThai = 1";
            try
            {
                DataSet sach = GetData(query);
                return sach;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetNhaCungCap()
        {
            string query = "SELECT * FROM NhaCungCap WHERE TrangThai = 1";
            try
            {
                DataSet sach = GetData(query);
                return sach;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetNhaCungCapWithID(string maNCC)
        {
            string query = "SELECT * FROM NhaCungCap WHERE MaNCC = '"+ maNCC +"' AND TrangThai = 1";
            try
            {
                DataSet sach = GetData(query);
                return sach;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string SuaSach(Sach sach)
        {
            string query = "UPDATE Sach SET MaLoaiSach = '" + sach.MaLoaiSach + "', TenSach = N'" + sach.TenSach + "', XuatXu = N'" + sach.XuatXu + "', TacGia = N'" + sach.TacGia + "', GiaNhap = " + sach.GiaNhap + ", GiaChoThue = " + sach.GiaChoThue + ", DonViTinh = N'" + sach.DonViTinh + "', MaNhaCungCap = '" + sach.MaNhaCungCap + "', SoLuong = " + sach.SoLuong + ", TrangThai = " + sach.TrangThai +" WHERE MaSach = '" + sach.MaSach + "' ";
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

        public string XoaSach(Sach sach)
        {
            string query = "UPDATE Sach SET TrangThai = 0, SoLuong = 0 WHERE MaSach = '" + sach.MaSach + "' ";
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
        public DataSet SearchSach(string keyWord)
        {
            string query = "SELECT * FROM Sach WHERE MaSach like '" + keyWord + "%' OR MaLoaiSach like '" + keyWord + "%' OR MaNhaCungCap like '" + keyWord + "%' OR TenSach like N'%" + keyWord + "%' OR XuatXu like N'%" + keyWord + "%' OR TacGia like N'%" + keyWord + "%' ";
            DataSet result = Search(query);
            return result;
        }
    }
}
