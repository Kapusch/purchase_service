using Magasin.Module.Tools;
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

        public double sold;

        public PurchaseService.ArrayOfString result;


        public Client(int idClient)
        {
            this.clientId = idClient;
            result = Service.GetPaymentService.GetClient(idClient);
        }

        public void FillClient (PurchaseService.ArrayOfString info)
        {
            clientLogin = info[0];
            password = info[1];
            name = info[2];
            firstName = info[3];
            inscriptionDate = DateTime.Parse(info[4]);
            sold=Convert.ToDouble(info[5]);
        }

        public List<CartesBancaire> GetCartes()
        {
            try
            {
                var result = Service.GetPaymentService.GetCarteBancaire(this.clientId).ToList();

                if (result.Count != 0 && result[0].Count<2)
                    using (var info = new InformationBox(result[0][0]))
                    {
                        info.ShowDialog();
                        return null;
                    }
                List<CartesBancaire> cartes = new List<CartesBancaire> { };
                foreach (var currentCarte in result)
                {
                    cartes.Add(new CartesBancaire(Int32.Parse(currentCarte[0]), DateTime.Parse(currentCarte[1]), Int32.Parse(currentCarte[2]), currentCarte[3], currentCarte[4]));
                }

                return cartes;
            }
            catch (Exception ex)
            {
                using (var info = new InformationBox(ex.Message))
                {
                    info.ShowDialog();
                    return null;
                }
            }
        }
    }
}
