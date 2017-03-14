using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommandEvent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CommandButton_Click(object sender,CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    lebel.Text = "You click print button";
                    break;
                case "Delete":
                    lebel.Text = "You click delete button";
                    break;
                case "Show":
                    if(e.CommandName.ToString()=="Top10")
                    {
                        lebel.Text = "You click show top 10 employee";
                    }
                    else
                    {
                        lebel.Text = "You click show Bottom 10 employee";
                    }
                    break;
                default:
                    lebel.Text = "We do not know which button you click";
                    break;
            }
        }
    }
}