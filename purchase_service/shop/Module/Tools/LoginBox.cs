using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magasin.PurchaseService;
using Magasin;
using Magasin.Module.Tools;
using Magasin.BO;

namespace Magasin
{
    public partial class LoginBox : Form
    {

        public Client CurrentClient { get; set; }

        public LoginBox()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CheckIdentification();
        }

        private DialogResult CheckIdentification()
        {
            if (string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrWhiteSpace(tbLogin.Text))
                return this.DialogResult = DialogResult.No;

            if (string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
                return this.DialogResult = DialogResult.No;

            PurchaseService.WebServiceSoapClient service = new PurchaseService.WebServiceSoapClient();
            string result = service.PersonIdentification(tbLogin.Text, tbPassword.Text);

            int idClient;
            if (!Int32.TryParse(result, out idClient))
            {
                InformationBox displayInformation = new InformationBox(result);
                using (displayInformation)
                {
                    displayInformation.ShowDialog();
                    return this.DialogResult = DialogResult.No;
                }
            }

            CurrentClient = new Client(idClient);
            if (string.IsNullOrWhiteSpace(CurrentClient.result[1]) || string.IsNullOrEmpty(CurrentClient.result[1]))
            {
                InformationBox displayInformation = new InformationBox(CurrentClient.result[0]);
                using (displayInformation)
                {
                    displayInformation.ShowDialog();
                    return this.DialogResult = DialogResult.No;
                }
            }
            CurrentClient.FillClient(CurrentClient.result);

            return this.DialogResult = DialogResult.Yes;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }
    }
}
