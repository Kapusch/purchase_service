using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin.BO
{
    public class Client
    {
        public int clientId;

        public string clientLogin;

        public string password;

        public string name;

        public string firstName;

        public DateTime inscriptionDate;

        public int sold;

        public PurchaseService.ArrayOfString result;


        public Client(int idClient)
        {
            PurchaseService.WebServiceSoapClient service = new PurchaseService.WebServiceSoapClient();
            result = service.GetClient(idClient);
        }

        public void FillClient (PurchaseService.ArrayOfString info)
        {
            clientLogin = info[0];
            password = info[1];
            name = info[2];
            firstName = info[3];
            inscriptionDate = DateTime.Parse(info[4]);
            sold=Int32.Parse(info[5]);
        }
    }
}
