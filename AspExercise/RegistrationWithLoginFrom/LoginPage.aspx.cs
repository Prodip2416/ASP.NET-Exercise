using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWithLoginFrom
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserName"] != null)
            {
                lblMessages.ForeColor = System.Drawing.Color.Green;
                lblMessages.Text = "Wellcome " + Session["UserName"].ToString();
            }
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session.Remove("UserName");
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}