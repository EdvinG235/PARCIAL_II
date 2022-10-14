using PARCIAL_II.Properties;
using System;
using System.Data.SqlClient;
namespace PARCIAL_II.DAL
{
    public class Database
    {
       public static string getStrConnection()
        {
            return Settings.Default.farmaciaConnectionString;
        }

        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(getStrConnection());
            return con;
        }
        public bool testConnection()
        {
            SqlConnection con = this.GetConnection();
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}