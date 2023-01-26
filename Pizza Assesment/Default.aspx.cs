using System;

namespace Pizza_Assesment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void SPRB_CheckedChanged(object sender, EventArgs e)
        {
            PLable.Text = string.Format("Small Pepperoni pizza");

        }


        protected void MPRB_CheckedChanged(object sender, EventArgs e)
        {
            PLable.Text = string.Format("Medium Pepperoni pizza");
        }

        protected void LPRB_CheckedChanged(object sender, EventArgs e)
        {
            PLable.Text = string.Format("Large Pepperoni pizza");
        }

        protected void SMRB_CheckedChanged(object sender, EventArgs e)
        {
            MLable.Text = string.Format("Small Margarita pizza");
        }
        protected void MMRB_CheckedChanged(object sender, EventArgs e)
        {
            MLable.Text = string.Format("Medium Margarita pizza");
        }
        protected void LMRB_CheckedChanged(object sender, EventArgs e)
        {
            MLable.Text = string.Format("Large Margarita pizza");
        }





        protected void PriceButton_Click(object sender, EventArgs e)
        {
            double total;
            total = 0;

            if (SPRB.Checked)
                total = 8;

            else if (MPRB.Checked)
                total = 10;

            else if (LPRB.Checked)
                total = 12;

            total = (SMRB.Checked) ? total + 8 : total;
            total = (MMRB.Checked) ? total + 10 : total;
            total = (LMRB.Checked) ? total + 12 : total;

            priceBox.Text = total.ToString();

            {
               

                PizzaDatabaseEntities1 db = new PizzaDatabaseEntities1();

                var Price = db.Prices;

                var newPrice = new Price();

                String x = priceBox.Text;

                newPrice.Price1 = (priceBox.Text);

                db.Prices.Add(newPrice);
                db.SaveChanges();

                grdPrice.DataBind();

            }

        }
        

        protected void OrderButton_Click(object sender, EventArgs e)
        {
            

            PLable.Text = string.Format("Small Pepperoni pizza");


            PizzaDatabaseEntities1 db = new PizzaDatabaseEntities1();
            var Order = db.Orders;

            var newOrder = new Order();
            newOrder.Items = PLable.Text;


            Order = db.Orders;

            newOrder = new Order();
            newOrder.Items = MLable.Text;

            db.Orders.Add(newOrder);


            Response.Redirect("Order.aspx");



        }

        protected void priceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
