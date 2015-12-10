using Magasin.Module.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin.BO
{
    public class CartesBancaire
    {
        public int number;

        public DateTime experationDate;

        public int cryctogramme;

        public string typeCard;

        public string banque;

        public string Number { get { return number.ToString(); } }

        public string ExperationDate { get { return experationDate.ToShortDateString(); } }

        public string Crytogramme { get { return cryctogramme.ToString(); } }

        public string TypeCard { get { return typeCard; } }

        public string Bank { get { return banque; } }

        public CartesBancaire(int number, DateTime expiration, int cryto, string type, string bank)
        {
            this.number = number;
            this.experationDate = expiration;
            this.cryctogramme = cryto;
            this.typeCard = type;
            this.banque = bank;
        } 
    }
}
