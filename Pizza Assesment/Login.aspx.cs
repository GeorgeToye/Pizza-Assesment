using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza_Assesment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void FNTextBox_TextChanged(object sender, EventArgs e)
        {
            PizzaDatabaseEntities1 db = new PizzaDatabaseEntities1();
            var Customers = db.Customers;

            var newCustomers = new Customer();
            newCustomers.FirstName = FNTextBox.Text;


            Customers = db.Customers;


            db.Customers.Add(newCustomers);
        }
    }
}