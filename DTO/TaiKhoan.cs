using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string maTK;
        private string hoTen;
        private string sdt;
        private string email;
        private string username;
        private string password;
        private int trangThai;

        public TaiKhoan()
        {
            maTK = string.Empty;
            hoTen = string.Empty;
            sdt = string.Empty;
            email = string.Empty;
            username = string.Empty;
            password = string.Empty;
            trangThai = 0;
        }

        public TaiKhoan(string maTK, string hoTen, string sdt, string email, string username, string password, int trangThai)
        {
            this.maTK = maTK;
            this.hoTen = hoTen;
            this.sdt = sdt;
            this.email = email;
            this.username = username;
            this.password = password;
            this.trangThai = trangThai;
        }
        public TaiKhoan(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string MaTK { get => maTK; set => maTK = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
