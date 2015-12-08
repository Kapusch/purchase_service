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

        public int Sold { get { return sold; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        #endregion

        #region constructeur

        public Client(int id, string login, string passwordC, string nameClient, string firstname
                        , DateTime inscripDate, int soldC, bool isDeleteC)
        {
            clientId = id;
            clientLogin = login;
            password = passwordC;
            name = nameClient;
            firstName = firstname;
            inscriptionDate = inscripDate;
            sold = soldC;
            isDelete = isDeleteC;
        }

        public Client(string login, string passwordC, string nameClient, string firstname
                        , DateTime inscripDate, int soldC, bool isDeleteC)
        {
            clientLogin = login;
            password = passwordC;
            name = nameClient;
            firstName = firstname;
            inscriptionDate = inscripDate;
            sold = soldC;
            isDelete = isDeleteC;
        }
        #endregion

        public bool Update()
        {
            if (!(this.ClientId == null || string.IsNullOrEmpty(this.ClientLogin) || string.IsNullOrEmpty(this.FirstName) || string.IsNullOrEmpty(this.Name)
                || string.IsNullOrEmpty(this.Password) || this.Sold == null || this.IsDelete == null))
            {
                purchase_service.DAO.ClientDAO.Update(this);
                return true;
            }
            else
                return false;
        }

        public void DoPurchase (int price)
        {
            this.sold = this.sold - price;
        }

        public void DoCredit(int amount)
        {
            this.sold = this.sold + amount;
        }
    }
}