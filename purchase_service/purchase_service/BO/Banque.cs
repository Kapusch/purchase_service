using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_service.BO
{
    public class Banque
    {
        #region attributs 

        private int bankId;

        private string bankName;

        #endregion

        #region get set

        public int BankId { get { return bankId; } }

        public string BankName { get { return bankName; } set { bankName = value; } }

        #endregion

        #region constructeur

        public Banque() { }

        #endregion
    }
}