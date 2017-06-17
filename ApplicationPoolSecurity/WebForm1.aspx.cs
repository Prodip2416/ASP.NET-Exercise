using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationPoolSecurity
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Identity User = "+ 
                System.Security.Principal.WindowsIdentity.GetCurrent().Name);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Data\\" + fileUpload.FileName);
                gridView.DataSource = ds;
                gridView.DataBind();
                lblMessage.Text=String.Empty;
            }
            else
            {
                lblMessage.Text = "Please Select a File.";
            }
        }
    }
}