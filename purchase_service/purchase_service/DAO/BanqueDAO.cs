using purchase_service.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace purchase_service.DAO
{
    public static class BanqueDAO
    {
        public static Banque Read(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from BANQUE where ID_BANQUE={0}", id.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd).FirstOrDefault();
        }

        public static List<Banque> Search(string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from BANQUE where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd);
        }

        private static List<Banque> ExecuteReader(SqlCommand cmd)
        {
            SqlDataReader reader;

            List<Banque> result = new List<Banque>();
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Banque currentBanque = new Banque(Convert.ToInt32(reader["ID_BANQUE"]), reader["NOM"].ToString());
                    result.Add(currentBanque);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            reader.Close();
            return result;
        }

        public static void Update(Banque bank)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "UPDATE BANQUE set NOM = '{0}' where ID_BANQUE='{1}'";
            cmd.CommandText = string.Format(query, bank.BankName , bank.BankId.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        private static int GenerateId()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select NEXT VALUE FOR SEQ_BANQUE AS ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            SqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);
            }

            reader.Close();
            return id;
        }

        public static void Insert(Banque bank)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO BANQUE VALUES ('{0}','{1}')";
            cmd.CommandText = string.Format(query, GenerateId().ToString(), bank.BankName);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}