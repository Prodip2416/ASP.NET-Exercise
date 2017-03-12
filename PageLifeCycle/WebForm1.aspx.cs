using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page PreInit" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Init" + "<br/>");
        }
        protected void Page_InitComplate(object sender, EventArgs e)
        {
            Response.Write("Page InitComplate" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page PreLoad" + "<br/>");
        }
        protected void Page_LoadComplate(object sender, EventArgs e)
        {
            Response.Write("Page LoadComplate" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page PreRender" + "<br/>");
        }
        protected void Page_PreRenderComplate(object sender, EventArgs e)
        {
            Response.Write("Page PreRenderComplate" + "<br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            Response.Write("Page Unload" + "<br/>");
        }
    }
}