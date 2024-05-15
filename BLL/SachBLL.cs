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
    public class SachBLL
    {
        public bool kiemTraTiengViet(string s)
        {
            return Regex.IsMatch(s, @"^[0-9A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][0-9A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
        }
        public bool kiemTraHoTen(string s)
        {
            return Regex.IsMatch(s, @"^[0-9.A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9.a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][0-9.A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9.a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
        }
        public bool kiemTraSo(string s)
        {
            return Regex.IsMatch(s, "^[0-9]{1,10}$");
        }
        public List<Sach> GetListSach()
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetListSach();
        }
        public string ThemSach(Sach sach)
        {
            if(sach.MaLoaiSach == "")
            {
                return "Required_MLS";
            }
            if(sach.MaNhaCungCap == "")
            {
                return "Required_MNCC";
            }
            if (!kiemTraTiengViet(sach.XuatXu))
            {
                return "Wrong_Format_From";
            }
            if (!kiemTraTiengViet(sach.TenSach))
            {
                return "Wrong_Format_NameBook";
            }
            if (!kiemTraSo(sach.GiaNhap.ToString()))
            {
                return "Wrong_Format_InPrice";
            }
            if (!kiemTraSo(sach.GiaChoThue.ToString()))
            {
                return "Wrong_Format_OutPrice";
            }
            if (!kiemTraHoTen(sach.TacGia))
            {
                return "Wrong_Format_NameAuthor";
            }
            if (!kiemTraSo(sach.SoLuong.ToString()))
            {
                return "Wrong_Format_Number";
            }
            SachDAL sachDAL = new SachDAL();
            return sachDAL.ThemSach(sach);
        }

        public DataSet GetLoaiSach()
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetLoaiSach();
        }

        public DataSet GetLoaiSachWithID(string maLoaiSach)
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetLoaiSachWithID(maLoaiSach);
        }
        public DataSet GetNhaCungCap()
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetNhaCungCap();
        }
        public DataSet GetNhaCungCapWithID(string maNCC)
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetNhaCungCapWithID(maNCC);
        }
        public string SuaSach(Sach sach)
        {
            if (sach.MaLoaiSach == "")
            {
                return "Required_MLS";
            }
            if (sach.MaNhaCungCap == "")
            {
                return "Required_MNCC";
            }
            if (!kiemTraTiengViet(sach.XuatXu))
            {
                return "Wrong_Format_From";
            }
            if (!kiemTraTiengViet(sach.TenSach))
            {
                return "Wrong_Format_NameBook";
            }
            if (!kiemTraSo(sach.GiaNhap.ToString()))
            {
                return "Wrong_Format_InPrice";
            }
            if (!kiemTraSo(sach.GiaChoThue.ToString()))
            {
                return "Wrong_Format_OutPrice";
            }
            if (!kiemTraHoTen(sach.TacGia))
            {
                return "Wrong_Format_NameAuthor";
            }
            if (!kiemTraSo(sach.SoLuong.ToString()))
            {
                return "Wrong_Format_Number";
            }
            SachDAL sachDAL = new SachDAL();
            return sachDAL.SuaSach(sach);
        }
        public string XoaSach(Sach sach)
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.XoaSach(sach);
        }
        public DataSet SearchSach(string keyWord)
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.SearchSach(keyWord);
        }
    }
}
