using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int CountClick = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)
            {
                CountClick = (int) ViewState["Clicks"] + 1;
            }
            TextBox1.Text = CountClick.ToString();
            ViewState["Clicks"] = CountClick;
        }
    }
}