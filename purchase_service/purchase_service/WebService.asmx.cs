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
        [WebMethod(Description = "Add a new card type into the DB.")]
        public string AddTypeCarte(string name)
        {
            TypeCarte newType = new TypeCarte(0, name);
            TypeCarteDAO.Insert(newType);


            BDDConnexion.CloseConnection();
            return "The card type "+name+" was well inserted into the DB.";
        }

        [WebMethod(Description = "Update the name of a card type into the DB.")]
        public string UpdateTypeCarte(string oldName, string newName)
        {
            int idType = TypeCarteDAO.Search("NOM = '"+oldName+"'")[0].CardTypeId;
            TypeCarte newType = new TypeCarte(idType, newName);
            TypeCarteDAO.Update(newType);


            BDDConnexion.CloseConnection();
            return "The card type " + oldName + " has successfully changed to : "+newName;
        }
    }
}
