using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPostBackProperty
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            dropdownlist();
        }
        public void dropdownlist()
        {
            ListItem li1 = new ListItem("London");
            DropDownList1.Items.Add(li1);

            ListItem li2 = new ListItem("Sydne");
            DropDownList1.Items.Add(li2);

            ListItem li3 = new ListItem("Mumbai");
            DropDownList1.Items.Add(li3);
        }
    }
}