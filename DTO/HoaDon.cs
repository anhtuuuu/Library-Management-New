using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string maHD;
        private string maDG;
        private string ngayLap;
        private string hanTra;
        private string ngayTra;
        private int soLuong;
        private Decimal tienKhachDua;
        private Decimal tienGuiKhach;
        private Decimal thanhTien;
        private int trangThai;
        public HoaDon() 
        {
            this.MaHD = "";
            this.MaDG = "";
            this.NgayLap = "";
            this.HanTra = "";
            this.NgayTra = "";
            this.SoLuong = 0;
            this.TienKhachDua = 0;
            this.TienGuiKhach = 0;
            this.ThanhTien = 0;
            this.TrangThai = 0;
        }

        public HoaDon(string maHD, string maDG, string ngayLap, string hanTra, string ngayTra, int soLuong, Decimal tienKhachDua, Decimal tienGuiKhach, Decimal thanhTien, int trangThai)
        {
            this.MaHD = maHD;
            this.MaDG = maDG;
            this.NgayLap = ngayLap;
            this.HanTra = hanTra;
            this.NgayTra = ngayTra;
            this.SoLuong = soLuong;
            this.TienKhachDua = tienKhachDua;
            this.TienGuiKhach = tienGuiKhach;
            this.ThanhTien = thanhTien;
            this.TrangThai = trangThai;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaDG { get => maDG; set => maDG = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string HanTra { get => hanTra; set => hanTra = value; }
        public string NgayTra { get => ngayTra; set => ngayTra = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public Decimal TienKhachDua { get => tienKhachDua; set => tienKhachDua = value; }
        public Decimal TienGuiKhach { get => tienGuiKhach; set => tienGuiKhach = value; }
        public Decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
