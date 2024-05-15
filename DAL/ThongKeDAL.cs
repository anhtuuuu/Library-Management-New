using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL:DatabaseAccess
    {
        public DataSet GetListYear()
        {
            string query = "SELECT YEAR(NgayLap) FROM HoaDon GROUP BY (YEAR(NgayLap))";
            DataSet result = Search(query);
            return result;
        }
        public int GetSumSL()
        {
            string query = "SELECT SUM(SoLuong) FROM HoaDon";
            DataSet result = Search(query);
            return int.Parse(result.Tables[0].Rows[0][0].ToString());
        }
        public int GetSumMoney()
        {
            string query = "SELECT SUM(ThanhTien) FROM HoaDon";
            DataSet result = Search(query);
            return int.Parse(result.Tables[0].Rows[0][0].ToString());
        }
        public int GetCountDocGia()
        {
            string query = "select count(MaDG) from DocGia where TrangThai = 1";
            DataSet result = Search(query);
            return int.Parse(result.Tables[0].Rows[0][0].ToString());
        }
        public int GetSumSach()
        {
            string query = "select sum(SoLuong) from Sach where TrangThai = 1";
            DataSet result = Search(query);
            return int.Parse(result.Tables[0].Rows[0][0].ToString());
        }
        public DataSet GetDataQuy1(int nam)
        {
            string query = "SELECT SUM(SoLuong), SUM(ThanhTien) FROM HoaDon WHERE YEAR(NgayLap) = " + nam + " AND MONTH(NgayLap) <= 3";
            DataSet result = Search(query);
            return result;
        }
        public DataSet GetDataQuy2(int nam)
        {
            string query = "SELECT SUM(SoLuong), SUM(ThanhTien) FROM HoaDon WHERE YEAR(NgayLap) = " + nam +" AND MONTH(NgayLap) > 3 AND MONTH(NgayLap) <= 6";
            DataSet result = Search(query);
            return result;
        }
        public DataSet GetDataQuy3(int nam)
        {
            string query = "SELECT SUM(SoLuong), SUM(ThanhTien) FROM HoaDon WHERE YEAR(NgayLap) = " + nam +" AND MONTH(NgayLap) > 6 AND MONTH(NgayLap) <= 9";
            DataSet result = Search(query);
            return result;
        }
        public DataSet GetDataQuy4(int nam)
        {
            string query = "SELECT SUM(SoLuong), SUM(ThanhTien) FROM HoaDon WHERE YEAR(NgayLap) = " + nam +" AND MONTH(NgayLap) > 9";
            DataSet result = Search(query);
            return result;
        }

        
    }
}
