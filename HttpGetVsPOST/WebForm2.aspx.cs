using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HttpGetVsPOST
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = Request.QueryString["FirstName"];
            lblLastName.Text = Request.QueryString["LastName"];
            lblEmail.Text = Request.QueryString["Email"];
        }
    }
}