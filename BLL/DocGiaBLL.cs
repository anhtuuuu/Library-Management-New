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
    public class DocGiaBLL
    {
        DocGiaDAL docGiaDAL = new DocGiaDAL();
        public bool kiemTraHoTen(string s)
        {
            return Regex.IsMatch(s, @"^[A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
        }
        public bool kiemTraDiaChi(string s)
        {
            return Regex.IsMatch(s, @"^[0-9/,A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9/,a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*(?:[ ][0-9/,A-ZÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ][0-9/,a-zàáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđ]*)*$");
        }
        public bool kiemTraSDT(string s)
        {
            return Regex.IsMatch(s, "^[0-9]{1,10}$");
        }
        public List<DocGia> GetListDocGia()
        {
            return docGiaDAL.GetListDocGia();
        }

        public string ThemDocGia(DocGia docGia)
        {
            if (docGia.TenDG == "")
            {
                return "Required_Name";
            }
            if (!kiemTraHoTen(docGia.TenDG))
            {
                return "Wrong_Format_Name";
            }
            if (docGia.DiaChi == "")
            {
                return "Required_Address";
            }
            if (!kiemTraDiaChi(docGia.DiaChi))
            {
                return "Wrong_Format_Address";
            }
            if (docGia.Email == "")
            {
                return "Required_Email";
            }
            if (docGia.Sdt == "")
            {
                return "Required_Phone";
            }
            if (!kiemTraSDT(docGia.Sdt))
            {
                return "Wrong_Format_PhoneNumber";
            }
            return docGiaDAL.ThemDocGia(docGia);
        }

        public string SuaDocGia(DocGia docGia)
        {
            if (docGia.TenDG == "")
            {
                return "Required_Name";
            }
            if (!kiemTraHoTen(docGia.TenDG))
            {
                return "Wrong_Format_Name";
            }
            if (docGia.DiaChi == "")
            {
                return "Required_Address";
            }
            if (!kiemTraDiaChi(docGia.DiaChi))
            {
                return "Wrong_Format_Address";
            }
            if (docGia.Email == "")
            {
                return "Required_Email";
            }
            if (docGia.Sdt == "")
            {
                return "Required_Phone";
            }
            if (!kiemTraSDT(docGia.Sdt))
            {
                return "Wrong_Format_PhoneNumber";
            }
            return docGiaDAL.SuaDocGia(docGia);
        }

        public string XoaDocGia(DocGia docGia)
        {
            return docGiaDAL.XoaDocGia(docGia);
        }

        public DataSet SearchDocGia(string keyWord)
        {
            return docGiaDAL.SearchDocGia(keyWord);
        }
    }
}
