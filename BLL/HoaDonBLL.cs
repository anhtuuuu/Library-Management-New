using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();
        public List<HoaDon> GetListHoaDon()
        {
            return hoaDonDAL.GetListHoaDon();
        }
        public string SuaHoaDon(HoaDon hoaDon)
        {
            return hoaDonDAL.SuaHoaDon(hoaDon);
        }
        public DataSet GetCTHD(HoaDon hoaDon)
        {
            return hoaDonDAL.GetCTHD(hoaDon);
        }
        public DataSet GetSach()
        {
            return hoaDonDAL.GetSach();

        }
        public DataSet SearchHoaDon(string keyWord)
        {
            return hoaDonDAL.SearchHoaDon(keyWord);
        }
        public DataSet GetDocGia()
        {
            return hoaDonDAL.GetDocGia();

        }
        public string DeleteHoaDon(string maHD)
        {
            return hoaDonDAL.DeleteHoaDon(maHD);
        }
        public string DeleteChiTietHoaDon(string maHD)
        {
            return hoaDonDAL.DeleteChiTietHoaDon(maHD);
        }
    }
}
