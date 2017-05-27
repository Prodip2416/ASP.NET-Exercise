using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookieless_SessionState
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                lblName.Text = Session["Name"].ToString();
            }
            if (Session["Email"] != null)
            {
                lblEmail.Text = Session["Email"].ToString();
            }
        }
    }
}