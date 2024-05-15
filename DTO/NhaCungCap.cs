using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string sdt;
        private int trangThai;

        public NhaCungCap()
        {
            this.maNCC = "";
            this.tenNCC = "";
            this.diaChi = "";
            this.sdt = "";
            this.trangThai = 0;
        }

        public NhaCungCap(string maNCC, string tenNCC, string diaChi, string sdt, int trangThai)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.trangThai = trangThai;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
