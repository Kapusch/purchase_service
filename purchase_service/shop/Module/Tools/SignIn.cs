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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DoInscription();
        }

        private DialogResult DoInscription()
        {
            // fait l'inscription
            if (string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbName.Text)
                || string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbName.Text))
                return this.DialogResult = DialogResult.No;

            
            string result = Service.GetPaymentService.NewUser(tbLogin.Text, tbPassword.Text, tbName.Text, tbFirstName.Text, 0);
            if (!result.Equals("OK"))
            {
                InformationBox info = new InformationBox(result);
                using (info)
                {
                    info.ShowDialog();
                    return this.DialogResult = DialogResult.No;
                }
            }
            return this.DialogResult = DialogResult.OK;
        }
    }
}
