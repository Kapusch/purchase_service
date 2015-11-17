using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_service.BO
{
    public class CarteBancaire
    {
        #region attributs 

        private int bankCardId;

        private int number;

        private DateTime experationDate;

        private int pyctogramme;

        private TypeCarte typeCard;

        private Banque banque;

        #endregion

        #region get set

        public int BankCardId { get { return bankCardId; } }

        public int Number { get { return number; } }

        public DateTime ExperationDate { get { return experationDate; } }

        public int Pyctogramme { get { return pyctogramme; } }

        public TypeCarte TypeCard { get { return typeCard; } }

        public Banque Banque { get { return banque; } }

        #endregion

        #region constructeur

        public CarteBancaire() { }

        #endregion
    }
}