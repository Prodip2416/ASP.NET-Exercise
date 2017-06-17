using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsAuthnentication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("Application code execute using.");
            Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br/>");

            Response.Write("Is User Anthnenticted");
            Response.Write(User.Identity.IsAuthenticated.ToString() + "<br/>");

            Response.Write("Authntication Type,Is Authnenticted");
            Response.Write(User.Identity.AuthenticationType + "<br/>");

            Response.Write("User Name,Is Authnenticted");
            Response.Write(User.Identity.Name + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Data\\Application2Data.XML");
            gridView.DataSource = ds;
            gridView.DataBind();
        }
    }
}