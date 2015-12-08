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

        public ClientInformation(Client client)
        {
            currentClient = client;
            InitializeComponent();
        }

        private void ClientInformation_Load(object sender, EventArgs e)
        {
            lblLogin.Text = currentClient.clientLogin;
            lblFirstName.Text = currentClient.firstName;
            lblName.Text = currentClient.name;
            lblInscriptionDate.Text = currentClient.inscriptionDate.ToShortDateString();
            lblSold.Text = currentClient.sold.ToString();
        }
    }
}
