using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd=new SqlCommand();
            cmd.CommandText = "Delete tblProduct where id=105";
            cmd.Connection = con;
            con.Open();
           int rows= cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("Rows Affected = "+rows);
        }
    }
}