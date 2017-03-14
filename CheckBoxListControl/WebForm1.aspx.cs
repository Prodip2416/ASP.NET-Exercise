using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxListControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(CheckBoxList1.SelectedIndex.ToString());
            Response.Write("<br/>");

            if (CheckBoxList1.SelectedItem != null)
            {
                Response.Write(CheckBoxList1.SelectedItem.Text);
                Response.Write("<br/>");
                Response.Write(CheckBoxList1.SelectedItem.Value);
            }


            //    foreach(ListItem li in CheckBoxList1.Items)
            //    {
            //        if (li.Selected)
            //        {
            //            Response.Write("Text = " + li.Text+", ");
            //            Response.Write("Value = " + li.Value + ", ");
            //            Response.Write("Index = " + CheckBoxList1.Items.IndexOf(li) + ", ");
            //            Response.Write("<br/>");
            //        }
            //    }
        }
    }
}