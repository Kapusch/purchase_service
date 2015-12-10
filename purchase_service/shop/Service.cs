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

        public static PurchaseService.WebServiceSoapClient GetService
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
    }
}
