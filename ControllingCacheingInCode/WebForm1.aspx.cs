using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControllingCacheingInCode
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //<% @OutputCache Duration = "30" VaryByParam = "None" Location = "ServerAndClient" %>

            Response.Cache.SetExpires(DateTime.Now.AddSeconds(30));
            Response.Cache.VaryByParams["None"] = true;
            Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);

            Label.Text = "This page is cached @ " + DateTime.Now.ToString();
        }
    }
}