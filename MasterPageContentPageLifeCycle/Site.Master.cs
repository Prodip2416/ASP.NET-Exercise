using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageContentPageLifeCycle
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Master Page init Load <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Master Page Load <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Master Page PreRender Load <br/>");
        }
    }
}