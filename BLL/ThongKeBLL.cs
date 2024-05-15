using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        ThongKeDAL TKDAL = new ThongKeDAL();
        public DataSet GetListYear()
        {
            return TKDAL.GetListYear();
        }
        public int GetSumSL()
        {
            return TKDAL.GetSumSL();
        }
        public int GetSumMoney()
        { 
            return TKDAL.GetSumMoney();
        }
        public DataSet GetDataQuy1(int nam)
        {
            return TKDAL.GetDataQuy1(nam);
        }
        public DataSet GetDataQuy2(int nam)
        {
            return TKDAL.GetDataQuy2(nam);
        }
        public DataSet GetDataQuy3(int nam)
        {
            return TKDAL.GetDataQuy3(nam);
        }
        public DataSet GetDataQuy4(int nam)
        {
            return TKDAL.GetDataQuy4(nam);
        }
        public int GetCountDocGia()
        {
            return TKDAL.GetCountDocGia();
        }
        public int GetSumSach()
        {
            return TKDAL.GetSumSach();
        }

    }
}
