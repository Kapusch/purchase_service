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
        private Client currentClient;

        public Payment(Client client)
        {
            currentClient = client;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblClientSold.Text = currentClient.sold.ToString();

            var cards = Service.GetService.GetCarteBancaire(currentClient.clientId);
            if (cards == null)
                return;
            if (cards[0].Count<2)
                using (var info = new InformationBox(cards[0][0]))
                {
                    info.ShowDialog();
                    return;
                }

            List<string> cardsNumbers = new List<string> {};

            foreach (var card in cards)
            {
                cardsNumbers.Add(card[0]);
            }
            cbCards.DataSource = cardsNumbers;
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
                    string result = Service.GetService.CreditTransaction(currentClient.clientId, addMonney);
                    if (!(result == "OK"))
                        using (var info = new InformationBox(result))
                        {
                            info.ShowDialog();
                        }
                    else
                    {
                        tbReload.Text = string.Empty;
                        RefreshScreen();
                    }
                }
            }
        }

        private void RefreshScreen()
        {
            var result = Service.GetService.GetClient(currentClient.clientId);

            if (string.IsNullOrEmpty(result[1])||string.IsNullOrWhiteSpace(result[1]))
                using (var info = new InformationBox(result[0]))
                {
                    info.ShowDialog();
                    cbCards.SelectedIndex = 0;
                    return;
                }
            currentClient.FillClient(result);
            lblClientSold.Text = currentClient.sold.ToString();
            cbCards.SelectedIndex = 0;
        }

        private void tbReload_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnReload_Click(sender, e);
        }

    }
}
