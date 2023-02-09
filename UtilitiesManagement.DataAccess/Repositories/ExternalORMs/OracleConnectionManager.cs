using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GharbiaUtilitiesManagement.DataAccess.Repositories.ExternalORMs
{
    public static class OracleConnectionManager
    {
        //private static string connString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.10.10)(PORT=1526))(CONNECT_DATA=(SID=PROD))); User Id=HH; Password=HH;persist security info=True;";
        //private static string connString = "User Id=HH;Password=HH;Data Source=172.16.10.78:1521/prod;persist security info=True;";
        private static string connString = "User Id=HH;Password=HH;Data Source=172.16.10.10:1526/prod;persist security info=True;";
        //private static string connString = "User Id=HH;Password=HH;Data Source=172.16.10.10:152/prod;persist security info=False;"; you can get connection string from oracle management?
        public static IDbConnection GetConnection()
        {
            var conn = new OracleConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public static void CloseConnection(IDbConnection conn)
        {
            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)
            {
                conn.Close();
            }
        }
    }
}
