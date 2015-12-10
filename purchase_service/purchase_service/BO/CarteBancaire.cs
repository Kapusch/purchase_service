using purchase_service.DAO;
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

        private int cryctogramme;

        private TypeCarte typeCard;

        private Banque banque;

        #endregion

        #region get set

        public int BankCardId { get { return bankCardId; } }

        public int Number { get { return number; } }

        public DateTime ExperationDate { get { return experationDate; } }

        public int Cryctogramme { get { return cryctogramme; } }

        public TypeCarte TypeCard { get { return typeCard; } }

        public Banque Banque { get { return banque; } }

        #endregion

        #region constructeur

        public CarteBancaire(int numero, DateTime dateExpi, int crypto, TypeCarte type, Banque hisBank)
        {
            bankCardId = CarteBancaireDAO.GenerateId();
            number = numero;
            experationDate = dateExpi;
            cryctogramme = crypto;
            typeCard = type;
            banque = hisBank;
        }

        public CarteBancaire(int id, int numero, DateTime dateExpi, int crypto, TypeCarte type, Banque hisBank) 
        {
            bankCardId = id;
            number = numero;
            experationDate = dateExpi;
            cryctogramme = crypto;
            typeCard = type;
            banque = hisBank;
        }

        #endregion

        
    }
}