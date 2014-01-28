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
                var receipt = new Receipt(double.Parse(Input.Text)); 

            }
        }
    }
}