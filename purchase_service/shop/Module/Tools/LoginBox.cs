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

namespace Magasin.Module.Tools
{
    public partial class LoginBox : Form
    {
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
                return DialogResult.No;

            if (string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
                return DialogResult.No;

            PurchaseService.WebServiceSoapClient service = new PurchaseService.WebServiceSoapClient();
            string result = service.PersonIdentification(tbLogin.Text, tbLogin.Text);

            int idClient;
            if (!Int32.TryParse(result, out idClient))
            {
                InformationBox displayInformation = new InformationBox(result);
                using (displayInformation)
                {
                    displayInformation.ShowDialog();
                    return DialogResult.No;
                }
            }
            return DialogResult.Yes;
            }
    }
}
