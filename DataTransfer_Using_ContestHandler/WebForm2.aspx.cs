using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransfer_Using_ContestHandler
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm1 page = (WebForm1)Context.Handler;
            lblName.Text = page.Name;
            lblemail.Text = page.Email;
        }
    }
}