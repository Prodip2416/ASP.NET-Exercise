using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wizard_Control_Templates
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
  
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 0)
            {
                Step1TextBox.Focus();
            }
            else if (Wizard1.ActiveStepIndex == 1)
            {
                Step2TextBox.Focus();
            }
            else if (Wizard1.ActiveStepIndex == 2)
            {
                Step3TextBox.Focus();
            }
        }
    }
}