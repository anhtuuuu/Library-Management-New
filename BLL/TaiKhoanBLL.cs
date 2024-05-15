using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public List<TaiKhoan> GetListTaiKhoan()
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            List<TaiKhoan> taiKhoans = taiKhoanDAL.GetListTaiKhoan();
            return taiKhoans;
        }

        public List<TaiKhoan> GetTaiKhoan(string id)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            List<TaiKhoan> taiKhoans = taiKhoanDAL.GetTaiKhoan(id);
            return taiKhoans;
        }

        public string Check_DangNhap(TaiKhoan taiKhoan)
        {
            if (taiKhoan.Username.Trim() == "") return "Required_TenTK";
            else if (taiKhoan.Password.Trim() == "") return "Required_MatKhau";
            else
            {
                TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
                return taiKhoanDAL.Check_DangNhap(taiKhoan);
            }
        }

        public bool kiemTraTenTaiKhoan(string s)
        {
            return Regex.IsMatch(s, "^[a-zA-Z0-9]{8,25}$");
        }
        public bool kiemTraHoTen(string s)
        {
            return Regex.IsMatch(s, @"^[A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
        }
        public bool kiemTraSDT(string s)
        {
            return Regex.IsMatch(s, "^[0-9]{1,10}$");
        }
        public bool kiemTraEmail(string e)
        {
            return Regex.IsMatch(e, @"^[a-zA-Z0-9]{5,20}@gmail.com$");
        }

        public string Check_DangKy(TaiKhoan taiKhoan, string confirm)
        {
            if (taiKhoan.HoTen == "" || taiKhoan.Sdt == "" || taiKhoan.Email == "" || taiKhoan.Username == "" || taiKhoan.Password == "")
            {
                return "Required_Infomation";
            }
            if (!kiemTraHoTen(taiKhoan.HoTen))
            {
                return "Wrong_Format_Fullname";
            }
            if (!kiemTraSDT(taiKhoan.Sdt))
            {
                return "Wrong_Format_PhoneNumber";
            }
            if (!kiemTraTenTaiKhoan(taiKhoan.Username))
            {
                return "Wrong_Format_Username";
            }            
            if (!kiemTraEmail(taiKhoan.Email))
            {
                return "Wrong_Format_Email";
            }
            if(taiKhoan.Password != confirm)
            {
                return "Fail_Confirm";
            }
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.Check_DangKy(taiKhoan);
        }
        public string CheckExistedEmail(string email)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.CheckExistedEmail(email);
        }

        public string Send_OTP(string email)
        {
            if(email == "")
            {
                return "Required_Email";
            }
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.Send_OTP(email);
        }
        public TaiKhoan GetTaiKhoanEmail(string email)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.GetTaiKhoanEmail(email);
        }

        public string SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            if (!kiemTraHoTen(taiKhoan.HoTen))
            {
                return "Wrong_Format_FullName";
            }
            if (!kiemTraSDT(taiKhoan.Sdt))
            {
                return "Wrong_Format_PhoneNumber";
            }
            
            if (taiKhoan.Email == "")
            {
                return "Required_Email";
            }
            if (!kiemTraTenTaiKhoan(taiKhoan.Username))
            {
                return "Wrong_Format_Username";
            }
            if (taiKhoan.Password == "")
            {
                return "Required_Password";
            }
            if(taiKhoan.Username == "")
            {
                return "Required_Username";
            }
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.SuaTaiKhoan(taiKhoan);
        }
        public DataSet GetTaiKhoanWithUserName(string username)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.GetTaiKhoanWithUserName(username);
        }
        public DataSet GetTaiKhoanWithID(string id)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.GetTaiKhoanWithID(id);
        }
        public DataSet SearchTK(string keyWord)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.SearchTK(keyWord);
        }
    }
}
