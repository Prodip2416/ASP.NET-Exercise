using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wizard_Event
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {
           // Response.Write("Active step change to " + Wizard1.ActiveStepIndex.ToString());
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Write("CurrentStep= " + e.CurrentStepIndex.ToString() + "<br/>");
            Response.Write("CurrentStep= " + e.NextStepIndex.ToString() + "<br/>");
        }
    }
}