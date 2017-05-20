using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Server_Transfer
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Collections.Specialized.NameValueCollection priviousNameCollection = Request.Form;
            //lblName.Text= priviousNameCollection["txtName"];
            //lblEmail.Text = priviousNameCollection["txtEmail"];

            Page priviousPage = Page.PreviousPage;
            if(priviousPage != null)
            {
                lblName.Text = ((TextBox)priviousPage.FindControl("txtName")).Text;
                lblEmail.Text = ((TextBox)priviousPage.FindControl("txtEmail")).Text;            }
        }
    }
}