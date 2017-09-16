using System;
namespace AutoEventWireUp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //protected override void OnInit(EventArgs e)
        //{
        //    this.Load += new EventHandler(Page_Load);
        //    this.LoadComplete += new EventHandler(Page_LoadComplete);
        //    this.PreRender+= new EventHandler(Page_PreRender);
        //    this.PreRenderComplete+= new EventHandler(Page_PreRenderComplete);
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(" Page_Load <br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write(" Page_LoadComplete <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender <br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write(" Page_PreRenderComplete <br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}