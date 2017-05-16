using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Panel_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AdminPanel.Visible = false;
                NonAdminPanel.Visible = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "-1")
            {
                AdminPanel.Visible = false;
                NonAdminPanel.Visible = false;
            }
            else if(DropDownList1.SelectedValue=="Admin")
            {
                AdminPanel.Visible = true;
                NonAdminPanel.Visible = false;
            }
            else
            {
                AdminPanel.Visible = false;
                NonAdminPanel.Visible = true;
            }
        }
    }
}