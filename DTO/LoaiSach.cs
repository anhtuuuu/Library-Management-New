using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSach
    {
        private string maLoaiSach;
        private string tenLoaiSach;
        public LoaiSach() 
        {
            this.maLoaiSach = string.Empty;
            this.tenLoaiSach = string.Empty;
        }

        public LoaiSach(string maLoaiSach, string tenLoaiSach)
        {
            this.maLoaiSach = maLoaiSach;
            this.tenLoaiSach = tenLoaiSach;
        }

        public string MaLoaiSach { get => maLoaiSach; set => maLoaiSach = value; }
        public string TenLoaiSach { get => tenLoaiSach; set => tenLoaiSach = value; }
    }
}
