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

        private double transactionSum;

        private double soldAfterTransaction;

        private DateTime transactionDate;
        
        #endregion

        #region get set

        public Client ClientId { get { return client; } set { client = value; } }

        public double TransactionSum { get { return transactionSum; } set { transactionSum = value; } }

        public double SoldAfterTransaction { get { return soldAfterTransaction; } set { soldAfterTransaction = value; } }

        public DateTime TransactionDate { get { return transactionDate; } }

        #endregion

        #region constructeur

        public Historique(Client cli, double sum, double newSold)
        {
            client = cli;
            transactionSum = sum;
            soldAfterTransaction = newSold;
        }

        public Historique(Client cli, double sum, double newSold, DateTime transacDate) 
        {
            client = cli;
            transactionSum = sum;
            soldAfterTransaction = newSold;
            transactionDate = transacDate;
        }

        #endregion
    }
}