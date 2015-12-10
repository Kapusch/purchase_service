using purchase_service.DAO;
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

        public static bool LinkClientAndCarteBancaire(Client currentClient, CarteBancaire currentCard)
        {

            List<ClientCarteBancaire> clientCarteBancaireDB = ClientCarteBancaireDAO.Search("ID_CLIENT='" + currentClient.ClientId + "' AND ID_CARTE_BANCAIRE = '" + currentCard.BankCardId + "'");
            if (clientCarteBancaireDB.Any())
                return false;

            ClientCarteBancaire newCarte = new ClientCarteBancaire(currentClient, currentCard);
            ClientCarteBancaireDAO.Insert(newCarte);
            return true;
        }
    }
}