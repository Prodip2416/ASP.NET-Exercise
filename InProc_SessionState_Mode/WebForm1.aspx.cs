using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InProc_SessionState_Mode
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoToWebForm2_Click(object sender, EventArgs e)
        {
            Session["Name"] = txtName.Text;
            Session["Email"] = txtEmail.Text;
            Session["Mobile"] = txtMobile.Text;

            Response.Redirect("~/WebForm2.aspx");
        }
    }
}