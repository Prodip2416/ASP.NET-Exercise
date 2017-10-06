using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConnectionStringWebConfig
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS= ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con= new SqlConnection(CS);
            SqlCommand cmd= new SqlCommand("Select * from tblCity", con);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}