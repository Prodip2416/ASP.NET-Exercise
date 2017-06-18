using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsersControl
{
    public partial class CalendarControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar.Visible = false;
            }
        }
        protected void calenderImage_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar.Visible)
            {
                Calendar.Visible = false;
            }
            else
            {
                Calendar.Visible = true;
            }
        }
        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            txtDateofBirth.Text = Calendar.SelectedDate.ToShortDateString();
            Calendar.Visible = false;
        }
        public string selectedData
        {
            get{
                return txtDateofBirth.Text;
            }
            set{
                txtDateofBirth.Text = value;
                    
                    }
        }
    }
}