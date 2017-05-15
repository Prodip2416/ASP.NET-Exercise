using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Calender_Event_Property
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DateTime selectedData in Calendar1.SelectedDates)
            {
                Response.Write(selectedData.ToShortDateString() + "<br/>");
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if(!e.Day.IsOtherMonth && e.Day.Date.Day % 2 == 0)
             {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ForeColor = System.Drawing.Color.White;
                e.Cell.Font.Bold = true;
                e.Cell.Text = "x";
                e.Cell.ToolTip = "Blocked";
            }
            else
            {
                e.Cell.ToolTip = "Available";
            }
        }
    }
}