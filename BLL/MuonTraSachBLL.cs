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
    public class MuonTraSachBLL
    {
        MuonTraSachDAL muonTraSachDAL = new MuonTraSachDAL();
        public bool kiemTraSo(string s)
        {
            return Regex.IsMatch(s, "^[0-9]{1,10}$");
        }
        public List<HoaDon> GetListHD()
        {
            return muonTraSachDAL.GetListHD();
        }
        public DataSet GetHD()
        {
            return muonTraSachDAL.GetHD();
        }
        public DataSet GetHD(string id)
        {
            return muonTraSachDAL.GetHD(id);
        }

        public DataSet GetDG()
        {
            return muonTraSachDAL.GetDG();
        }

        public DataSet GetDG(string id)
        {
            return muonTraSachDAL.GetDG(id);
        }
        public DataSet GetSach()
        {
            return muonTraSachDAL.GetSach();
        }
        public DataSet GetSach(string name)
        {
            return muonTraSachDAL.GetSach(name);
        }
        public string InsertHoaDon(HoaDon hoaDon)
        {
            if (hoaDon.MaHD == "")
                return "Required_ID";
            return muonTraSachDAL.InsertHoaDon(hoaDon);
        }
        public string InsertChitietHoaDon(ChiTietHoaDon cthd)
        {
            if (cthd.MaHD == "")
                return "Required_IDHD";
            if (cthd.MaSach == "")
                return "Required_IDSach";
            return muonTraSachDAL.InsertChitietHoaDon(cthd);
        }
        public string TraSach(string maHD, string ngayTra, int soLuong, string maSach)
        {
            return muonTraSachDAL.TraSach(maHD, ngayTra, soLuong, maSach);
        }
        public DataSet GetListCTHD(HoaDon hoaDon)
        {
            return muonTraSachDAL.GetListCTHD(hoaDon);
        }
        public DataSet GetSachWithID(string id)
        {
            return muonTraSachDAL.GetSachWithID(id);
        }
    }
}
