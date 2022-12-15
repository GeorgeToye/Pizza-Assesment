﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Order.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
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

            PriceLabel.Text = "£" + total.ToString();
        }
    }
}