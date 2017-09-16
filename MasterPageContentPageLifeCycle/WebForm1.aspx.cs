using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageContentPageLifeCycle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Content Page Init Event<br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Content Page Load Event<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Content Page PreRender Event<br/>");
        }
        protected void TextBox1_Init(object sender, EventArgs e)
        {
            Response.Write("TextBox Init Event<br/>");
        }
        protected void TextBox1_Load(object sender, EventArgs e)
        {
            Response.Write("TextBox Load Event<br/>");
        }
        protected void TextBox1_PreRender(object sender, EventArgs e)
        {
            Response.Write("TextBox PreRender Event<br/>");
        }
        protected void TestUC1_Init(object sender, EventArgs e)
        {
            Response.Write("UserControl Init Event<br/>");
        }
        protected void TestUC1_Load(object sender, EventArgs e)
        {
            Response.Write("UserControl Load Event<br/>");
        }
        protected void TestUC1_PreRender(object sender, EventArgs e)
        {
            Response.Write("UserControl PreRender Event<br/>");
        }
    }
}