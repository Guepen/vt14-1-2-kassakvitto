using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kassakvitto.Model;

namespace Kassakvitto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Input.Focus();
        }

        protected void Send_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Output.Visible = true;
                var receipt = new Receipt(double.Parse(Input.Text));
                Total.Text = String.Format("{0:C}", receipt.Subtotal);
                Discount.Text = String.Format("{0:C}", receipt.MoneyOff);
                PayValue.Text = String.Format("{0:C}", receipt.Total);
                DiscountRate.Text = String.Format("{0:P0}", receipt.DiscountRate);
               

            }
        }
    }
}