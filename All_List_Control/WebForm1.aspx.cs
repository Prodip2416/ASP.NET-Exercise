using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace All_List_Control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                PopulatedItem(DropDownList1);
                PopulatedItem(CheckBoxList1);
                PopulatedItem(RadioButtonList1);
                PopulatedItem(ListBox1);
                PopulatedItem(BulletedList1);
            }
        }
        private void PopulatedItem(ListControl listitem)
        {
            ListItem li1 = new ListItem("Item1", "1");
            ListItem li2 = new ListItem("Item2", "2");
            ListItem li3 = new ListItem("Item3", "3");

            listitem.Items.Add(li1);
            listitem.Items.Add(li2);
            listitem.Items.Add(li3);
        }
        private void GetMultipleSelection(ListControl listControl)
        {
            foreach(ListItem li in listControl.Items)
            {
                if (li.Selected)
                {
                    Response.Write("Text = " + li.Text + " Value = " + li.Value + " Index = " + listControl.Items.IndexOf(li).ToString()+"<br/>");
                }
            }
        }
        private void GetSingleSelection(ListControl listControl)
        {
            if (listControl.SelectedIndex != -1)
            {
                Response.Write("Text = " + listControl.SelectedItem.Text + "<br/>");
                Response.Write("Value = " + listControl.SelectedItem.Value + "<br/>");
                Response.Write("Index = " + listControl.SelectedIndex.ToString() + "<br/>");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetMultipleSelection(ListBox1);
          //  GetSingleSelection(DropDownList1);
            //GetSingleSelection(CheckBoxList1);
            //GetSingleSelection(RadioButtonList1);
            //GetSingleSelection(BulletedList1);
        }
    }
}