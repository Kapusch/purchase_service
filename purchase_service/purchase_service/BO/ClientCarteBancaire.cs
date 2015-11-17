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

        public Client ClientId { get { return client; } set { client = value; } }

        public CarteBancaire BankCardIs { get { return bankCard; } set { bankCard = value; } }

        #endregion

        #region constructeur

        public ClientCarteBancaire() { }

        #endregion
    }
}