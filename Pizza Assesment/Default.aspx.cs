using System;

namespace Pizza_Assesment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double total;
            total = 0;

            if (SPRB.Checked)
            {
                total = 8;
                PLable.Text = string.Format("Small Pepperoni pizza");
            }

            else if (MPRB.Checked)
            {
                total = 10;
                PLable.Text = string.Format("Medium Pepperoni pizza");
            }
            else if (LPRB.Checked)
            {
                total = 12;
                PLable.Text = string.Format("Large Pepperoni pizza");
            }

            if (SMRB.Checked)
            {
                MLable.Text = string.Format("Small Margarita pizza");
            }
            else if (MMRB.Checked)
            {
                MLable.Text = string.Format("Medium Margarita pizza");
            }

            else if (LMRB.Checked)
            {
                MLable.Text = string.Format("Large Margarita pizza");
            }

            total = (SMRB.Checked) ? total + 8 : total;
            total = (MMRB.Checked) ? total + 10 : total;
            total = (LMRB.Checked) ? total + 12 : total;

            priceBox.Text = total.ToString();
        }


        protected void OrderButton_Click(object sender, EventArgs e)
        {
            /* PizzaDatabaseEntities1
                public virtual DbSet<Customer> Customers { get; set; }
                public virtual DbSet<Login> Logins { get; set; }
                public virtual DbSet<Order> Orders { get; set; }
                public virtual DbSet<Price> Prices { get; set; }
                public virtual DbSet<Table> Tables { get; set; }
             */


            PizzaDatabaseEntities1 db = new PizzaDatabaseEntities1();
            var order = new Order();
            //order.Pepperoni = PLable.Text.ToString();
            //order.Margarita = MLable.Text.ToString();

            order.Pepperoni = "Pepperoni";
            order.Margarita = "Margarita";

            db.Orders.Add(order);
            db.SaveChanges();
            grdOrder.DataBind();
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            PizzaDatabaseEntities1 db = new PizzaDatabaseEntities1();
            var Price = db.Prices;
            var newPrice = new Price();
            String x = priceBox.Text.ToString();
            newPrice.Price1 = x;
            db.Prices.Add(newPrice);
            db.SaveChanges();
            grdPrice.DataBind();

        }
    }
}
