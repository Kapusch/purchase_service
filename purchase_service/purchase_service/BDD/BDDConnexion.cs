using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace purchase_service
{
    public static class BDDConnexion
    {
        private static SqlConnection conn;

        public static SqlConnection Conn { 
            get 
            {
                if (conn == null)
                    conn = new SqlConnection (@"Data Source=KYLROIL-PC\SQLEXPRESS;Initial Catalog=ACHAT;Integrated Security=True");
                if (!conn.State.Equals(ConnectionState.Open))
                    conn.Open();
                return conn;
            }
        }

        public static void CloseConnection()
        {
            if (conn.State.Equals(ConnectionState.Open))
                conn.Close();
        }
    }
}