using Magasin.BO;
using Magasin.Module.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magasin.Module
{
    public partial class Payment : Form
    {
        private PurchaseService.WebServiceSoapClient service = new PurchaseService.WebServiceSoapClient();
        private Client currentClient;

        public Payment(Client client)
        {
            currentClient = client;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblClientSold.Text = currentClient.sold.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            int addMonney;
            if (!(string.IsNullOrEmpty(tbReload.Text) || string.IsNullOrWhiteSpace(tbReload.Text)))
            {
                if (!Int32.TryParse(tbReload.Text, out addMonney))
                    using (var info = new InformationBox("La valeur rentrée n'est pas un entier"))
                    {
                        info.ShowDialog();
                    }
                else
                {
                    if (addMonney < 1)
                        return;
                    string result = service.CreditTransaction(currentClient.clientId, addMonney);
                    if (!(result == "OK"))
                        using (var info = new InformationBox(result))
                        {
                            info.ShowDialog();
                        }
                    else
                        RefreshScreen();
                }
            }
        }

        private void RefreshScreen()
        {
            var result = service.GetClient(currentClient.clientId);

            if (string.IsNullOrEmpty(result[1])||string.IsNullOrWhiteSpace(result[1]))
                using (var info = new InformationBox(result[0]))
                {
                    info.ShowDialog();
                    return;
                }
            currentClient.FillClient(result);
            lblClientSold.Text = currentClient.sold.ToString();
        }

        private void tbReload_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnReload_Click(sender, e);
        }

    }
}
