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
            return ExecuteReader(cmd).FirstOrDefault();
        }

        public static List<CarteBancaire> Search(string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CARTE_BANCAIRE where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd);
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
                        ,DateTime.Parse(reader["DATE_EXPIRATION"].ToString()),Convert.ToInt32(reader["CRYPTOGRAMME"])
                        ,TypeCarteDAO.Read(Convert.ToInt32(reader["ID_TYPE_CARTE"])), BanqueDAO.Read(Convert.ToInt32(reader["ID_BANQUE"])));
                    result.Add(currentBankCard);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            reader.Close();
            return result;
        }

        private static int GenerateId()
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
            return id;
        }

        public static void Insert(CarteBancaire carteBancaire)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO CLIENT VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
            cmd.CommandText = string.Format(query, GenerateId().ToString(), carteBancaire.Number, carteBancaire.ExperationDate.ToShortDateString()
                ,carteBancaire.Cryctogramme.ToString(), carteBancaire.TypeCard.CardTypeId, carteBancaire.Banque.BankId);
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