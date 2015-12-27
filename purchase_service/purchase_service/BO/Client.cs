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

        private double sold;

        private bool isDelete;

        #endregion

        #region get set

        public int ClientId { get { return clientId; } }

        public string ClientLogin { get { return clientLogin; } }

        public string Password { get { return password; } }

        public string Name { get { return name; } }

        public string FirstName { get { return firstName; } }

        public DateTime InscriptionDate { get { return inscriptionDate; } }

        public double Sold { get { return sold; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        #endregion

        #region constructeur

        public Client(int id, string login, string passwordC, string nameClient, string firstname
                        , DateTime inscripDate, double soldC, bool isDeleteC)
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
                        , DateTime inscripDate, double soldC, bool isDeleteC)
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

        public void DoPurchase (double price)
        {
            decimal result = Convert.ToDecimal(this.sold) - Convert.ToDecimal(price);
            this.sold = Convert.ToDouble(result);
        }

        public void DoCredit(double amount)
        {
            decimal result = Convert.ToDecimal(this.sold) + Convert.ToDecimal(amount);
            this.sold = Convert.ToDouble(result);
        }
    }
}