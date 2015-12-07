using purchase_service.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace purchase_service.DAO
{
    public static class ClientCarteBancaireDAO
    {
        public static List<ClientCarteBancaire> Search(string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CLIENT_CARTE_BANCAIRE where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd);
        }

        private static List<ClientCarteBancaire> ExecuteReader(SqlCommand cmd)
        {
            SqlDataReader reader;

            List<ClientCarteBancaire> result = new List<ClientCarteBancaire>();
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ClientCarteBancaire currentClientCarteBancaire = new ClientCarteBancaire(
                        ClientDAO.Read(Convert.ToInt32(reader["ID_CLIENT"])), CarteBancaireDAO.Read(Convert.ToInt32(reader["ID_CARTE_BANCAIRE"])));
                    result.Add(currentClientCarteBancaire);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            reader.Close();
            return result;
        }

        public static void Insert(ClientCarteBancaire clientCarteBancaire)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO CLIENT_CARTE_BANCAIRE VALUES ('{0}','{1}')";
            cmd.CommandText = string.Format(query, clientCarteBancaire.Client.ClientId.ToString()
                , clientCarteBancaire.BankCard.BankCardId.ToString());
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

        public static void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "Delete from CLIENT_CARTE_BANCAIRE where ID_CARTE_BANCAIRE = @paramSup";
            cmd.Parameters.AddWithValue("@paramSup", id);
            cmd.CommandText = string.Format(query);
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