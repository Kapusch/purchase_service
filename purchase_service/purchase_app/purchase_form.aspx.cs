using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace purchase_app
{
    public partial class purchase_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            purchase_service.WebServiceSoapClient client = new purchase_service.WebServiceSoapClient();
            //var test = client.BankWire(numCompte.Text, Convert.ToInt32(amount.Text), choiceOperation.SelectedItem.Text);
            //resultLbl.Text = client.test(Convert.ToInt32(amount.Text)); à finir de tester
        }
    }
}