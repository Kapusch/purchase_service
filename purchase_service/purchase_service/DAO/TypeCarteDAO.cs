using purchase_service.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace purchase_service.DAO
{
    public static class TypeCarteDAO
    {

        public static TypeCarte Read(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from Type_Carte where ID_TYPE_CARTE={0}", id.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd).FirstOrDefault();
        }

        public static List<TypeCarte> Search (string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from Type_Carte where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd);
        }

        private static List<TypeCarte> ExecuteReader (SqlCommand cmd)
        {
            SqlDataReader reader;

            List<TypeCarte> result = new List<TypeCarte> ();
            try 
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TypeCarte currentTypeCard = new TypeCarte((int)reader["ID_TYPE_CARTE"], (string)reader["NOM"]);
                    result.Add(currentTypeCard);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return result;
        }

        public static void Update (TypeCarte typeCarte)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "UPDATE TYPE_CARTE set NOM = '{0}' where ID_TYPE_CARTE='{1}'";
            cmd.CommandText = string.Format(query, typeCarte.CardName,typeCarte.CardTypeId.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            try
            {
                // pour créer une trasaction SqlTransaction req_trans;
                // commencer la transaction req_trans = BDDConnexion.Conn.BeginTransaction();
                // arrete une transaction et la valider req_trans.Commit();
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
            cmd.CommandText = "select NEXT VALUE FOR SEQ_TYPE_CARTE AS ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            SqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = (int)reader["ID"];
            }
            return id;
        }

        public static void Insert (TypeCarte typeCarte)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO TYPE_CARTE VALUES ('{0}','{1}')";
            cmd.CommandText = string.Format(query, GenerateId().ToString(), typeCarte.CardName);
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