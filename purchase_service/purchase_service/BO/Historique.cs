using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_service.BO
{
    public class Historique
    {
        #region attributs

        private Client client;

        private int transactionSum;

        private int soldAfterTransaction;

        private DateTime transactionDate;
        
        #endregion

        #region get set

        public Client ClientId { get { return client; } set { client = value; } }

        public int TransactionSum { get { return transactionSum; } set { transactionSum = value; } }

        public int SoldAfterTransaction { get { return soldAfterTransaction; } set { soldAfterTransaction = value; } }

        public DateTime TransactionDate { get { return transactionDate; } set { transactionDate = value; } }

        #endregion

        #region constructeur

        public Historique(Client cli, int sum, int newSold,DateTime transacDate) 
        {
            client = cli;
            transactionSum = sum;
            transactionSum = sum;
            soldAfterTransaction = newSold;
            transactionDate = transacDate;
        }

        #endregion
    }
}