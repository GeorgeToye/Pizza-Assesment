using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza_Assesment
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PizzaDatabaseEntities1 db = new PizzaDatabaseEntities1();
            var Price = db.Prices;

           

        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
          
        }
    }
}