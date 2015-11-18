using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_service.BO
{
    public class Administrateur
    {

        #region attributs 

        private int administratorId;

        private string administratorLogin;

        private string password;

        private string name;

        private string firstName;

        private DateTime inscriptionDate;

        #endregion

        #region get set 

        public int AdministratorId { get { return administratorId; } }

        public string AdministratorLogin { get { return administratorLogin; } }

        public string Password { get { return password; } }

        public string Name { get { return name; } }

        public string FirstName { get { return firstName; } }

        public DateTime InscriptionDate { get { return inscriptionDate; } }

        #endregion

        #region constructeur

        public Administrateur(int id, string login, string passwordA, string nomA, string firstname, DateTime inscripDate) 
        {
            administratorId = id;
            administratorLogin = login;
            password = passwordA;
            name = nomA;
            firstName = firstname;
            inscriptionDate = inscripDate;
        }

        #endregion

        public bool Update()
        {
            if (!(this.administratorId == null || string.IsNullOrEmpty(this.AdministratorLogin) || string.IsNullOrEmpty(this.Password) ||
                string.IsNullOrEmpty(this.Name) || string.IsNullOrEmpty(this.FirstName)))
            {
                purchase_service.DAO.AdministrateurDAO.Update(this);
                return true;
            }
            else
                return false;
        }
    }
}