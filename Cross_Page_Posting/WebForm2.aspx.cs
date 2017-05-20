using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cross_Page_Posting
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Page previousPgae= Page.PreviousPage;
            if(previousPgae !=null && previousPgae.IsCrossPagePostBack)
            {
                lblName.Text = ((TextBox)previousPgae.FindControl("txtName")).Text;
                lblEmail.Text = ((TextBox)previousPgae.FindControl("txtEmail")).Text;
            }
            else
            {
                lblMessage.Text = "You are landed now webform1  page.";
            }
        }
    }
}