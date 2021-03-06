﻿using System;
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

        public Banque(string name)
        {
            bankName = name;
        }

        public Banque(int id, string name) 
        {
            bankId = id;
            bankName = name;
        }

        #endregion

        public bool Update()
        {
            if(!(this.bankId==null || string.IsNullOrEmpty(this.BankName)))
            {
                purchase_service.DAO.BanqueDAO.Update(this);
                return true;
            }
            else
                return false;
                
        }
    }
}