using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_service.BO
{
    public class Client
    {
        #region attributs 

        private int clientId;

        private string clientLogin;

        private string password;

        private string name;

        private string firstName;

        private DateTime inscriptionDate;

        private int sold;

        private bool isDelete;

        #endregion

        #region get set

        public int ClientId { get { return clientId; } }

        public string ClientLogin { get { return clientLogin; } }

        public string Password { get { return password; } }

        public string Name { get { return name; } }

        public string FirstName { get { return firstName; } }

        public DateTime InscriptionDate { get { return inscriptionDate; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        #endregion

        #region constructeur

        public Client() { }

        #endregion
    }
}