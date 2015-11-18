using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_service.BO
{
    public class ClientCarteBancaire
    {
        #region attributs

        private Client client;

        private CarteBancaire bankCard;

        #endregion

        #region get set

        public Client Client { get { return client; } set { client = value; } }

        public CarteBancaire BankCard { get { return bankCard; } set { bankCard = value; } }

        #endregion

        #region constructeur

        public ClientCarteBancaire(Client cli, CarteBancaire bankcard) 
        {
            client = cli;
            bankCard = bankcard;
        }

        #endregion
    }
}