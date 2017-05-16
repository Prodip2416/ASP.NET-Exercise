using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Control_Dynamicallyy_Using_Panel
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtHowMany.Text);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    if (li.Value == "Label")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            Label lbl = new Label();
                            lbl.Text = "Label - " + i.ToString();
                            pnlLabel.Controls.Add(lbl);
                        }
                    }

                    else if (li.Value == "TextBox")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            TextBox txt = new TextBox();
                            txt.Text = "TextBox - " + i.ToString();
                            pnlTextbox.Controls.Add(txt);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            Button btn = new Button();
                            btn.Text = "Button - " + i.ToString();
                            pnlButton.Controls.Add(btn);
                        }
                    }
                }
            }
        }
    }
}