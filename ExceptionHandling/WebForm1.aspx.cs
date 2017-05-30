using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionHandling
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name);

            try
            {
                DataSet ds = new DataSet();

                ds.ReadXml(Server.MapPath("~/countries.xml"));

                grid.DataSource = ds;
                grid.DataBind();
            }
            catch (System.IO.FileNotFoundException fileNotFoundException)
            {
                lblMessage.Text = "file is missing.";
            }
            catch (System.UnauthorizedAccessException unauthorizedAccessException)
            {
                lblMessage.Text = "Access not denie";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "There is unknown problem";
            }
            finally
            {
                //Clean up code
            }
          
        }
    }
}