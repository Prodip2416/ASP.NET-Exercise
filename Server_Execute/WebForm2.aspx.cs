using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Server_Execute
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Collections.Specialized.NameValueCollection priviousName = Request.Form;
            //lblName.Text= priviousName["txtName"];
            //lblEmail.Text= priviousName["txtEmail"];
            Page priviousPage = Page.PreviousPage;
            if(priviousPage != null)
            {
                lblName.Text = ((TextBox)priviousPage.FindControl("txtName")).Text;
                lblEmail.Text = ((TextBox)priviousPage.FindControl("txtEmail")).Text;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}