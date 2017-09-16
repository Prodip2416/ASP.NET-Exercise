using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisplayImageInSequence
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SlideUrl();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SlideUrl();
        }

        private void SlideUrl()
        {
            if (ViewState["ImageDisplayed"] == null)
            {
                Image1.ImageUrl = "~/Images/1.jpg";
                ViewState["ImageDisplayed"] = 1;
                lblMessage.Text = "Displaying Image - 1";
            }
            else
            {
                int i = (int)ViewState["ImageDisplayed"];
                if (i == 8)
                {
                    Image1.ImageUrl = "~/Images/1.jpg";
                    ViewState["ImageDisplayed"] = 1;
                    lblMessage.Text = "Displaying Image - 1";
                }
                else
                {
                    i = i + 1;
                    Image1.ImageUrl = "~/Images/" + i.ToString() + ".jpg";
                    ViewState["ImageDisplayed"] = i;
                    lblMessage.Text = "Displaying Image - " + i.ToString();
                }
            }

        }
    }
}