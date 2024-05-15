using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace DAL
{
    public class TaiKhoanDAL:DatabaseAccess
    {
        SqlCommand sqlCommand;
        SqlDataReader reader;
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(reader.GetString(4), reader.GetString(5)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }

        //public DataSet GetTaiKhoan()
        //{
        //    string query = "select * from TaiKhoan";
        //    DataSet taikhoan =  databaseAccess.GetData(query);
        //    return taikhoan;
        //}
        //public DataSet GetTaiKhoan(string query)
        //{            
        //    DataSet taikhoan = databaseAccess.GetData(query);
        //    return taikhoan;
        //}

        public List<TaiKhoan> GetTaiKhoan(string id)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string query = "SELECT * FROM TaiKhoan WHERE Id = '" + id +"'";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public List<TaiKhoan> GetListTaiKhoan()
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string query = "SELECT * FROM TaiKhoan";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = databaseAccess.Reader(query, sqlConnection);
                while (reader.Read())
                {
                    //taiKhoans.Add(new TaiKhoan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6)));
                    TaiKhoan tk = new TaiKhoan();
                    if (!reader.IsDBNull(0))
                        tk.MaTK = reader.GetString(0);
                    if (!reader.IsDBNull(1))
                        tk.HoTen = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        tk.Sdt = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        tk.Email = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        tk.Username = reader.GetString(4);
                    if (!reader.IsDBNull(5))
                        tk.Password = reader.GetString(5);
                    if (!reader.IsDBNull(6))
                        tk.TrangThai = reader.GetInt32(6);
                    taiKhoans.Add(tk);
                }
                sqlConnection.Close();
            }        
            return taiKhoans;
        }
        public string CheckAccountBanned(string username)
        {
            if (TaiKhoans("SELECT * FROM TaiKhoan WHERE Username = '" + username + "'").Count != TaiKhoans("SELECT * FROM TaiKhoan WHERE Username = '" + username + "' AND TrangThai = 1").Count)
                return "Banned";            
            else
                return "Active";            
        }
        public string Check_DangNhap(TaiKhoan taiKhoan)
        {
            string query = "SELECT * FROM TaiKhoan WHERE Username = '" + taiKhoan.Username + "' AND Password = '" + taiKhoan.Password + "'";
            if (TaiKhoans(query).Count != 0)
            {
                string checkBanned = CheckAccountBanned(taiKhoan.Username);
                if(checkBanned == "Banned") return "Banned";
                return "Succsessful_Login";               
            }
            else
            {
                return "Fail_Login";
            }
        }

        public string Check_DangKy(TaiKhoan taiKhoan)
        {

            if (TaiKhoans("SELECT * FROM TaiKhoan WHERE Email = '" + taiKhoan.Email + "'").Count != 0)
            {
                return "Existed_Email";
            }
            if (TaiKhoans("SELECT * FROM TaiKhoan WHERE Username = '" + taiKhoan.Username + "'").Count != 0)
            {
                return "Existed_Username";
            }
            try
            {
                int count = TaiKhoans("SELECT * FROM TaiKhoan").Count + 1;
                string next_id = "";
                if (count < 10) next_id = "TK00" + count.ToString();
                else if (count >= 10 && count < 100) next_id = "TK0" + count.ToString();
                else next_id = "TK" + count.ToString();

                string query = "INSERT INTO TaiKhoan VALUES ('" + next_id + "', N'" + taiKhoan.HoTen + "','" + taiKhoan.Sdt + "','" + taiKhoan.Email + "','" + taiKhoan.Username + "','" + taiKhoan.Password + "', 1)";
                Command(query);
                return "Succsessful_Register";
            }
            catch (Exception ex)
            {
                return "Fail_Register " + ex.Message;
            }
        }

        public string CheckExistedEmail(string email)
        {
            if (TaiKhoans("SELECT * FROM TaiKhoan WHERE Email = '" + email + "'").Count != 0)
            {
                return "Existed_Email";
            }
            else
            {
                return "Undefind_Email";
            }
        }
       

        public string Send_OTP(string email)
        {
            int otp;
            string OTP = "";
            Random random = new Random();
            try
            {
                otp = random.Next(10000, 100000);
                var fromAddress = new MailAddress("anhtu18042004@gmail.com");
                var toAddress = new MailAddress(email);
                const string frompass = "qntg tnio ktji lgqk";
                const string subject = "OTP code";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                OTP = otp.ToString();
                return OTP;
            }
            catch (Exception ex)
            {
                return "ERROR";
            }
        }

        public TaiKhoan GetTaiKhoanEmail(string email)
        {
            string query = "SELECT * FROM TaiKhoan WHERE Email like '" + email + "'";
            TaiKhoan taiKhoan = new TaiKhoan();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = Reader(query, sqlConnection);
                while (reader.Read())
                {                    
                    if(!reader.IsDBNull(5))
                        taiKhoan.Password = reader.GetString(5);
                }
                sqlConnection.Close();
            }
            return taiKhoan;
        }

        public DataSet GetTaiKhoanWithUserName(string username)
        {
            string query = "SELECT * FROM TaiKhoan WHERE Username = '" + username + "'";
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
        public DataSet GetTaiKhoanWithID(string id)
        {
            string query = "SELECT * FROM TaiKhoan WHERE MaTK = '" + id + "'";
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
        public string SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = "UPDATE TaiKhoan SET HoTen = N'" + taiKhoan.HoTen + "', Sdt = '"+taiKhoan.Sdt + "', Email = '"+taiKhoan.Email+"', Username = '"+ taiKhoan.Username + "', Password = '" + taiKhoan.Password +"' , TrangThai = " + taiKhoan.TrangThai + " WHERE MaTK = '"+taiKhoan.MaTK+"'";
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

        public DataSet SearchTK(string keyWord)
        {
            string query = "SELECT * FROM TaiKhoan WHERE MaTK like '" + keyWord + "%' OR HoTen like N'%" + keyWord + "%' OR Sdt like '%" + keyWord + "%' OR Email like '%" + keyWord + "%' OR Username like '%" + keyWord + "%' OR Password like '%" + keyWord + "%'" ;
            DataSet result = Search(query);
            return result;
        }
    }
}
