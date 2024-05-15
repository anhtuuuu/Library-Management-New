using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string maHD;
        private string maSach;
        private int soLuong;
        private Decimal donGia;
        private Decimal thanhTien;

        public ChiTietHoaDon()
        {
            this.maHD = "";
            this.maSach = "";
            this.soLuong = 0;
            this.donGia = 0;
            this.thanhTien = 0;
        }

        public ChiTietHoaDon(string maHD, string maSach, int soLuong, Decimal donGia, Decimal thanhTien)
        {
            this.maHD = maHD;
            this.maSach = maSach;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public Decimal DonGia { get => donGia; set => donGia = value; }
        public Decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
