using Magasin.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magasin.Module.Tools
{
    public partial class ClientInformation : Form
    {
        private Client currentClient;
        private List<CartesBancaire> cartes;

        public ClientInformation(Client client, List<CartesBancaire> cartes)
        {
            currentClient = client;
            this.cartes = cartes;
            InitializeComponent();
        }

        private void ClientInformation_Load(object sender, EventArgs e)
        {
            // rempli les liste déroulantes et les tableaux, informations du client
            lblLogin.Text = currentClient.clientLogin;
            lblFirstName.Text = currentClient.firstName;
            lblName.Text = currentClient.name;
            lblInscriptionDate.Text = currentClient.inscriptionDate.ToShortDateString();
            lblSold.Text = currentClient.sold.ToString();
            dgvCards.DataSource = currentClient.GetCartes();
            cbBank.DataSource = Service.GetPaymentService.GetBanks();
            cbType.DataSource = Service.GetPaymentService.GetCardType();
        }

        private void tbExpirationDate_Enter(object sender, EventArgs e)
        {
            // supprime le text indiquant le format attendu
            if (tbExpirationDate.Text=="Format jj/mm/aaaaa")
            {
                tbExpirationDate.Text = string.Empty;
                tbExpirationDate.ForeColor = Color.Black;
            }
        }

        private void tbExpirationDate_Leave(object sender, EventArgs e)
        {
            // permet d'afficher s'il n'y a rien le format attendu
            if (string.IsNullOrEmpty(tbExpirationDate.Text) || string.IsNullOrWhiteSpace(tbExpirationDate.Text))
            {
                tbExpirationDate.Text = "Format jj/mm/aaaaa";
                tbExpirationDate.ForeColor = Color.Gray;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ajoute la carte avec les infos renseignées
            if (string.IsNullOrEmpty(tbNumber.Text) || string.IsNullOrWhiteSpace(tbNumber.Text) || string.IsNullOrEmpty(tbExpirationDate.Text) || string.IsNullOrWhiteSpace(tbExpirationDate.Text)
                || string.IsNullOrEmpty(tbCryto.Text) || string.IsNullOrWhiteSpace(tbCryto.Text) || string.IsNullOrEmpty(cbBank.Text)
                || string.IsNullOrEmpty(cbType.Text))
                 using (var info = new InformationBox ("Veuillez renseigner toutes les informations"))
                {
                    info.ShowDialog();
                    return;
                }

            int numero;
            if (!Int32.TryParse(tbNumber.Text,out numero))
                using (var info = new InformationBox ("Veuillez rentrer un numéro valide"))
                {
                    info.ShowDialog();
                    return;
                }

            int crypto;
            if (!Int32.TryParse(tbCryto.Text,out crypto))
                using (var info = new InformationBox ("Veuillez rentrer un cryptogramme valide"))
                {
                    info.ShowDialog();
                    return;
                }

            var result = Service.GetPaymentService.AddCarteForClient(currentClient.clientId, numero, tbExpirationDate.Text, crypto, cbType.Text, cbBank.Text);
            using (var info = new InformationBox(result))
            {
                info.ShowDialog();
                RefreshScreen();
                return;
            }            
        }

        private void RefreshScreen()
        {
            // actualise l'instance avec les nouvelles informations
            dgvCards.DataSource = currentClient.GetCartes();
            tbNumber.Text = string.Empty;
            tbCryto.Text = string.Empty;
            tbExpirationDate.Text = "Format jj/mm/aaaaa";
            tbExpirationDate.ForeColor = Color.Gray;
            cbBank.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
        }
    }
}
