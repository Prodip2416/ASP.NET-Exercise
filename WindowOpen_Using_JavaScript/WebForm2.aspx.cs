using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowOpen_Using_JavaScript
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           lblName.Text= Request.QueryString["NameOfUser"];
           lblEmail.Text= Request.QueryString["Email"];
        }
    }
}