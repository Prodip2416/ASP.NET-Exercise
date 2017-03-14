using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ButtonLinkButtonImageButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Submit Button Click");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("Link Button Click");
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Write("Image Button Click");
        }
    }
}