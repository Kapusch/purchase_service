using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_service.BO
{
    public class TypeCarte
    {
        #region attributs

        private int cardTypeId;

        private string cardName;

        #endregion

        #region get set

        public int CardTypeId { get { return cardTypeId; } }

        public string CardName { get { return cardName; } set { cardName = value; } }

        #endregion

        #region constructeur

        public TypeCarte(int id, string name) 
        {
            cardTypeId = id;
            cardName = name;
        }

        #endregion

        public bool Update()
        {
            if (!(string.IsNullOrEmpty(this.CardName) || this.CardTypeId == null))
            {
                purchase_service.DAO.TypeCarteDAO.Update(this);
                return true;
            }
            else
                return false;
        }
    }
}