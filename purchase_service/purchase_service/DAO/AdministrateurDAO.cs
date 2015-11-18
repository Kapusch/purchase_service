﻿using purchase_service.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace purchase_service.DAO
{
    public static class AdministrateurDAO
    {
        public static Administrateur Read(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from ADMINISTRATEUR where ID_BANQUE={0}", id.ToString());
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd).FirstOrDefault();
        }

        public static List<Administrateur> Search(string condition)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from ADMINISTRATEUR where {0}", condition);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            return ExecuteReader(cmd);
        }

        private static List<Administrateur> ExecuteReader(SqlCommand cmd)
        {
            SqlDataReader reader;

            List<Administrateur> result = new List<Administrateur>();
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Administrateur currentAdministrateur = new Administrateur((int)reader["ID_ADMINISTRATEUR"],(string)reader["LOGIN_ADMINISTRATEUR"]
                        ,(string)reader["PASSWORD"], (string)reader["NOM"], (string)reader["PRENOM"], DateTime.Parse((string)reader["DATE_INSCRIPTION"]));
                    result.Add(currentAdministrateur);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }

            return result;
        }

        public static void Update(Administrateur admin)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "UPDATE ADMINISTRATEUR set LOGIN_ADMINISTRATEUR = '{0}', PASSWORD='{1}', NOM='{2}', PRENOM='{3}' where ID_ADMINISTRATEUR='{4}'";
            cmd.CommandText = string.Format(query, admin.AdministratorLogin, admin.Password, admin.Name, admin.FirstName,admin.AdministratorId.ToString());
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

        private static int GenerateId ()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select NEXT VALUE FOR SEQ_ADMIN AS ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = BDDConnexion.Conn;
            SqlDataReader reader = cmd.ExecuteReader();
            int id=0;
            while (reader.Read())
            {
                id = (int)reader["ID"];
            }
            return id;
        }

        public static void Insert(Administrateur admin)
        {
            SqlCommand cmd = new SqlCommand();
            const string query = "INSERT INTO ADMINISTRATEUR VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
            cmd.CommandText = string.Format(query, GenerateId().ToString(), admin.AdministratorLogin
                ,admin.Password,admin.Name,admin.FirstName,DateTime.Now.ToShortDateString());
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