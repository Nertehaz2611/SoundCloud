using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        private string strConn = @"Data Source=THINKPAD;Initial Catalog=SoundCloud;Integrated Security=True;Encrypt=False";
        private SqlCommand cmd = null;
        private SqlConnection conn = null;
        private SqlDataReader dr = null;
        public SqlConnectionData()
        {
            conn = new SqlConnection(strConn);
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }            
        }
        public SqlDataReader getData(string query)
        {
           
            string sql = query;
            cmd = new SqlCommand(sql);
            cmd.Connection = conn;
            this.openConnection();
            dr = cmd.ExecuteReader();
 
            return dr;
        }
        public void setData(string query)
        {
            string sql = query;
            cmd = new SqlCommand(sql);
            cmd.Connection = conn;
            this.openConnection();
            cmd.ExecuteNonQuery();
        }
        public void updateData(string query)
        {
            string sql = query;
            cmd = new SqlCommand(sql);
            cmd.Connection = conn;
            this.openConnection();
            cmd.ExecuteNonQuery();
        }
        public void deleteData(string query)
        {
            string sql = query;
            cmd = new SqlCommand(sql);
            cmd.Connection = conn;
            this.openConnection();
            cmd.ExecuteNonQuery();
        }
    }
    
}
