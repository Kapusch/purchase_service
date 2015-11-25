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
        public string NewTypeCarte(int idAdmin, string nameCard)
        {
            String msg = "";
            List<Administrateur> adminDB = AdministrateurDAO.Search("ID_ADMINISTRATEUR = '" + idAdmin + "'");

            if (!adminDB.Any())
            {
                msg = "Authentification impossible: les identifiants sont incorrects.";
            }
            else
            {
                List<TypeCarte> typeCarteDB = TypeCarteDAO.Search("NOM = '"+nameCard+"'");
                if (typeCarteDB.Any())
                {
                    msg = "Action impossible. Le type de carte " + nameCard + " est déjà présent dans la base.";
                }
                else
                {
                    TypeCarte newType = new TypeCarte(0, nameCard);
                    TypeCarteDAO.Insert(newType);
                    msg = "Le type de carte " + nameCard + " a été ajouté dans la base.";
                }
            }

            BDDConnexion.CloseConnection();
            return msg;
        }


        [WebMethod(Description = "Update the name of a card type into the DB.")]
        public string UpdateTypeCarte(int idAdmin, string oldName, string newName)
        {
            String msg = "";
            Administrateur adminDB = AdministrateurDAO.Read(idAdmin);

            if (adminDB==null)
            {
                msg = "Authentification impossible: les identifiants sont incorrects.";
            }
            else
            {
                List<TypeCarte> typeCarteDB = TypeCarteDAO.Search("NOM = '" + oldName + "'");
                if (!typeCarteDB.Any())
                {
                    msg = "Action impossible. Le type de carte " + oldName + " n'est pas présent dans la base.";
                }
                else
                {
                    TypeCarte newType = new TypeCarte(typeCarteDB[0].CardTypeId, newName);
                    TypeCarteDAO.Update(newType);
                    msg = "Le type de carte " + oldName + " a été modifié en : "+newName;
                }
            }

            BDDConnexion.CloseConnection();
            return msg;
        }
        

        [WebMethod(Description = "Create and register an account for a client.")]
        public string NewUser(string login, string pwdClient, string nameClient, string firstNameClient, int soldClient)
        {
            String msg = "";
            List<Client> clientDB = ClientDAO.Search("LOGIN_CLIENT = '" + login + "'");
            if (!clientDB.Any())
            {
                Client newClient = new Client(0, login, pwdClient, nameClient, firstNameClient, DateTime.Now, soldClient, false);
                ClientDAO.Insert(newClient);
                msg = "Le compte de " + nameClient + " " + firstNameClient + " vient d'être ouvert avec un solde initial de " + soldClient + " €. L'identifiant associé est: " + login;
            }
            else
            {
                msg = "Création du compte impossible: le login " + login + " est déjà utilisé pour un compte existant déjà en base.";
            }

            BDDConnexion.CloseConnection();
            return msg;
        }


        [WebMethod(Description = "Create and register an account for an administrator.")]
        public string NewAdmin(string login, string pwdAdmin, string nameAdmin, string firstNameAdmin)
        {
            String msg = "";
            List<Administrateur> adminDB = AdministrateurDAO.Search("LOGIN_ADMINISTRATEUR = '" + login + "'");
            if (!adminDB.Any())
            {
                Administrateur newAdmin = new Administrateur(0, login, pwdAdmin, nameAdmin, firstNameAdmin, DateTime.Now);
                AdministrateurDAO.Insert(newAdmin);
                msg = "Le compte de " + nameAdmin + " " + firstNameAdmin + " vient d'être ouvert avec tous les droits d'aministration. L'identifiant associé est: " + login;
            }
            else
            {
                msg = "Création du compte administrateur impossible: le login " + login + " est déjà utilisé pour un compte existant déjà en base.";
            }

            BDDConnexion.CloseConnection();
            return msg;
        }


        [WebMethod(Description = "Delete a client account.")]
        public string DeleteAccount(int idAdmin, int idClient)
        {
            String msg = "";
            List<Client> clientDB = ClientDAO.Search("ID_CLIENT = '" + idClient + "' AND IS_DELETE = '0'");
            if (clientDB.Any())
            {
                Client newClient = new Client(clientDB[0].ClientId, clientDB[0].ClientLogin, clientDB[0].Password, clientDB[0].Name, clientDB[0].FirstName, clientDB[0].InscriptionDate, clientDB[0].Sold, true);
                ClientDAO.Insert(newClient);
                msg = "Le compte de " + clientDB[0].Name + " " + clientDB[0].FirstName + " vient d'être supprimé par l'administrateur: "+ AdministrateurDAO.Read(idAdmin).Name;
            }
            else
            {
                msg = "Le compte associé au login n'existe pas en base ou bien a déjà été supprimé par un administrateur.";
            }

            BDDConnexion.CloseConnection();
            return msg;
        }

        [WebMethod(Description = "Enables to debit his own client account.")]
        public string DebitTransaction(int idClient, int amount)
        {
            String msg = "";
            Historique newHistorique;
            Client clientDB = ClientDAO.Read(idClient);
            if (clientDB == null || clientDB.IsDelete)
            {
                msg = "Authentification impossible: les identifiants sont incorrects ou bien le compte a été supprimé.";
            }else
            {
                if ((clientDB.Sold - amount) >= 0)
                {
                    clientDB.DoPurchase(amount);
                    newHistorique = new Historique(clientDB, amount, clientDB.Sold);
                    ClientDAO.Update(clientDB);
                    HistoriqueDAO.Insert(newHistorique);
                    msg = "Le compte de " + clientDB.Name + " " + clientDB.FirstName + " vient d'être débité du montant suivant : " + amount + "€. Solde actuel : " + (clientDB.Sold - amount) + "€";
                }
                else
                {
                    msg = "Le compte de " + clientDB.Name + " " + clientDB.FirstName + " ne peut pas être débité du montant suivant : " + amount + "€. Pensez à réapprovisionner votre compte (solde actuel: " + clientDB.Sold + "€).";
                }
            }


            BDDConnexion.CloseConnection();
            return msg;
        }


        [WebMethod(Description = "Enables to credit his own client account.")]
        public string CreditTransaction(int idClient, int amount)
        {
            String msg = "";
            Historique newHistorique;
            Client clientDB = ClientDAO.Read(idClient);
            if (clientDB == null || clientDB.IsDelete)
            {
                msg = "Authentification impossible: les identifiants sont incorrects ou bien le compte a été supprimé.";
            }
            else
            {
                Random rand = new Random();
                if (rand.Next(0, 101) > 49)
                {
                    clientDB.DoCredit(amount);
                    newHistorique = new Historique(clientDB, amount, clientDB.Sold);
                    ClientDAO.Update(clientDB);
                    HistoriqueDAO.Insert(newHistorique);
                    msg = "Le compte de " + clientDB.Name + " " + clientDB.FirstName + " vient d'être crédité du montant suivant : " + amount + "€. Solde actuel : " + (clientDB.Sold + amount) + "€";
                }
                else
                {
                    msg = "Transfert refusé par la banque. Le compte de " + clientDB.Name + " " + clientDB.FirstName + " ne peut pas être crédité du montant suivant : " + amount + "€.";
                }
            }


            BDDConnexion.CloseConnection();
            return msg;
        }
    }
}
