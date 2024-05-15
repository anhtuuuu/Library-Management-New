using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string maSach;
        private string maLoaiSach;
        private string tenSach;
        private string xuatXu;
        private string tacGia;
        private Decimal giaNhap;
        private Decimal giaChoThue;
        private string donViTinh;
        private string maNhaCungCap;
        private int soLuong;
        private int trangThai;
        private string hinhAnh;

        public Sach()
        {
            this.maSach = "";
            this.maLoaiSach = "";
            this.tenSach = "";
            this.xuatXu = "";
            this.tacGia = "";
            this.giaNhap = 0;
            this.giaChoThue = 0;
            this.donViTinh = "";
            this.maNhaCungCap = "";
            this.soLuong = 0;
            this.trangThai = 0;
            this.hinhAnh = "";
        }

        public Sach(string maSach, string maLoaiSach, string tenSach, string xuatXu, string tacGia, Decimal giaNhap, Decimal giaChoThue, string donViTinh, string maNhaCungCap, int soLuong, int trangThai, string hinhAnh)
        {
            this.maSach = maSach;
            this.maLoaiSach = maLoaiSach;
            this.tenSach = tenSach;
            this.xuatXu = xuatXu;
            this.tacGia = tacGia;
            this.giaNhap = giaNhap;
            this.giaChoThue = giaChoThue;
            this.donViTinh = donViTinh;
            this.maNhaCungCap = maNhaCungCap;
            this.soLuong = soLuong;
            this.trangThai = trangThai;
            this.hinhAnh = hinhAnh;
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string MaLoaiSach { get => maLoaiSach; set => maLoaiSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public Decimal GiaNhap { get => giaNhap; set => giaNhap = value; }
        public Decimal GiaChoThue { get => giaChoThue; set => giaChoThue = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
