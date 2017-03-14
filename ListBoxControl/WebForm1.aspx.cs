using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBoxControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (ListBox1.SelectedIndex != -1)
            //{
            //    Response.Write(ListBox1.SelectedItem.Text + "<br/>");
            //    Response.Write(ListBox1.SelectedItem.Value + "<br/>");
            //    Response.Write(ListBox1.SelectedIndex.ToString() + "<br/>");
            //}

            foreach(ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    Response.Write("Text = " + li.Text + "<br/>");
                    Response.Write("Value = " + li.Value + "<br/>");
                    Response.Write("Index = " + ListBox1.SelectedIndex.ToString() + "<br/>");
                    Response.Write("-----------------------<br/>");
                }
            }
        }
    }
}