using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {
        private string maDG;
        private string tenDG;
        private string diaChi;
        private string email;
        private string sdt;
        private string ngayTao;
        private int trangThai;

        public DocGia()
        {
            this.maDG = "";
            this.tenDG = "";
            this.diaChi = "";
            this.email = "";
            this.sdt = "";
            this.ngayTao = "";
            this.trangThai = 0;
        }

        public DocGia(string maDG, string tenDG, string diaChi, string email, string sdt, string ngayTao, int trangThai)
        {
            this.maDG = maDG;
            this.tenDG = tenDG;
            this.diaChi = diaChi;
            this.email = email;
            this.sdt = sdt;
            this.ngayTao = ngayTao;
            this.trangThai = trangThai;
        }

        public string MaDG { get => maDG; set => maDG = value; }
        public string TenDG { get => tenDG; set => tenDG = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string NgayTao { get => ngayTao; set => ngayTao = value; }

        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
