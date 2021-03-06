﻿using Magasin.BO;
using Magasin.Module.Tools;
using Magasin.VenteProduit;
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
        public Dictionary<produit, int> Basket;

        public Payment(Client client)
        {
            currentClient = client;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // charge le panier, les cartes du client
            Basket = MainMenu.Basket;
            lblClientSold.Text = currentClient.sold.ToString()+"€";

            var cards = Service.GetPaymentService.GetCarteBancaire(currentClient.clientId);
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

            lbOrder.Items.AddRange(Basket.Select(p => p.Key.designation).ToArray());
            lblPrice.Text = Basket.Sum(p => p.Value*p.Key.prix).ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            // permet de recharger son compte
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
                    string result = Service.GetPaymentService.CreditTransaction(currentClient.clientId, Convert.ToDouble(addMonney));
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
            // actualise la page avec les nouvelles informations
            var result = Service.GetPaymentService.GetClient(currentClient.clientId);

            if (string.IsNullOrEmpty(result[1])||string.IsNullOrWhiteSpace(result[1]))
                using (var info = new InformationBox(result[0]))
                {
                    info.ShowDialog();
                    cbCards.SelectedIndex = 0;
                    return;
                }
            currentClient.FillClient(result);
            lblClientSold.Text = currentClient.sold.ToString()+"€";
            cbCards.SelectedIndex = 0;
        }

        private void tbReload_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnReload_Click(sender, e);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // permet de payer
            if (string.IsNullOrEmpty(lblPrice.Text) || string.IsNullOrWhiteSpace(lblPrice.Text))
                return;

            if (Convert.ToDouble(lblPrice.Text) < currentClient.sold)
            {
                var result = Service.GetPaymentService.DebitTransaction(currentClient.clientId, Convert.ToDouble(lblPrice.Text));
                using (var info = new InformationBox(result))
                {
                    info.ShowDialog();
                }
                RefreshScreen();
                lbOrder.Items.Clear();
                lblPrice.Text = string.Empty;
                Basket = null;
            }
            else
                using (var info = new InformationBox("Veuillez recharger, vous n'avez pas assez d'argent"))
                {
                    info.ShowDialog();
                }

        }

    }
}
