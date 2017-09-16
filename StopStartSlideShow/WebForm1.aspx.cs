using System;
using System.Collections.Generic;
namespace StopStartSlideShow
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (ViewState["ImageView"] == null)
            {
                Image1.ImageUrl = "~/Images/1.jpg";
                ViewState["ImageView"] = 1;
                Label1.Text = "Displaying Image 1";
            }
            else
            {
                int i = (int) ViewState["ImageView"];
                if (i == 8)
                {

                    Image1.ImageUrl = "~/Images/1.jpg";
                    ViewState["ImageView"] = 1;
                    Label1.Text = "Displaying Image 1";
                }
                else
                {
                    i = i + 1;
                    Image1.ImageUrl = "~/Images/" + i.ToString() + ".jpg";
                    ViewState["ImageView"] = i;
                    Label1.Text = "Displaying Image " + i.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Timer1.Enabled)
            {
                Timer1.Enabled = false;
                Button1.Text = "StartSlideBar";
            }
            else
            {
                Timer1.Enabled = true;
                Button1.Text = "StopSlideBar";
            }
        }
    }
}