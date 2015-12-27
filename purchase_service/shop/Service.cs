using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin
{
    public static class Service
    {
        private static PurchaseService.WebServiceSoapClient service;

        public static PurchaseService.WebServiceSoapClient GetPaymentService
        {
            get
            {
                if (service == null)
                {
                    service = new PurchaseService.WebServiceSoapClient();
                }
                return service;
            }
        }

        private static VenteProduit.VenteProduitClient servicePurchase;

        public static VenteProduit.VenteProduitClient GetVenteProduitService
        {
            get
            {
                if (servicePurchase == null)
                {
                    servicePurchase=new VenteProduit.VenteProduitClient();
                }

                return servicePurchase;
            }
        }

        private static Panier.PanierClient servicePanier;

        public static Panier.PanierClient GetBasketService
        {
            get
            {
                if (servicePanier == null)
                {
                    servicePanier = new Panier.PanierClient();
                }

                return servicePanier;
            }
        }
    }
}
