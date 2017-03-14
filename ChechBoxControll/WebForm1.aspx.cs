using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ChechBoxControll
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbUserChoice = new StringBuilder();

            if(CheckBox1.Checked)
            {
                sbUserChoice.Append(CheckBox1.Text);
            }
            if (CheckBox2.Checked)
            {
                sbUserChoice.Append(", "+CheckBox2.Text);
            }
            if (CheckBox3.Checked)
            {
                sbUserChoice.Append(", "+CheckBox3.Text);
            }

            Response.Write("Your Selection " + sbUserChoice.ToString());
        }
    }
}