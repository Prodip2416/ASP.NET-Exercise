using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StronglyTypeReference_CrossPostPosting
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Name
        {
            get
            {
                return txtName.Text;
            }
        }
        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
        }

        protected void btnStronglyType_Click(object sender, EventArgs e)
        {
           
        }
    }
}