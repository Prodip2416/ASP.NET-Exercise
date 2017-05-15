using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiView_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                txtFirstName.Focus();
            }
        }

        protected void btnStep1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            txtEmail.Focus();
        }

        protected void btnBackToStep1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnGoToStep3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex=2;

            lblFirstName.Text = txtFirstName.Text;
            lblLastName.Text = txtLastName.Text;
            lblGender.Text = ddlGender.SelectedItem.Text;
            lblEmail.Text = txtEmail.Text;
            lblMobileNo.Text = txtMobileNo.Text;
        }

        protected void btnBackToStep2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Confirmation.aspx");
        }
    }
}