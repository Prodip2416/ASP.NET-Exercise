using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlConnectionObject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=AUSHOMAPTO\\SQLEXPRESS; database=ADO; integrated security=true";
            // integrated security=SSPI // true.

            SqlConnection con = new SqlConnection(CS);
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from tblCity", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
            catch
            {
                lblMessage.Text = "Connection Error";
            }
            finally
            {
                con.Close();
            }
        }
    }
}