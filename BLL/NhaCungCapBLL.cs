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
    public class NhaCungCapBLL
    {
        NhaCungCapDAL nhaCungCapDAL = new NhaCungCapDAL();
        public bool kiemTraTiengViet(string s)
        {
            return Regex.IsMatch(s, @"^[0-9A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][0-9A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
        }
        public bool kiemTraDiaChi(string s)
        {
            return Regex.IsMatch(s, @"^[0-9/,A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9/,a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][0-9/,A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9/,a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
        }
        public bool kiemTraSDT(string s)
        {
            return Regex.IsMatch(s, "^[0-9]{1,10}$");
        }
        public List<NhaCungCap> GetListNhaCungCap()
        {
            return nhaCungCapDAL.GetListNhaCungCap();
        }

        public string ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap.TenNCC.Trim() == "")
            {
                return "Required_Name";
            }
            if (!kiemTraTiengViet(nhaCungCap.TenNCC))
            {
                return "Wrong_Format_Name";
            }
            if (nhaCungCap.DiaChi.Trim() == "")
            {
                return "Required_Address";
            }
            if (!kiemTraDiaChi(nhaCungCap.DiaChi))
            {
                return "Wrong_Format_Address";
            }
            if (nhaCungCap.Sdt.Trim() == "")
            {
                return "Required_Phone";
            }
            if (!kiemTraSDT(nhaCungCap.Sdt))
            {
                return "Wrong_Format_PhoneNumber";
            }
            return nhaCungCapDAL.ThemNhaCungCap(nhaCungCap);
        }

        public string SuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap.TenNCC.Trim() == "")
            {
                return "Required_Name";
            }
            if (!kiemTraTiengViet(nhaCungCap.TenNCC))
            {
                return "Wrong_Format_Name";
            }
            if (nhaCungCap.DiaChi.Trim() == "")
            {
                return "Required_Address";
            }
            if (!kiemTraDiaChi(nhaCungCap.DiaChi))
            {
                return "Wrong_Format_Address";
            }
            if (nhaCungCap.Sdt.Trim() == "")
            {
                return "Required_Phone";
            }
            if (!kiemTraSDT(nhaCungCap.Sdt))
            {
                return "Wrong_Format_PhoneNumber";
            }
            return nhaCungCapDAL.SuaNhaCungCap(nhaCungCap);
        }
        public string XoaNhaCungCap(NhaCungCap nhaCungCap)
        {
            return nhaCungCapDAL.XoaNhaCungCap(nhaCungCap);
        }
        public DataSet SearchNCC(string keyWord)
        {
            return nhaCungCapDAL.SearchNCC(keyWord);
        }
    }
}
