using purchase_service.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace purchase_service.DAO
{
    public static class ClientDAO
    {
        public static Client Read(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CLIENT where ID_CLIENT={0}", id.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            var result = ExecuteReader(cmd).FirstOrDefault();
            cmd.Dispose();
            cmd = null;
            return result;
        }

        public static List<Client> Search(string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CLIENT where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            var result = ExecuteReader(cmd);
            cmd.Dispose();
            cmd = null;
            return result;
        }

        public static List<Client> AllClients()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CLIENT");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            var result = ExecuteReader(cmd);
            cmd.Dispose();
            cmd = null;
            return result;
        }

        private static List<Client> ExecuteReader(SqlCommand cmd)
        {
            SqlDataReader reader = cmd.ExecuteReader();

            List<Client> result = new List<Client>();
            try
            {
                while (reader.Read())
                {
                    Client currentClient = new Client(Convert.ToInt32(reader["ID_CLIENT"]), reader["LOGIN_CLIENT"].ToString(), reader["PASSWORD"].ToString()
                        ,reader["NOM"].ToString(), reader["PRENOM"].ToString(), DateTime.Parse(reader["DATE_INSCRIPTION"].ToString())
                        ,Convert.ToInt32(reader["SOLDE"]), (Convert.ToInt32(reader["IS_DELETE"]) == 1));
                    result.Add(currentClient);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                reader = null;
            }
            return result;
        }

        public static void Update(Client client)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "UPDATE CLIENT set LOGIN_CLIENT = '{0}', PASSWORD='{1}', NOM='{2}', PRENOM='{3}', SOLDE='{4}', IS_DELETE='{5}' where ID_CLIENT='{6}'";
            cmd.CommandText = string.Format(query, client.ClientLogin, client.Password, client.Name, client.FirstName, client.Sold.ToString(), client.IsDelete ? "1" : "0", client.ClientId.ToString());
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

        private static int GenerateId()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select NEXT VALUE FOR SEQ_CLIENT AS ID";
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

        public static void Insert(Client client)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO CLIENT VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
            cmd.CommandText = string.Format(query, GenerateId().ToString(), client.ClientLogin, client.Password, client.Name
                , client.FirstName, DateTime.Now.ToShortDateString(), client.Sold.ToString(), client.IsDelete ? "1" : "0");
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