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
            var result = ExecuteReader(cmd);
            cmd.Dispose();
            cmd = null;
            return result;
        }

        public static List<Historique> AllHistorique()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from HISTORIQUE");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            var result = ExecuteReader(cmd);
            cmd.Dispose();
            cmd = null;
            return result;
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

                    Historique currentHistorique = new Historique(ClientDAO.Read(Convert.ToInt32(reader["ID_CLIENT"]))
                        , Convert.ToDouble(reader["MONTANT_TRANSACTION"]), Convert.ToDouble(reader["SOLDE_APRES_TRANSACTION"])
                        , DateTime.Parse(reader["DATE_TRANSACTION"].ToString()));
                    result.Add(currentHistorique);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            
            reader.Close();
            reader.Dispose();
            reader = null;
            return result;
        }

        public static void Insert(Historique historique)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO HISTORIQUE VALUES ('{0}','{1}','{2}','{3}')";
            cmd.CommandText = string.Format(query, historique.ClientId.ClientId.ToString(), historique.TransactionSum.ToString().Replace(",", ".")
                , historique.SoldAfterTransaction.ToString().Replace(",", "."), DateTime.Now.ToShortDateString());
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
            finally
            {
                cmd.Dispose();
                cmd = null;
            }
        }
    }
}