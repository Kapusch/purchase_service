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
            string msg = string.Empty;
            try
            {

                
                Administrateur adminDB = AdministrateurDAO.Read(idAdmin);

                if (adminDB == null)
                    throw new Exception ("Authentification impossible: les identifiants sont incorrects.");                
                else
                {
                    List<TypeCarte> typeCarteDB = TypeCarteDAO.Search("NOM = '" + nameCard + "'");
                    if (typeCarteDB.Any())
                        throw new Exception ("Action impossible. Le type de carte " + nameCard + " est déjà présent dans la base.");
                    else
                    {
                        TypeCarte newType = new TypeCarte(nameCard);
                        TypeCarteDAO.Insert(newType);
                        msg = "Le type de carte " + nameCard + " a été ajouté dans la base.";
                    }
                }

                BDDConnexion.CloseConnection();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        [WebMethod(Description = "Ajouter une carte bancaire")]
        public String AddCarteForClient(int idClient, int numero, string dateExpi, int crypto, string typeCarte, string hisBank)
        {
            try
            {
                Client client = ClientDAO.Read(idClient);

                if (client == null || client.IsDelete)
                    throw new Exception("Le client n'existe pas");

                DateTime dateExpiration;
                if (!DateTime.TryParse(dateExpi, out dateExpiration))
                    throw new Exception("La date rentrée est invalide");

                List<TypeCarte> currentTypeCarte = TypeCarteDAO.Search("NOM='" + typeCarte + "'");
                if (!currentTypeCarte.Any())
                    throw new Exception ("Le type de carte n'existe pas");

                List<Banque> currentBank = BanqueDAO.Search("NOM='" + hisBank + "'");
                if (!currentBank.Any())
                    throw new Exception ("La banque n'existe pas");

                List<CarteBancaire> CarteBancaireDB = CarteBancaireDAO.Search("NUMERO = '" + numero.ToString() + "' AND DATE_EXPIRATION ='"
                    + dateExpiration.ToShortDateString() + "' AND CRYPTOGRAMME='" + crypto.ToString() + "' AND ID_TYPE_CARTE='" + currentTypeCarte.FirstOrDefault().CardTypeId +
                        "' AND ID_BANQUE='" + currentBank.FirstOrDefault().BankId + "'");
                if (CarteBancaireDB.Any())
                    throw new Exception ("La carte bancaire est déjà enregistrée");



                CarteBancaire newCarteBancaire = new CarteBancaire(numero, dateExpiration, crypto, currentTypeCarte.FirstOrDefault(), currentBank.FirstOrDefault());
                CarteBancaireDAO.Insert(newCarteBancaire);

                ClientCarteBancaire.LinkClientAndCarteBancaire(client, newCarteBancaire);

                BDDConnexion.CloseConnection();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return "La carte a été ajouté avec succès";
        }

        [WebMethod(Description = "Suprimer une carte à un Client")]
        public String DeleteCarteBancaireForClient(int idClient, int idCarte)
        {
            String msg = string.Empty;
            try
            {
                Client client = ClientDAO.Read(idClient);

                if (client == null || client.IsDelete)
                    throw new Exception ("Le client n'existe pas");

                else
                {
                    List<ClientCarteBancaire> ClientCarteBancaireDB = ClientCarteBancaireDAO.Search("ID_CLIENT='" + idClient + "' AND ID_CARTE_BANCAIRE = '" + idCarte + "'");
                    if (!ClientCarteBancaireDB.Any())
                        throw new Exception ("La carte n'existe pas pour le client indiqué");                    
                    else
                    {
                        ClientCarteBancaireDAO.Delete(idCarte);
                        msg = "La carte de Client a été supprimé dans la base.";
                    }

                }

                BDDConnexion.CloseConnection();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        [WebMethod(Description = "Update the name of a card type into the DB.")]
        public string UpdateTypeCarte(int idAdmin, string oldName, string newName)
        {
            String msg = string.Empty;
            try
            {
                Administrateur adminDB = AdministrateurDAO.Read(idAdmin);

                if (adminDB == null)
                    throw new Exception ("Authentification impossible: les identifiants sont incorrects.");
                else
                {
                    List<TypeCarte> typeCarteDB = TypeCarteDAO.Search("NOM = '" + oldName + "'");
                    if (!typeCarteDB.Any())
                        throw new Exception ("Action impossible. Le type de carte " + oldName + " n'est pas présent dans la base.");
                    else
                    {
                        typeCarteDB.FirstOrDefault().CardName = newName;
                        TypeCarteDAO.Update(typeCarteDB.FirstOrDefault());
                        msg = "Le type de carte " + oldName + " a été modifié en : " + newName;
                    }
                }

                BDDConnexion.CloseConnection();
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        

        [WebMethod(Description = "Create and register an account for a client.")]
        public string NewUser(string login, string pwdClient, string nameClient, string firstNameClient, int soldClient)
        {
            String msg = string.Empty;
            try
            {
                List<Client> clientDB = ClientDAO.Search("LOGIN_CLIENT = '" + login + "'");
                if (!clientDB.Any())
                {
                    Client newClient = new Client(0, login, pwdClient, nameClient, firstNameClient, DateTime.Now, soldClient, false);
                    ClientDAO.Insert(newClient);
                    msg = "Le compte de " + nameClient + " " + firstNameClient + " vient d'être ouvert avec un solde initial de " + soldClient + " €. L'identifiant associé est: " + login;
                }
                else
                {
                    throw new Exception ("Création du compte impossible: le login " + login + " est déjà utilisé pour un compte existant déjà en base.");
                }

                BDDConnexion.CloseConnection();
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }


        [WebMethod(Description = "Create and register an account for an administrator.")]
        public string NewAdmin(string login, string pwdAdmin, string nameAdmin, string firstNameAdmin)
        {
            String msg = string.Empty;
            try
            {
                List<Administrateur> adminDB = AdministrateurDAO.Search("LOGIN_ADMINISTRATEUR = '" + login + "'");
                if (!adminDB.Any())
                {
                    Administrateur newAdmin = new Administrateur(0, login, pwdAdmin, nameAdmin, firstNameAdmin, DateTime.Now);
                    AdministrateurDAO.Insert(newAdmin);
                    msg = "Le compte de " + nameAdmin + " " + firstNameAdmin + " vient d'être ouvert avec tous les droits d'aministration. L'identifiant associé est: " + login;
                }
                else
                {
                    throw new Exception ("Création du compte administrateur impossible: le login " + login + " est déjà utilisé pour un compte existant déjà en base.");
                }

                BDDConnexion.CloseConnection();
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }


        [WebMethod(Description = "Delete a client account.")]
        public string DeleteAccount(int idAdmin, int idClient)
        {
            String msg = string.Empty;
            try
            {
                List<Client> clientDB = ClientDAO.Search("ID_CLIENT = '" + idClient + "' AND IS_DELETE = '0'");
                if (clientDB.Any())
                {
                    Client newClient = new Client(clientDB[0].ClientId, clientDB[0].ClientLogin, clientDB[0].Password, clientDB[0].Name, clientDB[0].FirstName, clientDB[0].InscriptionDate, clientDB[0].Sold, true);
                    ClientDAO.Insert(newClient);
                    msg = "Le compte de " + clientDB[0].Name + " " + clientDB[0].FirstName + " vient d'être supprimé par l'administrateur: "+ AdministrateurDAO.Read(idAdmin).Name;
                }
                else
                {
                    throw new Exception ("Le compte associé au login n'existe pas en base ou bien a déjà été supprimé par un administrateur.");
                }

                BDDConnexion.CloseConnection();
            }
            catch(Exception ex)
            {
                msg=ex.Message;
            }
            return msg;
        }

        [WebMethod(Description = "Enables to debit his own client account.")]
        public string DebitTransaction(int idClient, int amount)
        {
            String msg = string.Empty;
            try
            {
                Historique newHistorique;
                Client clientDB = ClientDAO.Read(idClient);
                if (clientDB == null || clientDB.IsDelete)
                {
                    throw new Exception ("Authentification impossible: les identifiants sont incorrects ou bien le compte a été supprimé.");
                }
                else
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
                        throw new Exception ("Le compte de " + clientDB.Name + " " + clientDB.FirstName + " ne peut pas être débité du montant suivant : " + amount + "€. Pensez à réapprovisionner votre compte (solde actuel: " + clientDB.Sold + "€).");
                    }
                }
                BDDConnexion.CloseConnection();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }


        [WebMethod(Description = "Enables to credit his own client account.")]
        public string CreditTransaction(int idClient, int amount)
        {
            String msg = string.Empty;
            try
            {
                Historique newHistorique;
                Client clientDB = ClientDAO.Read(idClient);
                if (clientDB == null || clientDB.IsDelete)
                {
                    throw new Exception ("Authentification impossible: les identifiants sont incorrects ou bien le compte a été supprimé.");
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
                        throw new Exception ( "Transfert refusé par la banque. Le compte de " + clientDB.Name + " " + clientDB.FirstName + " ne peut pas être crédité du montant suivant : " + amount + "€.");
                    }
                }
                BDDConnexion.CloseConnection();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        [WebMethod(Description = "do purchase")]
        public string PurchaseProducts(int idClient, int purchasePrice)
        {
            try
            {
                if (purchasePrice < 0)
                    throw new Exception("error prix inferieur à 0");
                Client currentClient = ClientDAO.Search("ID_Client='" + idClient + "'").FirstOrDefault();
                if (currentClient == null || currentClient.IsDelete)
                    throw new Exception("Le client n'existe pas");
                if (currentClient.Sold < purchasePrice)
                    throw new Exception("Le client ne possède pas assez d'argent");

                currentClient.DoPurchase(purchasePrice);
                ClientDAO.Update(currentClient);
                Historique currentHistorique = new Historique(currentClient, purchasePrice, currentClient.Sold);
                HistoriqueDAO.Insert(currentHistorique);
                BDDConnexion.CloseConnection();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "l'achat a réussi";
        }

        [WebMethod(Description = "identified client")]
        public string PersonIdentification(string login, string pwd)
        {
            try
            {
                List<Client> currentClient = ClientDAO.Search("LOGIN_CLIENT='" + login + "' and PASSWORD='" + pwd + "' AND IS_DELETE=0");
                List<Administrateur> currentAdministrateur = AdministrateurDAO.Search("LOGIN_ADMINISTRATEUR='" + login + "' and PASSWORD='" + pwd + "'");
                if (currentClient.Count == 0 )
                    if (currentAdministrateur.Count == 0)
                        throw new Exception ("Le profil renseigné n'existe pas");

                if (currentClient.Count > 1 || currentAdministrateur.Count > 1 || (currentClient.Any() && currentAdministrateur.Any()))
                    throw new Exception ("Le profil renseigné possède plusieurs correspondances");


                BDDConnexion.CloseConnection();

                if (currentClient.Count != 0)
                    return currentClient.FirstOrDefault().ClientId.ToString();
                else
                    return currentAdministrateur.FirstOrDefault().AdministratorId.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod(Description = "Add a new bank into DB.")]
        public string NewBank(int idAdmin, string bank)
        {
            String msg = string.Empty;
            try
            {
                Administrateur adminDB = AdministrateurDAO.Read(idAdmin);

                if (adminDB == null)
                {
                    throw new Exception ("Authentification impossible: les identifiants sont incorrects.");
                }
                else
                {
                    List<Banque> bankDB = BanqueDAO.Search("NOM = '" + bank + "'");
                    if (bankDB.Any())
                    {
                        throw new Exception ("Action impossible. Le type de carte " + bank + " est déjà présent dans la base.");
                    }
                    else
                    {
                        Banque newBank = new Banque(bank);
                        BanqueDAO.Insert(newBank);
                        msg = "Le type de carte " + bank + " a été ajouté dans la base.";
                    }
                }

                BDDConnexion.CloseConnection();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }


        [WebMethod(Description = "Update the name of a bank in the DB.")]
        public string UpdateBank(int idAdmin, string oldName, string newName)
        {
            String msg = string.Empty;
            try
            {
                Administrateur adminDB = AdministrateurDAO.Read(idAdmin);

                if (adminDB == null)
                {
                    throw new Exception("Authentification impossible: les identifiants sont incorrects.");
                }
                else
                {
                    List<Banque> banqueDB = BanqueDAO.Search("NOM = '" + oldName + "'");
                    if (!banqueDB.Any())
                    {
                        throw new Exception ("Action impossible. Le type de carte " + oldName + " n'est pas présent dans la base.");
                    }
                    else
                    {
                        banqueDB.FirstOrDefault().BankName = newName;
                        BanqueDAO.Update(banqueDB.FirstOrDefault());
                        msg = "Le type de carte " + oldName + " a été modifié en : " + newName;
                    }
                }

                BDDConnexion.CloseConnection();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        [WebMethod(Description = "Get client information")]
        public List<string> GetClient(int idClient)
        {
            try
            {
                Client currentClient = ClientDAO.Read(idClient);
                if (currentClient == null || currentClient.IsDelete)
                    throw new Exception("Le client n'existe pas");

                BDDConnexion.CloseConnection();

                return new List<string> {currentClient.ClientLogin, currentClient.Password,currentClient.Name, currentClient.FirstName,
                currentClient.InscriptionDate.ToShortDateString(), currentClient.Sold.ToString()};
            }
            catch (Exception ex)
            {
                return new List<string> { ex.Message };
            }
        }

        [WebMethod(Description = "Get administrator information")]
        public List<string> GetAdministrator(int idAdmin)
        {
            try
            {
                Administrateur currentAdmin = AdministrateurDAO.Read(idAdmin);
                if (currentAdmin == null)
                    throw new Exception("L'administrateur n'existe pas");

                BDDConnexion.CloseConnection();

                return new List<string> { currentAdmin.AdministratorLogin, currentAdmin.Password, currentAdmin.Name, currentAdmin.FirstName, currentAdmin.InscriptionDate.ToShortDateString() };
            }
            catch (Exception ex)
            {
                return new List<string> { ex.Message };
            }
        }

        [WebMethod(Description = "Get all banks information")]
        public List<string> GetBanks()
        {
            try
            {
                List<Banque> banks = BanqueDAO.AllBanque();

                BDDConnexion.CloseConnection();

                List<string> result = new List<string>();
                foreach (var bank in banks)
                    result.Add(bank.BankName);

                return result;
            }
            catch (Exception ex)
            {
                return new List<string> { ex.Message };
            }
        }

        [WebMethod(Description = "Get all card type information")]
        public List<string> GetCardType()
        {
            try
            {
                List<TypeCarte> cardTypes = TypeCarteDAO.AllCardType();

                BDDConnexion.CloseConnection();

                List<string> result = new List<string>();
                foreach (var cardType in cardTypes)
                    result.Add(cardType.CardName);

                return result;
            }
            catch (Exception ex)
            {
                return new List<string> { ex.Message };
            }
        }

        [WebMethod(Description = "Get Historique information")]
        public List<List<string>> GetHistorique()
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                List<Historique> historiques = HistoriqueDAO.AllHistorique();

                BDDConnexion.CloseConnection();

                foreach (var historique in historiques)
                    result.Add(new List<string>{ historique.ClientId.ClientLogin, historique.TransactionSum.ToString(),historique.SoldAfterTransaction.ToString(),
                                                    historique.TransactionDate.ToShortDateString()});
            }
            catch (Exception ex)
            {
                result.Add(new List<string> { ex.Message });
            }
            return result;
        }

        [WebMethod(Description = "Get all clients information")]
        public List<List<string>> GetAllClients()
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                List<Client> clients = ClientDAO.AllClients();

                BDDConnexion.CloseConnection();
                
                foreach (var client in clients)
                    result.Add(new List<string> {client.ClientLogin, client.Password,client.Name, client.FirstName,
                client.InscriptionDate.ToShortDateString(), client.Sold.ToString() });
            }
            catch (Exception ex)
            {
                result.Add(new List<string> { ex.Message });
            }
            return result;
        }

        [WebMethod(Description = "Get bank card of the client")]
        public List<List<string>> GetCarteBancaire(int idClient)
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                Client client = ClientDAO.Read(idClient);

                if (client == null || client.IsDelete)
                {
                    result.Add(new List<string> { "Le client n'existe pas" });
                    return result;
                }

                List<CarteBancaire> currentBankCards = ClientCarteBancaireDAO.Search("ID_CLIENT='" + idClient + "'").Select(p => p.BankCard).ToList();

                BDDConnexion.CloseConnection();


                foreach (var bankCard in currentBankCards)
                    result.Add(new List<string> { bankCard.Number.ToString(), bankCard.ExperationDate.ToShortDateString(), bankCard.Cryctogramme.ToString(),
                                                bankCard.TypeCard.CardName, bankCard.Banque.BankName});

            }
            catch (Exception ex)
            {
                result.Add(new List<string> { ex.Message });
            }
            return result;
        }
    }
}