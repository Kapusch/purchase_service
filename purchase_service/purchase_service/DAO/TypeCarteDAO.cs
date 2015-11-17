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
            cmd.CommandText = string.Format("select * from Type_Carte where ID_TYPE-CARTE={0}", id.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd).FirstOrDefault();
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
    }
}