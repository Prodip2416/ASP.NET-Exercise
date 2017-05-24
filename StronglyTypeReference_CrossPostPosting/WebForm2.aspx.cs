using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StronglyTypeReference_CrossPostPosting
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          WebForm1 previousPage =(WebForm1)this.PreviousPage;
            if(previousPage!=null&& previousPage.IsCrossPagePostBack)
            {
                lblName.Text = previousPage.Name;
                lblEmail.Text = previousPage.Email;
            }
            else
            {
                lblMessage.Text = "Landing on webform 1 page.";
            }
        }
    }
}