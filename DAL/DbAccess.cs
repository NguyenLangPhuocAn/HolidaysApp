using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DbAccess
    {
        protected SqlConnection _conn;
        //static string host = "";
        //static string database = "";
        //static string userDB = "";
        //static string password = "";
        public static string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=HolidaysManagement;Integrated Security=True";
        public bool _OpenConn()
        {
            try
            {
                _conn = new SqlConnection(strConn);
                _conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void _CloseConn()
        {
            _conn.Close();
            _conn.Dispose();
        }
        public DataTable ExecuteDataTable(string query)
        {
            DataTable dt = new DataTable();
            if (_OpenConn())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, _conn);
                    dt.Load(sqlCommand.ExecuteReader());
                }
                catch (Exception ex)
                {
                    return dt;
                }
            }
            _CloseConn();
            return dt;
        }
        public DataSet ExecuteDataSet(string query)
        {
            DataSet ds = new DataSet();
            if (_OpenConn())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, _conn);
                    da.Fill(ds, "result");
                }
                catch (Exception ex)
                {
                    return ds;
                }
            }
            _CloseConn();
            return ds;
        }
        public int ExcuteScalar(string query)
        {
            if (_OpenConn())
            {
                try
                {
                    SqlCommand Cmd = new SqlCommand(query, _conn);
                    return (int)Cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            _CloseConn();
            return 0;

        }
        public int ExecuteNonQuery(string query)
        {
            if (_OpenConn())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            _CloseConn();
            return 0;
        }
    }
}
