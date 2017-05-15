using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UseSubmitBehavior
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            lblMessage.Text = null;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text ="You Enter : "+ txtName.Text;
        }
    }
}