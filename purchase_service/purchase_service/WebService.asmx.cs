using purchase_service.BO;
using purchase_service.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace purchase_service
{
    /// <summary>
    /// Service de gestion d'achats dans un grand magasin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService : System.Web.Services.WebService
    {

        [WebMethod(Description="Says \"Hello\" to the world.")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description="Returns the sum of two integers.")]
        public int Addition(int a, int b)
        {
            return a + b;
        }

        [WebMethod(Description = "Enables to add or withdraw money on a customer account.")]
        public string BankWire(string numAccount, int amount, string movement)
        {
            if (movement.Equals("Debit"))
            {
                return amount+"€ have been debited from account n° "+numAccount;
            }
            else
            {
                return amount + "€ have been credited on account n° " + numAccount;
            }
        }

        [WebMethod(Description = "test")]
        public string test(int id)
        {
            string result=string.Empty;

            TypeCarte carte = TypeCarteDAO.Read(id);

            if (carte != null)
                result = carte.CardName;
            return result;
        }
    }
}
