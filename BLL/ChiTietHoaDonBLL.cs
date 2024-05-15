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
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL cthd = new ChiTietHoaDonDAL();
        public DataSet GetCTHD(HoaDon hoaDon)
        {
            return cthd.GetCTHD(hoaDon);
        }
    }
}
