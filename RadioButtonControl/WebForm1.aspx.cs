using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                Response.Write("Your Gender Is : " + RadioButton1.Text + "<br/>");
            }

            if (RadioButton2.Checked)
            {
                Response.Write("Your Gender Is : " + RadioButton2.Text + "<br/>");
            }

            if (RadioButton3.Checked)
            {
                Response.Write("Your Gender Is : " + RadioButton3.Text + "<br/>");
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Male Radio Button Checked <br/>");
        }
    }
}