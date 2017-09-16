using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageSlideShow
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SlideImageUrl();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SlideImageUrl();
        }

        private void SlideImageUrl()
        {
            Random _random = new Random();
            int i = _random.Next(1, 8);
            Image1.ImageUrl = "~/Images/" + i.ToString() + ".jpg";
        }
    }
}