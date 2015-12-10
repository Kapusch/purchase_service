using purchase_service.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace purchase_service.DAO
{
    public static class CarteBancaireDAO
    {
        public static CarteBancaire Read(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CARTE_BANCAIRE where ID_CARTE_BANCAIRE={0}", id.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            var result = ExecuteReader(cmd).FirstOrDefault();
            cmd.Dispose();
            cmd = null;
            return result;
        }

        public static List<CarteBancaire> Search(string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CARTE_BANCAIRE where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            var result = ExecuteReader(cmd);
            cmd.Dispose();
            cmd = null;
            return result;
        }

        private static List<CarteBancaire> ExecuteReader(SqlCommand cmd)
        {
            SqlDataReader reader;

            List<CarteBancaire> result = new List<CarteBancaire>();
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CarteBancaire currentBankCard = new CarteBancaire(Convert.ToInt32(reader["ID_CARTE_BANCAIRE"]), Convert.ToInt32(reader["NUMERO"])
                        , DateTime.Parse(reader["DATE_EXPIRATION"].ToString()), Convert.ToInt32(reader["CRYPTOGRAMME"])
                        , TypeCarteDAO.Read(Convert.ToInt32(reader["ID_TYPE_CARTE"])), BanqueDAO.Read(Convert.ToInt32(reader["ID_BANQUE"])));
                    result.Add(currentBankCard);
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

        public static int GenerateId()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select NEXT VALUE FOR SEQ_CARTE_BANCAIRE AS ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            SqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);
            }

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            cmd = null;
            reader = null;
            return id;
        }

        public static void Insert(CarteBancaire carteBancaire)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO CARTE_BANCAIRE VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
            cmd.CommandText = string.Format(query,carteBancaire.BankCardId.ToString(), carteBancaire.Number.ToString(), carteBancaire.ExperationDate.ToShortDateString()
                , carteBancaire.Cryctogramme, carteBancaire.TypeCard.CardTypeId, carteBancaire.Banque.BankId);
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
        public static void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "DELETE FROM CARTE_BANCAIRE WHERE ID_CARTE_BANCAIRE =@paramSup";
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
            finally
            {
                cmd.Dispose();
                cmd = null;
            }
        }

    }
}