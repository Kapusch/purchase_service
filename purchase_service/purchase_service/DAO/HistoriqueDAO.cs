using purchase_service.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace purchase_service.DAO
{
    public static class HistoriqueDAO
    {
        public static List<Historique> Search(string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from HISTORIQUE where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd);
        }

        private static List<Historique> ExecuteReader(SqlCommand cmd)
        {
            SqlDataReader reader;

            List<Historique> result = new List<Historique>();
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Historique currentHistorique = new Historique(ClientDAO.Read((int)reader["ID_CLIENT"])
                        , (int)reader["MONTANT_TRANSACTION"], (int)reader["SOLDE_APRES_TRANSACTION"]
                        , DateTime.Parse((string)reader["DATE_TRANSACTION"]));
                    result.Add(currentHistorique);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return result;
        }

        public static void Insert(Historique historique)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO HISTORIQUE VALUES ('{0}','{1}','{2}','{3}')";
            cmd.CommandText = string.Format(query, historique.ClientId.ClientId.ToString(), historique.TransactionSum.ToString()
                , historique.SoldAfterTransaction.ToString(), DateTime.Now.ToShortDateString());
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