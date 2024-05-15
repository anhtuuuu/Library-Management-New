using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Reflection;
using System.ComponentModel;
using System.Reflection.Emit;
using System.CodeDom;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class Connection
    {
        private static string _connectionString = @"Data Source=(local);Initial Catalog=QL_ThuVien;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
    public class DatabaseAccess
    {
        SqlCommand sqlCommand;
        
        public void Command(string query)
        {
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR Command: " + ex.Message);
            }
        }

        public SqlDataReader Reader(string query, SqlConnection sqlConnection)
        {
            try
            {               
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    return reader;
               
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR Reader: " + ex.Message);
            }
            
                
        }
        public DataSet GetData(string query)
        {
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    //grid.DataSource = ds.Tables[0];
                    sqlConnection.Close();
                    return ds;
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("ERROR GetData: " + ex.Message);
            }
        }
        public DataSet Search(string query)
        {
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
